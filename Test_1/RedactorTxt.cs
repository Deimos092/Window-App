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
	public partial class RedactorTxt : Form
	{
		public RedactorTxt()
		{
			InitializeComponent();
		}
		private int SS = 0;
		private string Scan = "Введите какой нибудь текст или откройте файл с расширением *.rtf";
		#region -----------------Кнопки (полужирный текст, курсив, подчеркнуть текст)-----------------
		private void полужирныйToolStripMenuItem_Click( object sender, EventArgs e )
		{
			Font oldFont, newFont;                                                           //объявление переменных oldFont и newFont
			oldFont = this.rtb.SelectionFont;                                                //Присваивание к переменной выделенный текст из Richtextbox
			if ( oldFont.Bold == true )                                                      //Создание условия (если)
				newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);                //Выполнения условия (если)
			else newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold);                //Выполнения условие (иначе)

			this.rtb.SelectionFont = newFont;                                                //Присваивание нового стиля к выделенному тексту
			this.rtb.Focus();                                                                //
		}

		private void курсивToolStripMenuItem_Click( object sender, EventArgs e )
		{
			Font oldFont, newFont;                                                           //объявление переменных oldFont и newFont

			oldFont = this.rtb.SelectionFont;                                                //Присваивание к переменной выделенный текст из Richtextbox
			if ( oldFont.Italic == true )                                                      //Создание условия (если)
				newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Italic);              //Выполнения условия (если)
			else newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);              //Выполнения условие (иначе)

			this.rtb.SelectionFont = newFont;                                                //Присваивание нового стиля к выделенному тексту
			this.rtb.Focus();
		}

		private void подчеркнутыйToolStripMenuItem_Click( object sender, EventArgs e )
		{
			Font oldFont, newFont;                                                           //объявление переменных oldFont и newFont

			oldFont = this.rtb.SelectionFont;                                                //Присваивание к переменной выделенный текст из Richtextbox
			if ( oldFont.Underline == true )                                                   //Создание условия (если)
				newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline);           //Создание условия (если)
			else newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);           //Выполнения условие (иначе)

			this.rtb.SelectionFont = newFont;                                                //Присваивание нового стиля к выделенному тексту
			this.rtb.Focus();
		}
		#endregion

		#region -----------------Кнопки (расположение текста)-----------------
		private void Leftbtn_Click( object sender, EventArgs e )
		{
			rtb.SelectionAlignment = HorizontalAlignment.Left;                               //Расположение текста Слева
		}

		private void Centrbtn_Click( object sender, EventArgs e )
		{
			rtb.SelectionAlignment = HorizontalAlignment.Center;                             //Расположение текста Поцентру
		}

		private void Rightbtn_Click( object sender, EventArgs e )
		{
			rtb.SelectionAlignment = HorizontalAlignment.Right;                             //Расположение текста Поцентру
		}

		#endregion

		#region-----------------Кнопки (Цвет текста и цвет фона текста)-----------------
		private void цветТекстаToolStripMenuItem_Click( object sender, EventArgs e )
		{
			ColorDialog MyDialog = new ColorDialog();                                        //Создание BackColorDialog;
			MyDialog.Color = rtb.ForeColor;                                                  //
			if ( MyDialog.ShowDialog() == DialogResult.OK )                                    //Проверка и открытие ColorDialog;
				rtb.SelectionColor = MyDialog.Color;                                         //Изменение выделенного цвета текста;
		}

		private void выделениеТекстаToolStripMenuItem_Click( object sender, EventArgs e )
		{
			ColorDialog mybackcolor = new ColorDialog();                                     //Создание BackColorDialog;
			mybackcolor.Color = rtb.ForeColor;                                               //
			if ( mybackcolor.ShowDialog() == DialogResult.OK )                                 //Проверка и открытие BackColorDialog;
				rtb.SelectionBackColor = mybackcolor.Color;                                  //Изменение фона выделенного текста
		}

		private void FontBtn_Click( object sender, EventArgs e )
		{
			try
			{
				if ( fontDialog1.ShowDialog() == DialogResult.OK )
					rtb.SelectionFont = fontDialog1.Font;
			}
			catch
			{
				MessageBox.Show("Ошибка");
			}
		}
		#endregion

		private void маркироватьToolStripMenuItem_Click( object sender, EventArgs e )
		{
			if ( rtb.SelectionBullet == true )                       //Создание условия (Если)
				rtb.SelectionBullet = false;                         //Маркировка выделенного текста
			else                                                     //Выполнение условия (Иначе)
				rtb.SelectionBullet = true;                          //Отмена маркировки текста
		}

		#region -----------------Кнопки (отступы)-----------------
		private void отступСлеваToolStripMenuItem_Click( object sender, EventArgs e )
		{
			if ( rtb.SelectionIndent == 0 )
				rtb.SelectionIndent = 25;                                                    //Отступ в пикселях слева                                   
			else
				rtb.SelectionIndent = 0;

		}

		private void отступСправаToolStripMenuItem_Click( object sender, EventArgs e )
		{
			if ( rtb.SelectionRightIndent == 0 )
				rtb.SelectionRightIndent = 25;                                                //Отступ в пикселях справа
			else
				rtb.SelectionRightIndent = 0;
		}
		#endregion

		#region -----------------Кнопки (Индексы)-----------------
		private void верхнийИндексToolStripMenuItem_Click( object sender, EventArgs e )
		{
			if ( rtb.SelectionCharOffset == 0 )                                                //Создание условия (Если)
			{
				rtb.SelectionCharOffset = 4;                                                 //Установка пикселей для верхнего индекса
				rtb.SelectionFont = new Font("Tahoma", 8);                                   //Установка шрифта по верхнему индексу
			}
			else                                                                             //Выполнение условия (Иначе)
			{
				rtb.SelectionCharOffset = 0;                                                 //Установка пикселей по стандарту
				rtb.SelectionFont = new Font("Tahoma", 10);                                  //Установка шрифта по стандарту
			}
		}

		private void нижнийИндексToolStripMenuItem_Click( object sender, EventArgs e )
		{
			if ( rtb.SelectionCharOffset == 0 )                                               //Создание условия (Если)
			{
				rtb.SelectionCharOffset = -4;                                               //Установка пикселей для верхнего индекса
				rtb.SelectionFont = new Font("Tahoma", 8);                                  //Установка шрифта по верхнему индексу
			}
			else                                                                            //Выполнение условия (Иначе)
			{
				rtb.SelectionCharOffset = 0;                                                //Установка пикселей по стандарту
				rtb.SelectionFont = new Font("Tahoma", 10);                                 //Установка шрифта по стандарту
			}
		}
		#endregion

		private void очиститьToolStripMenuItem_Click( object sender, EventArgs e )
		{
			rtb.Clear();
		}

		private void InfoHelptoolStripButton_Click( object sender, EventArgs e )
		{
			Form InfoTxT = new InfoTxT();
			InfoTxT.Show();
		}

		#region-----------------Кнопки (Открыть Сохранить)-----------------
		private void Open_btn_Click( object sender, EventArgs e )
		{
			openFileDialog1.Filter = "rtf файлы (*.rtf)|*.rtf";      //Устанавливаем фильтр на открытие файлов  с расширением rtf и txt;
			if ( openFileDialog1.ShowDialog() == DialogResult.OK )                           //Проверка и открытие приложение OpenfileDialog;
			{
				System.IO.StreamReader streamReader;                                       //Объявление StreamReader;
				streamReader = new System.IO.StreamReader(openFileDialog1.FileName, System.Text.Encoding.GetEncoding("Windows-1251"));      //открытие потока StreamReader и считывание файла при помоши кодировки Windows-1251;
				rtb.Rtf = streamReader.ReadToEnd();                                        //Остановка записи информации из файла в RichtextBox;
				streamReader.Close();                                                      //Закрытие потока;
			}
		}

		private void Save_btn_Click( object sender, EventArgs e )
		{
			saveFileDialog1.Filter = "rtf файлы (*.rtf)|*.rtf";       //Устанавливаем фильтр на открытие файлов с расширением rtf и txt;    
			if ( saveFileDialog1.ShowDialog() == DialogResult.OK )                             //Проверка и открытие приложение SavefileDialog;
			{
				System.IO.StreamWriter streamwriter;                                         //Объявление StreamWriter;
				streamwriter = new System.IO.StreamWriter(saveFileDialog1.FileName, false, System.Text.Encoding.GetEncoding("windows-1251"));  //открытие потока StreamRWriter поиск полного пути к файлу и применение кодировки Windows-1251;
				streamwriter.Write(this.rtb.Rtf);                                            //Сохранение информации из RichtextBox в открытый файл;
				streamwriter.Close();                                                        //Закрытие потока;
				rtb.Clear();                                                                 //Очистка RichtextBoxа;   
			}
		}
		#endregion

		#region -----------------Кнопка (найти)-----------------
		private void btnSearch_Click( object sender, EventArgs e )
		{
			if ( TbSearch.Text != "Найти слово" && TbSearch.TextLength > 1 )
			{
				SS = rtb.Text.IndexOf(TbSearch.Text , SS);
				rtb.Focus();
				if ( SS < rtb.TextLength & SS != -1 )
				{
					rtb.SelectionStart = SS;
					rtb.SelectionLength = TbSearch.Text.Length;
					SS += 1;
				}
				else
					SS = 0;
			}
		}
		#endregion

		#region -----------------Путь до файла -----------------
		private void rtb_TextChanged( object sender, EventArgs e )
		{
			Status_Strip_lb.Text = openFileDialog1.FileName;
		}
		#endregion

		private void TbSearch_Enter( object sender , EventArgs e )
		{
			TbSearch.Text = "";
		}

		private void TbSearch_Leave( object sender , EventArgs e )
		{
			if ( TbSearch.TextLength <= 1 )
				TbSearch.Text = "Найти слово";
		}

		private void rtb_Enter( object sender , EventArgs e )
		{
			if(rtb.TextLength < 3 | rtb.Text == Scan)
			rtb.Text = "";
		}

		private void rtb_Leave( object sender , EventArgs e )
		{
			if ( rtb.TextLength < 3 | rtb.Text == "" )
				rtb.Text = Scan;
		}
	}

}
