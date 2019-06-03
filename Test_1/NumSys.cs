using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combo_Programs
{
	//---- Перевод из одной системы счисления в другую
	public class Num_Sys
	{
		//---- Переменные ----------------------
		int _valueA, _valueB, _sysDigit;
		//---- Конструкторы --------------------
		/// <summary>
		/// Конструктор Кодировки чисел
		/// </summary>
		/// <param name="A"></param>
		/// <param name="B"></param>
		/// <param name="System_Digit">Система Счисления</param>
		public Num_Sys(int A,int B,int System_Digit)
		{
			_valueA = A;
			_valueB = B;
			_sysDigit = System_Digit;
		}
		/// <summary>
		/// Конструктор по умолчанию
		/// </summary>
		public Num_Sys()
		{ }

		//---- Свойства ------------------------
		int Value_A
		{
			get { return _valueA; }
			set { _valueA = value; }
		}
		int Value_B
		{
			get { return _valueB; }
			set { _valueB = value; }
		}
		int System_Digit
		{
			get { return _sysDigit; }
			set {
				if ( value >= 2 )
					_sysDigit = value;
				else _sysDigit = 2;
			}
		}

		//---- Методы --------------------------
		/// <summary>
		/// Вычисляет А и В, иначе возвращает 0
		/// </summary>
		/// <param name="A"></param>
		/// <param name="B"></param>
		/// <param name="OP"></param>
		/// <returns></returns>
		public int Calc_AB( int A , int B , string OP )
		{
			switch ( OP )
			{
				case "+":
					return A + B;

				case "-":
					return A - B;

				case "*":
					return A * B;

				case "/":
					if ( B > 0 )
						return A / B;
					else
						return 0;
			}
			return 0;
		}
		/// <summary>
		/// Возвращает букву исходя из числа
		/// </summary>
		/// <param name="tmp_Val"></param>
		/// <returns></returns>
		public string Return_Word( byte tmp_Val )
		{
			switch ( tmp_Val )
			{
				case 10:
					return "A";

				case 11:
					return "B";

				case 12:
					return "C";

				case 13:
					return "D";

				case 14:
					return "E";

				case 15:
					return "F";

				default:
					return tmp_Val.ToString();
			}
		}
		/// <summary>
		/// Возвращает число исходя из буквы
		/// </summary>
		/// <param name="tmp_Val"></param>
		/// <returns></returns>
		public int Return_Number( string tmp_Val )
		{
			switch ( tmp_Val )
			{
				case "A":
					return 10;

				case "B":
					return 11;

				case "C":
					return 12;

				case "D":
					return 13;

				case "E":
					return 14;

				case "F":
					return 15;

				default:
					return int.Parse(tmp_Val);
			}
		}
		/// <summary>
		/// Перевод из десятичной в любую другую
		/// </summary>
		/// <param name="Value">Число</param>
		/// <param name="Sys_Res">СС в которую нужно перевести</param>
		/// <returns></returns>
		public string Dec_to_Any( int Value , byte Sys_Res,bool sign = true )
		{
			byte tmp;
			string Result = "";
			if ( Sys_Res != 10 )
				while ( Value != 0 )
				{
					tmp = (byte)( Value % Sys_Res );

					if ( tmp >= 10 )
						Result += Return_Word(tmp);
					else
						Result += tmp;

					Value /= Sys_Res;
				}
			else
				return Value.ToString();

			char[] R = Result.ToCharArray();
			if(!sign)
				Array.Reverse(R);
			return new string(R);
		}
		/// <summary>
		/// Перевод из любой системы счисления в десятичную
		/// </summary>
		/// <param name="Val">Число</param>
		/// <param name="Sys_Code">СС этого числа</param>
		/// <returns></returns>
		public int Any_to_Dec( string Val , byte Sys_Code )
		{
			int tmp = 0, value;
			if ( Sys_Code != 10 )
			{
				for ( Byte i = 0 ; i < Val.Length ; i++ )
				{
					value = Return_Number(Val.Substring(Val.Length - i - 1 , 1));
					tmp += value * (int)Math.Pow(Sys_Code , i);
				}
				return tmp;
			}
			return ( int.Parse(Val) );
		}
	}
}
