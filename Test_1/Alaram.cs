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
	public partial class Alaram : Form
	{
		private Point mouseOffset;
		private bool isMouseDown = false;
		// функция PlaySound, обеспечивающая воспроизведение
		// wav-файлов, находится в библиотеке winmm.dll
		// подключим эту библиотеку
		[System.Runtime.InteropServices.DllImport("winmm.dll")]
		private static extern
		  Boolean PlaySound( string lpszName , int hModule , int dwFlags );

		// время сигнала (отображения сообщения)
		private DateTime alarm;

		public Alaram()
		{
			InitializeComponent();
			// параметры компонентов numericUpDown
			numericUpDown1.Maximum = 23;
			numericUpDown1.Minimum = 0;

			numericUpDown2.Maximum = 59;
			numericUpDown2.Minimum = 0;

			numericUpDown1.Value = DateTime.Now.Hour;
			numericUpDown2.Value = DateTime.Now.Minute;

			notifyIcon1.Visible = false;

			// период обработки сигнала от таймера
			timer1.Interval = 1000;
			timer1.Enabled = true;

			label2.Text = DateTime.Now.ToLongTimeString();
		}

		private void timer1_Tick( object sender , EventArgs e )
		{
			label2.Text = DateTime.Now.ToLongTimeString();

			// будильник установлен
			if ( checkBox1.Checked )
			{
				// время срабатывания будильника
				if ( DateTime.Compare(DateTime.Now , alarm) > 0 )
				{
					checkBox1.Checked = false;

					PlaySound(Application.StartupPath +
						 "\\ring.wav" , 0 , 1);

					Alert_info Alert = new Alert_info();
					Alert.lb_time .Text = DateTime.Now.ToShortTimeString();
					Alert.lb_message.Text = this.textBox1.Text;
					Alert.ShowDialog();

					this.Show();
				}
			}
		}

		private void checkBox1_CheckedChanged( object sender , EventArgs e )
		{
			if ( checkBox1.Checked )
			{
				numericUpDown1.Enabled = false;
				numericUpDown2.Enabled = false;

				// установить время сигнала
				alarm = new DateTime(
					DateTime.Now.Year ,
					DateTime.Now.Month ,
					DateTime.Now.Day ,
					Convert.ToInt16(numericUpDown1.Value) ,
					Convert.ToInt16(numericUpDown2.Value) ,
					0 , 0);

				// если установленное время будильника меньше
				// текущего, нужно увеличить дату срабатывания
				// на единицу (+1 день)
				if ( DateTime.Compare(DateTime.Now , alarm) > 0 )
					alarm = alarm.AddDays(1);

				notifyIcon1.Text = alarm.ToShortTimeString() + "\n" + textBox1.Text;

				btn_ok.Enabled = true;
			}
			else
			{
				numericUpDown1.Enabled = true;
				numericUpDown2.Enabled = true;

				notifyIcon1.Text =
					"Будильник не установлен";

				btn_ok.Enabled = false;
			}
		}

		private void btn_ok_Click( object sender , EventArgs e )
		{
			this.Hide();
			notifyIcon1.Visible = true;
		}

		private void показатьToolStripMenuItem_Click( object sender , EventArgs e )
		{
			if ( this.Visible )
				this.Hide();
			else
			{
				this.Show();
				notifyIcon1.Visible = false;
			}
		}

		private void завершитьToolStripMenuItem_Click( object sender , EventArgs e )
		{
			this.Close();
		}

		private void textBox1_Enter( object sender , EventArgs e )
		{
			textBox1.Text = "";
		}

		private void textBox1_Leave( object sender , EventArgs e )
		{
			if(textBox1.Text == "" || textBox1.TextLength < 1)
			textBox1.Text = "Ваше сообщение";
		}

		private void button1_Click( object sender , EventArgs e )
		{
			this.Close();
		}

		private void splitContainer1_Panel2_MouseMove( object sender , MouseEventArgs e )
		{

			if ( isMouseDown )
			{
				Point mousePos = Control.MousePosition;
				mousePos.Offset(mouseOffset.X , mouseOffset.Y);
				Location = mousePos;
			}
		}

		private void splitContainer1_Panel2_MouseUp( object sender , MouseEventArgs e )
		{
			if ( e.Button == MouseButtons.Left )
			{
				isMouseDown = false;
			}
		}

		private void splitContainer1_Panel2_MouseDown( object sender , MouseEventArgs e )
		{
			int xOffset;
			int yOffset;

			if ( e.Button == MouseButtons.Left )
			{
				xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
				yOffset = -e.Y - SystemInformation.CaptionHeight -
					SystemInformation.FrameBorderSize.Height - 60;
				mouseOffset = new Point(xOffset , yOffset);
				isMouseDown = true;
			}
		}
	}
}
