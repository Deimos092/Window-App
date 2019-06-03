using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Collections;

namespace Combo_Programs
{
	public partial class Number_System : Form
	{
		private Point mouseOffset;
		private bool isMouseDown = false, signA,signB;
		Num_Sys NumSys = new Num_Sys();
		Revers_System Revers = new Revers_System();

		public Number_System()
		{
			InitializeComponent();
		}
		
		private void _Rev_calculate(int A,int B,string Operation, int Bit_Grid)//-----------------------------------------------
		{
			bool[] _Res = { false };
			bool[] _A = ( signA ) ? Revers.XOR(A , Bit_Grid) : Revers.Binary(A , Bit_Grid);// XOR операция над числом
			bool[] _B = ( signB ) ? Revers.XOR(B , Bit_Grid) : Revers.Binary(B , Bit_Grid);// XOR операция над числом
			TB_prom_a.Text = Revers.GetString(_A);//--- Вывод промежуточного результата в текст бокс A
			TB_prom_b.Text = Revers.GetString(_B);//--- Вывод промежуточного результата в текст бокс B

			switch (Operation)
			{
				case "+":
					_Res = Revers.Plus(_A , _B);
					OverFloat(Revers.P0 , ref _Res);
						TB_Result.Text = Revers.GetString(_Res);
					break;
				case "*":
					for ( int i = 0 ; i < B - 1 ; i++ ) 
						if ( i == 0 )
							//---- Умножение работает правильно но только с четными числами и с некоторыми не четными очень странно кроме 3,6
							_Res = Revers.Plus(_A , _A);
						else
							_Res = Revers.Plus(_A , _Res);//---- Помоему лучше оставить только + и -
					OverFloat(Revers.P0 ,ref _Res);

					if ( B == 1 || A == 1 )
						TB_Result.Text = Revers.GetString(( A == 1 ) ? _B : _A);
					else
						TB_Result.Text = Revers.GetString(_Res);
					break;
				case "-":
					break;
				case "/":
					break;
			}
			
		}
		//----- Кнопка ОК -----
		private void Btn_OK_Click( object sender , EventArgs e )
		{
			bool IsOk = isAllOkay(TB_A.Text , TB_SYS_A.Text) && isAllOkay(TB_B.Text , TB_SYS_B.Text) && TB_SYS_RES.Text != "";
			int A = NumSys.Any_to_Dec(TB_A.Text , byte.Parse(TB_SYS_A.Text));
			if ( chkb_Operation.Checked == true )
			{
				int B = NumSys.Any_to_Dec(TB_B.Text , byte.Parse(TB_SYS_B.Text));
				if ( IsOk && chkb_NumRep.Checked)
					_Rev_calculate(A , B , lb_Operate.Text , int.Parse(TB_SYS_RES.Text));
				else if ( IsOk && !chkb_NumRep.Checked )
					TB_Result.Text = NumSys.Dec_to_Any(NumSys.Calc_AB(A , B , lb_Operate.Text) , byte.Parse(TB_SYS_RES.Text));
			}
			else if ( isAllOkay(TB_A.Text , TB_SYS_A.Text) && !chkb_NumRep.Checked )
				TB_Result.Text = NumSys.Dec_to_Any(A , byte.Parse(TB_SYS_RES.Text)).ToString();
		}
		//-----------------------------------------------------------------------------------------


		//Блокировка кнопки ОК если "Разрядность Сетки" меньше чем значения в текст боксах А и Б
		//А так же выделяет красным в каком текст боксе это значение превышает допустимый предел
		private bool Red(TextBox T)
		{
			if ( TB_SYS_RES.Text != "" )
				if (isAllOkay(T.Text,TB_SYS_RES.Text) && Revers.Is_Beyond(NumSys.Return_Number(T.Text) , int.Parse(TB_SYS_RES.Text)) )
			{
				T.BackColor = ColorTranslator.FromHtml("#333337");
				T.ForeColor = ColorTranslator.FromHtml("#D0D0D0");
				return true;
			}
			else
			{
				T.BackColor = ColorTranslator.FromHtml("#513337");
				T.ForeColor = ColorTranslator.FromHtml("#CA3337");
				return false;
			}
			return false;
		}
		private void _OverFloat( bool flag )
		{
			if ( flag )
			{
				lb_OverFloat.Text = "Переполнение";
				lb_OverFloat.Location = new Point(178 , 200);
				lb_OverFloat.ForeColor = ColorTranslator.FromHtml("#FF4444");
				lb_OverFloat.BackColor = ColorTranslator.FromHtml("#402222");
			}
			else
			{
				lb_OverFloat.Text = "Нет переполнения";
				lb_OverFloat.Location = new Point(158 , 200);
				lb_OverFloat.ForeColor = ColorTranslator.FromHtml("#08FF00");
				lb_OverFloat.BackColor = ColorTranslator.FromHtml("#1B371B");
			}
		}
		private void OverFloat(bool flag,ref bool[] Res)
		{
			if ( flag )
			{
				_OverFloat(flag);
				Res = Revers.OverFloat(Res);
			}
			else
				_OverFloat(flag);
		}
		//Проверка на правильный ввод данных
		private static bool isAllOkay( string TB , string Sys_code )
		{
			if ( TB.Length != 0 & Sys_code.Length != 0 )
				return true;
			return false;
		}
		private void Block_OK(object s)
		{
			TextBox T = (TextBox)s;
			if (Red(T))
				Btn_OK.Enabled = true;
			else Btn_OK.Enabled = false;
		}
		private void TB_A_TextChanged( object sender , EventArgs e )
		{
			if(chkb_NumRep.Checked)
			Block_OK(sender);
		}
		private void TB_B_TextChanged( object sender , EventArgs e )
		{
			if(chkb_NumRep.Checked)
			Block_OK(sender);
		}
		//-----------------------------------------------------------------------------------------

