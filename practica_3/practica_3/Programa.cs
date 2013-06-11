using System;
using System.Collections;

namespace practica_3
{
	public class Programa
	{		
		private Hashtable Base;
		
		public Programa(){
			this.Base = new Hashtable();
		}
		
		public void capturar(){
			for(int i = 1; i<5 ;i++){
				Console.Clear();
				this.Datos(new Persona());
			}
		}
		
		private void Datos(Persona persona){
			this.Registro(persona);
			this.Agregar(persona);
			
		}
		
		private void Registro(Persona persona){
			Console.WriteLine("CAPTURA LOS DATOS DE LA PERSONA");
			if(persona.codigo == ""){
				Console.WriteLine("Dame el código");
				persona.codigo = Console.ReadLine();
			}
			
			Console.WriteLine("Dame el nombre");
			persona.nombre = Console.ReadLine();
			Console.WriteLine("Dame la dirección");
			persona.direccion = Console.ReadLine();
			Console.WriteLine("Dame el teléfono");
			persona.telefono = Console.ReadLine();
			Console.WriteLine("Dame el facebook");
			persona.facebook = Console.ReadLine();
		}
		
		private void Agregar(Persona persona){			
			if(this.Base.ContainsKey(persona.codigo)){
				this.Base.Remove(persona.codigo);
			}
			
			this.Base.Add(persona.codigo,persona);
		}
		
		public void editar(){
			for(int i = 0; i < 2; i++){
				Console.Clear();
				string codigo = "";
				Console.WriteLine("Dame el código para editar");
				codigo = Console.ReadLine();
				if(this.Base.ContainsKey(codigo)){
					Persona persona = (Persona)this.Base[codigo];
					this.imprimePersona(persona);
					this.Datos(persona);
				}else{
					this.imprimeError();
				}
			}
		}
		
		public void eliminar(){
			for(int i = 0; i < 2; i++){
				Console.Clear();
				string codigo = "";
				Console.WriteLine("Dame el código para eliminar");
				codigo = Console.ReadLine();
				if(this.Base.ContainsKey(codigo)){
					Persona persona = (Persona) this.Base[codigo];
					this.imprimePersona(persona);
					this.confirmarEliminacionYEliminar(persona.codigo);
				}else{
					this.imprimeError();
				}
			}
		}
		
		private void confirmarEliminacionYEliminar(string codigo){
			Console.WriteLine("¿Esta seguro que desea eliminar?");
			Console.WriteLine("0 = No, 1 = Si");
			string opcion = Console.ReadLine();
			if(opcion != "0"){
				this.Base.Remove(codigo);
			}
		}
		
		private void imprimeError(){
			Console.WriteLine("No existe el código.");
			Console.WriteLine("Presione cualquier tecla para continuar.");
			Console.ReadLine();
		}
		
		public void imprimirTodos(){
			ICollection personas = this.Base.Values;
			
			Console.WriteLine();
			foreach( object objeto in personas )
			{
				Persona persona = (Persona) objeto;
				this.imprimePersona(persona);
			}
		}
		
		private void imprimePersona(Persona persona){
			Console.WriteLine("Código: " + persona.codigo);
			Console.WriteLine("Nombre: " + persona.nombre);
			Console.WriteLine("Dirección: " + persona.direccion);
			Console.WriteLine("Teléfono: " + persona.telefono);
			Console.WriteLine("Facebook: " + persona.facebook);
			Console.WriteLine("");
		}
		
	}
}
