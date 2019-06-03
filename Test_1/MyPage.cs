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
	public partial class MyPage : Form
	{
		private Point mouseOffset;
		private bool isMouseDown = false;
		public MyPage()
		{
			InitializeComponent();
		}

		private void btnClose_Click( object sender, EventArgs e )
		{
			this.Close();
		}

		private void btnOK_Click( object sender, EventArgs e )
		{
			if ( tbName.TextLength == 0 )
			{
				MessageBox.Show("Поле с именем пустое, Введите имя");
				tbName.Text = "Name ";
				return;

			}
			else if ( tbAddres.TextLength == 0 )
			{
				MessageBox.Show("Поле с адресом пустое, Введите адрес");
				tbAddres.Text = "Addres ";
				return;
			}
			else
			{
				lb_Name.Text = tbName.Text;
				lb_occupation.Text = tbOccupation.Text;
				lb_location.Text = tbAddres.Text;
				lb_Phone.Text = tb_phone.Text;
				lb_website.Text = tb_Website.Text;
			}
		}

		private void btnHelp_Click( object sender, EventArgs e )
		{

			HelpInfo frm = new HelpInfo();
			frm.Show();
		}

		private void btnClear_Click( object sender, EventArgs e )
		{
			tb_Website.Text = "https://www.mywebsite.com";
			tb_phone.Text = "Phone number";
			tbName.Text = "Name";
			tbAddres.Text = "Addres";
			tbOccupation.Text = "Proffesion";
			tbAge.Text = "Age";
			lb_Name.Text = "Name";
			lb_location.Text = "Your location";
			lb_occupation.Text = "Occupation";
			lb_Phone.Text = "Phone number";
			lb_website.Text = "https://www.mywebsite.com";
			btnOK.Visible = false;

		}

		private void tbAge_KeyPress( object sender, KeyPressEventArgs e )
		{
			if ( e.KeyChar == 8 ) return;
			if ( (e.KeyChar >= 48) && (e.KeyChar <= 57) ) return;
			e.Handled = true;
		}

		private void tbName_Validated( object sender, EventArgs e )
		{
			if ( tbName.Text == "Name" )
			{
				btnOK.Enabled = false;
			}
			else
			{
				btnOK.Enabled = true;
			}
		}

		private void tbAddres_Validating( object sender, CancelEventArgs e )
		{
			if ( tbAddres.Text == "Addres" )
			{
				btnOK.Enabled = false;
			}
			else
			{
				btnOK.Enabled = true;
			}
		}

		private void tbOccupation_Validating( object sender, CancelEventArgs e )
		{
			if ( tbOccupation.Text == "Proffesion" )
			{
				btnOK.Enabled = false;
			}
			else
			{
				btnOK.Enabled = true;
			}
		}

		private void tbOccupation_MouseEnter( object sender, EventArgs e )
		{
			tbOccupation.DroppedDown = true;
		}

		private void tbOccupation_MouseLeave( object sender, EventArgs e )
		{
			tbOccupation.DroppedDown = false;
		}

		private void tbName_TextChanged( object sender, EventArgs e )
		{
			if ( tbName.Text != "Name" && tbName.TextLength > 3 )
				tbAddres.Enabled = true;
			else
				tbAddres.Enabled = false;
		}

		private void tbAge_Enter( object sender , EventArgs e )
		{
			if(tbAge.Text == "Age")
			tbAge.Text = "";
		}

		private void tbName_Enter( object sender , EventArgs e )
		{
			if ( tbName.Text == "Name" )
				tbName.Text = "";

		}

		private void tbAddres_Enter( object sender , EventArgs e )
		{
			if ( tbAddres.Text == "Addres" )
				tbAddres.Text = "";
		}
		private void tb_Website_Enter( object sender , EventArgs e )
		{
			if ( tb_Website.Text == "https://www.mywebsite.com" )
				tb_Website.Text = "https://";
		}
		private void tb_phone_Enter( object sender , EventArgs e )
		{
			if ( tb_phone.Text == "Phone number" )
				tb_phone.Text = "";
		}
		private void MyPage_KeyUp( object sender , KeyEventArgs e )
		{
			if ( e.KeyCode == Keys.Escape ) this.Close();
		}

		private void MyPage_MouseDown( object sender , MouseEventArgs e )
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

		private void MyPage_MouseMove( object sender , MouseEventArgs e )
		{
			if ( isMouseDown )
			{
				Point mousePos = Control.MousePosition;
				mousePos.Offset(mouseOffset.X , mouseOffset.Y);
				Location = mousePos;
			}
		}

		private void MyPage_MouseUp( object sender , MouseEventArgs e )
		{
			if ( e.Button == MouseButtons.Left )
			{
				isMouseDown = false;
			}
		}

		private void tbName_Leave( object sender , EventArgs e )
		{
			if ( tbName.Text == "" || tbName.Text == " ")
				tbName.Text = "Name";
		}

		private void tbAddres_Leave( object sender , EventArgs e )
		{
			if ( tbAddres.Text == "" || tbAddres.Text == " ")
				tbAddres.Text = "Addres";
		}
		
		private void tbAge_Leave( object sender , EventArgs e )
		{
			if ( tbAge.Text == "" || tbAge.Text == " ")
				tbAge.Text = "Age";
		}
		private void tb_Website_Leave( object sender , EventArgs e )
		{
			if ( tb_Website.Text == "" || tb_Website.Text == " " )
				tb_Website.Text = "https://www.mywebsite.com";
		}
		private void tb_phone_Leave( object sender , EventArgs e )
		{
			if ( tb_phone.Text == "" || tb_phone.Text == " " )
				tb_phone.Text = "Phone number";
		}

		private void tbAddres_TextChanged( object sender , EventArgs e )
		{
			if ( tbAddres.Text != "Addres" && tbAddres.TextLength > 5 )
				tb_Website.Enabled = true;
			else
				tb_Website.Enabled = false;
		}

		private void tb_Website_TextChanged( object sender , EventArgs e )
		{
			if ( tb_Website.Text != "https://www.mywebsite.com" && tb_Website.TextLength > 15 )
				tbOccupation.Enabled = true;
			else
				tbOccupation.Enabled = false;
		}

		private void tbOccupation_SelectedIndexChanged( object sender , EventArgs e )
		{
			if ( tbOccupation.Text != "Proffesion" )
				tb_phone.Enabled = true;
			else
				tb_phone.Enabled = false;
		}
		private void tbOccupation_TextChanged( object sender , EventArgs e )
		{
			if ( tbOccupation.Text != "Proffesion" )
				tb_phone.Enabled = true;
			else
				tb_phone.Enabled = false;
		}
		private void tb_phone_TextChanged( object sender , EventArgs e )
		{
			if ( tb_phone.Text != "Phone number" && tb_phone.TextLength > 8 )
				tbAge.Enabled = true;
			else
				tbAge.Enabled = false;
		}

		private void tbAge_TextChanged( object sender , EventArgs e )
		{
			if ( tbAge.Text != "Age" && tbAge.TextLength > 1 )
			{
				btnOK.Enabled = true;
				btnOK.Visible = true;
			}
			else
				btnOK.Visible = false;
		}

		private void tb_phone_KeyPress( object sender , KeyPressEventArgs e )
		{
			if ( e.KeyChar == 8 ) return;
			if ( e.KeyChar == 32 ) return;
			if ( ( e.KeyChar >= 48 ) && ( e.KeyChar <= 57 ) ) return;
			e.Handled = true;
		}
	}
}
