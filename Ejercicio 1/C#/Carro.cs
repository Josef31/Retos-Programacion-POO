/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 30/10/2024
 * Hora: 10:02 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio1
{
	/// <summary>
	/// Description of Carro.
	/// </summary>
	public class Carro
	{
		//Atributos
		
		private String marca, modelo;
		private Int16 año;
		
		//Propiedades
		
		public String Marca { get{return marca;} set{marca=value;}}
		public String Modelo { get{return modelo;} set{modelo=value;}}
		public Int16 Año { get{return año;} set{año=value;}}
		
		public Carro() //Constructor
		{
			Marca="Desconocido"; Modelo="Desconocido"; Año=0000;
		}
		
		//Metodos
		
		public String Arrancar(){
			String acelerar = "Arrancando...";
			return acelerar;
		}
		
		public void Detener(){
			Console.WriteLine("Deteniendo...");
		}
	}
}
