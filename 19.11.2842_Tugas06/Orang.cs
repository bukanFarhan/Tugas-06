using System;
using System.Collections.Generic;
using System.Text;

namespace _19._11._2842_Tugas06
{
   internal class Orang
    {
		// Field public
		public string Nama;

		// Field private
		private int Umur;

		// Field protected
		protected string Alamat;

		// Construktor
		public Orang(string nama, int umur, string alamat)
		{
			this.Nama = nama;
			this.Umur = umur;
			this.Alamat = alamat;
		}

		// Method 
		public void TampilanInfo()
		{

			Console.WriteLine("=== Informasi Human ===\n");
			Console.WriteLine("Nama   : {0}", this.Nama);
			Console.WriteLine("Umur   : {0}", this.Umur);
			Console.WriteLine("Alamat : {0}", this.Alamat);
			Console.WriteLine("=====================================");
		}

		public void UpdateInfo()
		{
			Console.WriteLine("\n=== Update Informasi Human ===\n");
			Console.WriteLine("Update Nama   : {0}", this.Nama);
			Console.WriteLine("Update Umur   : {0}", this.Umur);
			Console.WriteLine("Update Alamat : {0}", this.Alamat);
			Console.WriteLine("===========================================");
		}
	}
}
