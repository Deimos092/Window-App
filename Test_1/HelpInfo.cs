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
	public partial class HelpInfo : Form
	{
		public HelpInfo()
		{
			InitializeComponent();
		}
		private Point mouseOffset;
		private bool isMouseDown = false;
		private void btn_Close_Click( object sender, EventArgs e )
		{
			this.Close();
		}

		private void HelpInfo_MouseUp( object sender , MouseEventArgs e )
		{
			if ( e.Button == MouseButtons.Left )
			{
				isMouseDown = false;
			}
		}

		private void HelpInfo_MouseMove( object sender , MouseEventArgs e )
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

		private void HelpInfo_MouseDown( object sender , MouseEventArgs e )
		{
			if ( isMouseDown )
			{
				Point mousePos = Control.MousePosition;
				mousePos.Offset(mouseOffset.X , mouseOffset.Y);
				Location = mousePos;
			}
		}
	}
}
