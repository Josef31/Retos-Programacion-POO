/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 30/10/2024
 * Hora: 10:54 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio1
{
	/// <summary>
	/// Description of Empleado.
	/// </summary>
	public class Empleado
	{
		//Atributos
		
		private String nombre;
		private Int16 edad;
		private Double salario_diario;
		
		//Propiedades
		
		public String Nombre {get{return nombre;} set{nombre=value;}}
		public Int16 Edad {get{return edad;} set{edad=value;}}
		public Double Salario_Diario {get{return salario_diario;} set{salario_diario=value;}}
		
		public Empleado()
		{
		}
		
		//Metodos
		
		public Double Salario_Mensual(){
			Double salario_mensual = salario_diario*30;
			return salario_mensual;
		}
		
		public void Info(){
			Console.WriteLine("Informacion= {0} {1} {2}$", Nombre, Edad, Salario_Diario);
		}
		
	}
}