		//Проверяю кодировку по максимальному числу
		//Если максимальное число А будет меньше значения из TB_SYS_ 
		//Значит число можно прописать в этой кодировке 
		//Например число А = 9C максимальное С = 12 значить кодировка TB_SYS_ должна быть >= 13
		private byte _max_value( TextBox T , byte max_number = 1 )
		{
			byte max_ = 1;
			int value;

			char[] CharArray = T.Text.ToCharArray();
			foreach ( char a in CharArray )
			{
				value = NumSys.Return_Number(a.ToString());
				if ( value > max_number )
					max_ = (byte)value;
				else
					max_ = (byte)max_number;
			}
			return max_;
		}
		private bool CorrectInput(TextBox T,byte max)
		{
			if ( ( T.Text != "" && byte.Parse(T.Text) >= max + 1 | T.Text == "1" ) && int.Parse(T.Text) <= 16 )
				return true;
			else
				return false;
		}
		private void TB_SYS_A_TextChanged( object sender , EventArgs e )
		{
			byte max = _max_value(TB_A);
			TextBox T = (TextBox)sender;
			if ( CorrectInput(T , max) )
				return;
			else
				T.Text = "";
		}
		private void TB_SYS_B_TextChanged( object sender , EventArgs e )
		{
			byte max = _max_value(TB_B);
			TextBox T = (TextBox)sender;
			if ( CorrectInput(T, max) )
				return;
			else
				T.Text = "";
		}
		//-----------------------------------------------------------------------------------------
		private void TB_SYS_RES_TextChanged( object sender , EventArgs e )
		{
			if ( TB_SYS_RES.Text != "" && byte.Parse(TB_SYS_RES.Text) <= 16 )
				Block_OK(sender);
			else
				TB_SYS_RES.Text = "";
		}

		//Работа со знаком у текстбоксов
		//А так же присваивание значений глобальным переменным signA signB
		private bool Sign( KeyEventArgs e , Label s )
		{
			if ( e.KeyCode == Keys.Subtract && s.Visible == false )
				return true;
			else
				return false;
		}
		private void TB_Key_A_Down( object sender , KeyEventArgs e )
		{
			signA = Sign(e , lb_sign_A);
			if ( signA )
				lb_sign_A.Visible = true;
			else
				lb_sign_A.Visible = false;
		}
		private void TB_Key_B_Down( object sender , KeyEventArgs e )
		{
			signB = Sign(e , lb_sign_B);
			if ( signB )
				lb_sign_B.Visible = true;
			else
				lb_sign_B.Visible = false;
		}
		//-----------------------------------------------------------------------------------------
		private void Btn_close_Click( object sender , EventArgs e )
		{
			this.Close();
		}
		//Проверка значений в текст боксах А и Б на ввод цифр, буквы игнорируются
		private void TB_KeyPress( object sender , KeyPressEventArgs e )
		{
			if ( e.KeyChar == 8 ) return;
			if ( e.KeyChar > 45 && e.KeyChar < 58 || ( e.KeyChar > 64 && e.KeyChar < 71 ) ) return;

			e.Handled = true;
		}

