using System;
using System.Drawing;
using System.Windows.Forms;

namespace Combo_Programs
{
	public partial class Calc : Form
	{
		public double A, B;
		public int count;
		private bool Znak = true;

		private Point mouseOffset;
		private bool isMouseDown = false;
		public Calc()
		{
			InitializeComponent();
		}
		private bool IsLenthMax(string txt)
		{
			if ( txt.Length < tb_calc.MaxLength )
				return true;
			else
				return false;
		}
		private void Calculate()
		{
			if(tb_calc.Text != "")
			switch ( count )
			{
				case 1:

						B = A + double.Parse(tb_calc.Text);
						tb_calc.Text = Math.Round(B, 5).ToString();
						lb_operator.Text = "";

					break;

				case 2:

						B = A - double.Parse(tb_calc.Text);
						tb_calc.Text = Math.Round(B, 5).ToString();
						lb_operator.Text = "";
					break;

				case 3:

						B = A * double.Parse(tb_calc.Text);
						tb_calc.Text = Math.Round(B, 5).ToString();
						lb_operator.Text = "";
					break;

				case 4:
						B = A / double.Parse(tb_calc.Text);
						tb_calc.Text = Math.Round(B, 5).ToString();
						lb_operator.Text = "";
					break;

				case 6:
						B = double.Parse(tb_calc.Text);
						B = Math.Pow(A, B);
						tb_calc.Text = Math.Round(B, 10).ToString();
						lb_operator.Text = "";
					break;

				case 7:
						B = A % double.Parse(tb_calc.Text);
						tb_calc.Text = Math.Round(B, 5).ToString();
						lb_operator.Text = "";
					break;
			}
		}//---Вычисляем---

		#region Other_Operators_Button

		private void btn_plus_Click( object sender, EventArgs e )
		{
			if ( tb_calc.Text != "" )
			{
				A = double.Parse(tb_calc.Text);
				lb_operator.Text = tb_calc.Text + " +";
				tb_calc.ResetText();
				Znak = true;
				count = 1;
			}
			else
				tb_calc.Select();
		}

		private void btn_minus_Click( object sender, EventArgs e )
		{
			if ( tb_calc.Text != "" )
			{
				A = double.Parse(tb_calc.Text);
				lb_operator.Text = tb_calc.Text + " -";
				tb_calc.ResetText();
				Znak = true;
				count = 2;
			}
			else
				tb_calc.Select();
		}

		private void btn_multy_Click( object sender, EventArgs e )
		{
			if ( tb_calc.Text != "" )
			{
				A = double.Parse(tb_calc.Text);
				lb_operator.Text = tb_calc.Text + " *";
				tb_calc.ResetText();
				Znak = true;
				count = 3;
			}
			else
				tb_calc.Select();
		}

		private void btn_div_Click( object sender, EventArgs e )
		{
			if ( tb_calc.Text != "" )
			{
				A = double.Parse(tb_calc.Text);
				lb_operator.Text = tb_calc.Text + " /";
				tb_calc.ResetText();
				Znak = true;
				count = 4;
			}
			else
				tb_calc.Select();
		}

		private void btn_sqrt_Click( object sender, EventArgs e )
		{
			if ( tb_calc.Text != "" )
			{
				A = double.Parse(tb_calc.Text.Replace("-",""));
				lb_operator.Text ="√ " + tb_calc.Text;
				A = Math.Sqrt(A);
				tb_calc.Text = Math.Round(A , 5).ToString();
				lb_operator.Text = "";
				Znak = true;
			}
			else
				tb_calc.Select();
		}

		private void btn_pow_Click( object sender, EventArgs e )
		{
			if ( tb_calc.Text != "" )
			{
				A = double.Parse(tb_calc.Text);
				lb_operator.Text = tb_calc.Text + " ²";
				tb_calc.ResetText();
				Znak = true;
				count = 6;
			}
			else
				tb_calc.Select();
		}

