using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combo_Programs
{
	public partial class Main_F : Form
	{
		private Point mouseOffset;
		private bool isMouseDown = false;
		public Main_F()
		{
			InitializeComponent();
		}

		private void button1_Click( object sender, EventArgs e )
		{
			Environment.Exit(0);
		}

		private void btn_OK_Click( object sender, EventArgs e )
		{
			switch ( CB_List.SelectedIndex )
			{
				case 0:
					Form Calc = new Calc();
					Calc.Show();
					break;

				case 1:
					Form myPage = new MyPage();
					myPage.Show();
					break;

				case 2:
					Form RedactorTxt = new RedactorTxt();
					RedactorTxt.Show();
					break;

				case 3:
					Form Number_Sys = new Number_System();
					Number_Sys.Show();
					break;

				case 4:
					Form Alaram_ = new Alaram();
					Alaram_.Show();
					break;
                case 5:
                    Form SaleManager_ = new Sales_Manager();
                    SaleManager_.Show();
                    break;
			}
		}

		private void CB_List_MouseEnter( object sender, EventArgs e )
		{
			CB_List.DroppedDown = true;
		}

		private void CB_List_MouseLeave( object sender, EventArgs e )
		{
			CB_List.DroppedDown = false;
		}

		private void CB_List_MouseEnter( object sender, MouseEventArgs e )
		{
			CB_List.DroppedDown = true;
		}

		private void Main_F_MouseMove( object sender , MouseEventArgs e )
		{
			if ( isMouseDown )
			{
				Point mousePos = Control.MousePosition;
				mousePos.Offset(mouseOffset.X , mouseOffset.Y);
				Location = mousePos;
			}
		}

		private void Main_F_MouseUp( object sender , MouseEventArgs e )
		{
			if ( e.Button == MouseButtons.Left )
			{
				isMouseDown = false;
			}
		}

		private void Main_F_MouseDown( object sender , MouseEventArgs e )
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

		private void Main_F_KeyUp( object sender , KeyEventArgs e )
		{
			if ( e.KeyCode == Keys.Escape ) this.Close();
		}
	}
}