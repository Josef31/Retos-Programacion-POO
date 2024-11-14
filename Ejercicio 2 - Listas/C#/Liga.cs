using System;

namespace Listas
{
    public class Liga
    {

        private String equipo_local, equipo_visitante;
        private Int16 goles_local, goles_visitante;

        public String Equipo_Local { get { return equipo_local; } set { equipo_local = value; } }
        public String Equipo_Visitante { get { return equipo_visitante; } set { equipo_visitante = value; } }
        public Int16 Goles_Local { get {return goles_local; } set { goles_local = value; } }
        public Int16 Goles_Visitante { get {return goles_visitante; } set { goles_visitante = value; } }

        public Liga(String el, String ev, Int16 gl, Int16 gv) { 
            Equipo_Local = el; Equipo_Visitante = ev; Goles_Local = gl; Goles_Visitante = gv;
        }

    }
}
