using System;
using System.Collections.Generic;


namespace Listas
{
    public class ListaEstudiante
    {
        private List<Estudiante> x = new List<Estudiante>();
        public List<Estudiante> X { get { return x; } set { x = value; } }

        public ListaEstudiante() { X = new List<Estudiante>(); }


        public void Agregar(Estudiante j) {  
            x.Add(j);
            Console.WriteLine("Estudiante agregado exitosamente");
        }

        public void Registrar()
        {
            String n, c; Single n1, n2, n3;

            do {
                Console.Write("Escriba el nombre del estudiante: ");
                n = Console.ReadLine();
                if (n.Trim().Length == 0) Console.WriteLine("El nombre es obligatorio");
            }while(n.Trim().Length == 0);

            do {
                Console.Write("Escriba la cedula del estudiante: ");
                c = Console.ReadLine();
                if (c.Trim().Length == 0) Console.WriteLine("La cedula es obligatoria");
            }while (c.Trim().Length == 0);

            do {
                Console.Write("Escriba la primera nota del estudiante: ");
                n1 = Convert.ToSingle(Console.ReadLine());
                if (n1 < 0.0 || n1 > 100.0) Console.WriteLine("La nota no puede ser menor a cero ni mayor a 100");
            }while (n1 < 0.0 || n1 > 100.0);

            do {
                Console.Write("Escriba la segunda nota del estudiante: ");
                n2 = Convert.ToSingle(Console.ReadLine());
                if (n2 < 0 || n2 > 100) Console.WriteLine("La nota no puede ser menor a cero ni mayor a 100");
            }while (n2 < 0 || n2 > 100);

            do {
                Console.Write("Escriba la tercera nota del estudiante: ");
                n3 = Convert.ToSingle(Console.ReadLine());
                if (n3 < 0 || n3 > 100) Console.WriteLine("La nota no puede ser menor a cero ni mayor a 100");
            }while (n3 < 0 || n3 > 100);

            Estudiante y = new Estudiante(n, c, n1, n2, n3);
            Agregar(y);
        }

        public Single PromedioPar()
        {
            Int32 contador = 0; Single promedio, acumulador = 0, i = 0;

            foreach (Estudiante j in X)
            {
                if (i % 2 == 0 || i == 0)
                {
                    acumulador += j.N1;
                    acumulador += j.N2;
                    acumulador += j.N3;
                    contador += 3;
                    i++;
                }
            }
            promedio = acumulador / contador;
            return promedio;
        }

        public Single NotasReprobadas()
        {
            Single porcentaje, contador = 0, contador_reprobado = 0;

            foreach (Estudiante j in X)
            {
                if (j.N1 < 50)
                {
                    Console.WriteLine("Nota reprobada: " + j.N1);
                    contador_reprobado+= 1;
                }
                if (j.N2 < 50)
                {
                    Console.WriteLine("Nota reprobada: " + j.N2);
                    contador_reprobado+= 1;
                }
                if(j.N3 < 50)
                {
                    Console.WriteLine("Nota reprobada: " + j.N3);
                    contador_reprobado += 1;
                }
                contador += 3;
            }
            porcentaje = (contador_reprobado / contador) * 100;
            return porcentaje;
        }

        public void ModificarNota()
        {
            String cedulaABuscar;
            Single n1, n2, n3;
            // ID a buscar
            Console.Write("Escriba la cedula del estudiante al cual va a cambiar las notas: ");
            cedulaABuscar = Console.ReadLine();

            // Encontrar el índice del elemento con el ID especificado
            int index = X.FindIndex(p => p.Cedula == cedulaABuscar);

            if (index != -1)
            {
                // Modificar el elemento
                Console.Write("Escriba la primera nota modificada: ");
                n1 = Convert.ToSingle(Console.ReadLine());

                Console.Write("Escriba la segunda nota modificada: ");
                n2 = Convert.ToSingle(Console.ReadLine());

                Console.Write("Escriba la tercera nota modificada: ");
                n3 = Convert.ToSingle(Console.ReadLine());

                X[index].N1 = n1;
                X[index].N2 = n2;
                X[index].N3 = n3;
                Console.WriteLine($"Elemento modificado");
            }
            else
            {
                Console.WriteLine("Elemento no encontrado");
            }
        }

        public void EliminarAlumno()
        {
            String cedulaABuscar;
            // ID a buscar
            Console.Write("Escriba la cedula del estudiante al cual va a cambiar las notas: ");
            cedulaABuscar = Console.ReadLine();

            // Encontrar el índice del elemento con el ID especificado
            int index = X.FindIndex(p => p.Cedula == cedulaABuscar);

            if (index != -1)
            {
                // Modificar el elemento
                x.RemoveAt(index);
                Console.WriteLine($"Elemento eliminado");
            }
            else
            {
                Console.WriteLine("Elemento no encontrado");
            }
        }

        public void Mostrar()
        {
            foreach (Estudiante j in X)
            {
                Console.WriteLine($"Nombre: {j.Nombre} - Cedula: {j.Cedula} - Nota 1: {j.N1} - Nota 2: {j.N2}" +
                    $" - Nota 3: {j.N3}");
            }
        }

    }
}
