using System;

namespace Practica4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string archivo1, archivo2;
			//Console.WriteLine ("Hello World!");
			Console.WriteLine ("dame el nombre del primer achivo de txt");
			archivo1 = Console.ReadLine();
			Console.WriteLine ("dame el nombre del segundo achivo de txt");
			archivo2 = Console.ReadLine();

			Programa programa = new Programa();
			programa.archivo1();
			programa.archivo2();

		}
	}
}
