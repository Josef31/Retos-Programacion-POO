using System;

namespace Listas
{

	public class Estudiante
	{
        private String nombre, cedula;
        private Single n1, n2, n3;

        public String Nombre { get { return nombre; } set { nombre = value; } }
        public String Cedula { get { return cedula; } set { cedula = value; } }
        public Single N1 { get { return n1; } set { n1 = value; } }
        public Single N2 { get { return n2; } set { n2 = value; } }
        public Single N3 { get { return n3; } set { n3 = value; } }

        public Estudiante(String n, String c, Single n1, Single n2, Single n3){
            Nombre = n; Cedula = c; N1 = n1; N2 = n2; N3 = n3;
        }


        public override String ToString()
        {
            return String.Format("Estudiante: {0}, {1}, {2}, {3}, {4}", Nombre, Cedula, N1, N2, N3);
        }

    }
}