		private void btn_proc_Click( object sender, EventArgs e )
		{
			if ( tb_calc.Text != "" )
			{
				A = double.Parse(tb_calc.Text);
				lb_operator.Text = tb_calc.Text + " %";
				tb_calc.ResetText();
				Znak = true;
				count = 7;
			}
			else
				tb_calc.Select();
		}

		private void Change_Sign_Click( object sender, EventArgs e )
		{
			if ( Znak == true )
			{
				tb_calc.Text = "-" + tb_calc.Text;
				Znak = false;
			}
			else
			{
				tb_calc.Text = tb_calc.Text.Replace("-", "");
				Znak = true;
			}
		}

		private void btn_Clear_Click( object sender, EventArgs e )
		{
			tb_calc.ResetText();
			lb_operator.ResetText();
		}

		private void btn_Backspace_Click( object sender, EventArgs e )
		{
			if ( tb_calc.Text != "" )
				tb_calc.Text = tb_calc.Text.Substring(0, tb_calc.Text.Length - 1);
		}

		#endregion Other_Operators_Button

		#region Buttons (0-9)

		private void btn_point_Click( object sender, EventArgs e )
		{
			if(IsLenthMax(tb_calc.Text))
			tb_calc.Text = tb_calc.Text + ".";
		}

		private void btn_1_Click( object sender, EventArgs e )
		{
			if ( IsLenthMax(tb_calc.Text) )
				tb_calc.Text += "1";
		}

		private void btn_2_Click( object sender, EventArgs e )
		{
			if ( IsLenthMax(tb_calc.Text) )
				tb_calc.Text += "2";
		}

		private void btn_3_Click( object sender, EventArgs e )
		{
			if ( IsLenthMax(tb_calc.Text) )
				tb_calc.Text += "3";
		}

		private void btn_4_Click( object sender, EventArgs e )
		{
			if ( IsLenthMax(tb_calc.Text) )
				tb_calc.Text += "4";
		}

		private void btn_5_Click( object sender, EventArgs e )
		{
			if ( IsLenthMax(tb_calc.Text) )
				tb_calc.Text += "5";
		}

		private void btn_6_Click( object sender, EventArgs e )
		{
			if ( IsLenthMax(tb_calc.Text) )
				tb_calc.Text += "6";
		}

		private void btn_7_Click( object sender, EventArgs e )
		{
			if ( IsLenthMax(tb_calc.Text) )
				tb_calc.Text += "7";
		}

		private void btn_8_Click( object sender, EventArgs e )
		{
			if ( IsLenthMax(tb_calc.Text) )
				tb_calc.Text += "8";
		}

		private void btn_9_Click( object sender, EventArgs e )
		{
			if ( IsLenthMax(tb_calc.Text) )
				tb_calc.Text += "9";
		}

		private void btn_result_Click( object sender, EventArgs e )
		{
			Calculate();
			lb_operator.Text = "";
		}

		private void btn_0_Click( object sender, EventArgs e )
		{
			if ( IsLenthMax(tb_calc.Text) )
				tb_calc.Text += "0";
		}

		#endregion Buttons (0-9)

		private void Calc_MouseMove( object sender , MouseEventArgs e )
		{
			if ( isMouseDown )
			{
				Point mousePos = Control.MousePosition;
				mousePos.Offset(mouseOffset.X , mouseOffset.Y);
				Location = mousePos;
			}
		}

		private void Calc_MouseUp( object sender , MouseEventArgs e )
		{
			if ( e.Button == MouseButtons.Left )
			{
				isMouseDown = false;
			}
		}

		private void button1_Click( object sender , EventArgs e )
		{
			this.Close();
		}

		private void Calc_MouseDown( object sender , MouseEventArgs e )
		{
			int xOffset;
			int yOffset;

			if ( e.Button == MouseButtons.Left )
			{
				xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
				yOffset = -e.Y - SystemInformation.CaptionHeight +
					SystemInformation.FrameBorderSize.Height + 20;
				mouseOffset = new Point(xOffset , yOffset);
				isMouseDown = true;
			}
		}
	}
}