		//Проверка значений в текст боксах кодировок на цифры, буквы игнорируются
		//а так же на обработку события нажатия кнопки ENTER что бы не кликать на кнопку ОК
		private void TB_Sys_KeyPress( object sender , KeyPressEventArgs e )
		{
			if ( e.KeyChar == 8 ) return;
			if ( e.KeyChar > 45 && e.KeyChar < 58 ) return;
			if ( e.KeyChar == (char)Keys.Enter )
				Btn_OK_Click(sender , e);
			e.Handled = true;
		}
		//-----------------------------------------------------------------------------------------
		private void Btn_plus_Click( object sender , EventArgs e )
		{
			lb_Operate.Text = "+";
			Reset_btn_Color();
			Button B = (Button)sender;
			B.BackColor = ColorTranslator.FromHtml("#436443");
		}
		private void Btn_minus_Click( object sender , EventArgs e )
		{
			lb_Operate.Text = "-";
			Reset_btn_Color();
			Button B = (Button)sender;
			B.BackColor = ColorTranslator.FromHtml("#436443");
		}
		private void Btn_multy_Click( object sender , EventArgs e )
		{
			lb_Operate.Text = "*";
			Reset_btn_Color();
			Button B = (Button)sender;
			B.BackColor = ColorTranslator.FromHtml("#434364");
		}
		private void Btn_div_Click( object sender , EventArgs e )
		{
			lb_Operate.Text = "/";
			Reset_btn_Color();
			Button B = (Button)sender;
			B.BackColor = ColorTranslator.FromHtml("#434364");
		}
		private void Reset_btn_Color()
		{ 
			Btn_plus.BackColor = ColorTranslator.FromHtml("#333337");
			Btn_minus.BackColor = ColorTranslator.FromHtml("#333337");
			Btn_multy.BackColor = ColorTranslator.FromHtml("#333337"); 
			Btn_div.BackColor = ColorTranslator.FromHtml("#333337");
		}
		private void btn_clear_Click( object sender , EventArgs e )
		{
			TB_A.Text = "";
			TB_B.Text = "";
			TB_SYS_A.Text = "";
			TB_SYS_B.Text = "";
			TB_prom_a.Text = "";
			TB_prom_b.Text = "";
			TB_Result.Text = "";
			TB_SYS_RES.Text = "";
			lb_Operate.Text = "";
		}
		private void checkBox1_CheckedChanged( object sender , EventArgs e )
		{
			if ( chkb_Operation.Checked == true )
			{
				LB_SYS_B.Enabled = true;
				LB_B.Enabled = true;
				TB_SYS_B.Enabled = true;
				TB_B.Enabled = true;
				GB_Operators.Enabled = true;
			}
			else
			{
				LB_SYS_B.Enabled = false;
				LB_B.Enabled = false;
				TB_SYS_B.Enabled = false;
				TB_B.Enabled = false;
				GB_Operators.Enabled = false;
				lb_Operate.Text = "";
				Reset_btn_Color();
			}
		}
		private void chkb_NumRep_CheckedChanged( object sender , EventArgs e )
		{
			if ( chkb_NumRep.Checked )
			{
				chkb_ReversCode.Visible = true;
				chkb_Operation.Checked = true;
				Btn_div.Enabled = false;
				Btn_minus.Enabled = false;
				TB_prom_a.Visible = true;
				TB_prom_b.Visible = true;
				lb_OverFloat.Visible = true;
				lb_prom_a.Visible = true;
				lb_prom_B.Visible = true;
				lb_prom.Visible = true;
				TB_Result.Text = "";
				lb_resCode.Text = "Разряд сетки";
			}
			else
			{
				chkb_ReversCode.Visible = false;
				chkb_Operation.Checked = false;
				Btn_OK.Enabled = true;
				Btn_div.Enabled = true;
				Btn_minus.Enabled = true;
				TB_prom_a.Visible = false;
				TB_prom_b.Visible = false;
				lb_OverFloat.Visible = false;
				lb_prom_a.Visible = false;
				lb_prom_B.Visible = false;
				lb_prom.Visible = false;
				TB_Result.Text = "";
				lb_resCode.Text = "Кодировка";
				TB_A.BackColor = ColorTranslator.FromHtml("#333337");
				TB_A.ForeColor = ColorTranslator.FromHtml("#D0D0D0");
				TB_B.BackColor = ColorTranslator.FromHtml("#333337");
				TB_B.ForeColor = ColorTranslator.FromHtml("#D0D0D0");
				
			}
		}
		//---- События для возможности перетаскивание формы в любом месте без рамки
		private void Number_System_MouseMove( object sender , MouseEventArgs e )
		{
			if ( isMouseDown )
			{
				Point mousePos = Control.MousePosition;
				mousePos.Offset(mouseOffset.X , mouseOffset.Y);
				Location = mousePos;
			}
		}
		private void Number_System_MouseUp( object sender , MouseEventArgs e )
		{
			if ( e.Button == MouseButtons.Left )
				isMouseDown = false;
		}
		private void Number_System_MouseDown( object sender , MouseEventArgs e )
		{
			int xOffset;
			int yOffset;

			if ( e.Button == MouseButtons.Left )
			{
				xOffset = -e.X - SystemInformation.FrameBorderSize.Width + 5;
				yOffset = -e.Y - SystemInformation.CaptionHeight + SystemInformation.FrameBorderSize.Height + 20;
				mouseOffset = new Point(xOffset , yOffset);
				isMouseDown = true;
			}
		}	
	}
}