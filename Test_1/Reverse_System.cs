using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combo_Programs
{
	class Revers_System
	{
		int a, b;
		Num_Sys SSytem = new Num_Sys();

		//---- Конструкторы ---------------------------
		public Revers_System() { }
		public Revers_System( int A , int B )
		{
			A = a;
			B = b;
		}
		//---- Свойства -------------------------------
		public int A
		{
			get { return a; }
			set { a = value; }
		}
		public int B
		{
			get { return b; }
			set { b = value; }
		}
		public bool P0
		{
			get { return _P0; }
		}
		//---- Методы ---------------------------------
		internal bool[] XOR(int Value,int Bit_Grid )
		{
			int key = (int)Math.Pow(2 , Bit_Grid) - 1;
			Value = key ^ Value;
			return Binary(Value , Bit_Grid);
		}
		internal bool[] Binary(int Value,int Bit_Grid)
		{
			bool[] _Result = new BitArray(new int[] { Value }).Cast<bool>().Reverse().ToArray();
			Array.Reverse(_Result);
			Array.Resize(ref _Result , Bit_Grid);
			Array.Reverse(_Result);
			return _Result;
		}
		internal string GetString(bool[] Value)
		{
			string str = "";
			foreach (bool f in Value)
				if ( f )
					str += "1";
				else
					str += "0";
			return str;
		}
		internal bool Is_Beyond(int Value, int Beyond)
		{
			return ( Math.Abs(Value) > Math.Pow(2 , Beyond) - 1 ) ? false : true;
		}
		internal bool[] OverFloat( bool[] _Result)
		{
			_P0 = false;
			bool[] tmp = new BitArray(_Result.Length , false).Cast<bool>().Reverse().ToArray();
			tmp[tmp.Length - 1] = true;
			return Plus(_Result , tmp);
		}
		internal bool[] Plus(bool[] _A, bool[] _B)
		{			
			bool[] _Result = new bool[_A.Length];
			for ( int i = _Result.Length - 1; i >= 0; i-- )
				_Result[i] = Summator(_A[i] , _B[i]);

			return _Result;
		}

		//--- Главный сумматор побитовых значений ---
		private bool _P0 = false;
		private	bool Summator( bool _A , bool _B)
		{
			bool _P = _A & _B | _A & _P0 | _B & _P0;
			bool Res = !_P  & (( _A | _B | _P0 ) | ( _A & _B & _P0 ));
			_P0 = _P;
			return Res;
		}
	}
}
