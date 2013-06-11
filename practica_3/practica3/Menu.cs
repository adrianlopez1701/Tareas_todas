using System;

namespace practica3
{
	public class Menu
	{
		public void muestraMenu(){
			Console.WriteLine("Menu");
			Console.WriteLine("1 capturar");
			Console.WriteLine("2 editar");
			Console.WriteLine("3 eliminar");
			Console.WriteLine("4 mostrar todos");
			Console.WriteLine("que opcion elige?");
		}
		public void leerEntrada ()
		{
			int opcion = int.Parse (Console.ReadLine ());
			switch (opcion) {
			case 1: 
				Console.WriteLine ("Capturar");
				Programa.capturar();
				Console.Clear();
				break;
			case 2:
				Console.WriteLine ("editar");
				Programa.editar();
				Console.Clear();
				break;
			case 3:
				Console.WriteLine ("eliminar");
				Programa.eliminar();
				Console.Clear();
				break;
			case 4:
				Console.WriteLine ("mostrar todos");
				Programa.imprimirTodos();
				Console.Clear();
				break;
			default:
				Console.WriteLine ("error");
				break;
			}
		}
		public static void Main (string[] args)
		{
			Menu programa = new Menu();
			programa.muestraMenu();
			programa.leerEntrada();
		}
	}
}

