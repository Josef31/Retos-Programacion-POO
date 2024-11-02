/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 30/10/2024
 * Hora: 10:28 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio1
{
	/// <summary>
	/// Description of Libro.
	/// </summary>
	public class Libro
	{
		//Atributos
		
		private String titulo, autor;
		private Int32 numero_de_paginas, pagina_activa;
		
		//Propiedades
		
		public String Titulo {get{return titulo;} set{titulo=value;}}
		public String Autor {get{return autor;} set{autor=value;}}
		public Int32 Numero_de_Paginas {get{return numero_de_paginas;} set{numero_de_paginas=value;}}
		public Int32 Pagina_Activa {get{return pagina_activa;} set{pagina_activa=value;}}
		
		public Libro() //Constructor
		{
		}
		
		//Metodos
		
		public void Leer() {
			Console.WriteLine("Estas leyendo la pagina: {0}", Pagina_Activa);
		}
		
		public void Info() {
			Console.WriteLine("Libro= {0} {1} {2}", Titulo, Autor, Numero_de_Paginas);
		}
	}
}
