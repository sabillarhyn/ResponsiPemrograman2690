using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsiPemrograman2690
{
	class karyawan
	{
		public string No { get; set; }
		public string Nama { get; set; }
		public int Nik { get; set; }
		public int GajiBulanan { get; set; }

		public void DataGaji()
		{
			Console.WriteLine("{0}   {1} {2}		{3}", No, Nik, Nama, GajiBulanan);
		}
		
		public void NaikGaji()
		{
			Console.WriteLine("{0}   {1} {2}		{3}", No, Nik, Nama, GajiBulanan+(GajiBulanan*0.1));
		}
	}
}
