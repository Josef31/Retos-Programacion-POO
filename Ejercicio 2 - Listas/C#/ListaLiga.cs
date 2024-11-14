using System;
using System.Collections.Generic;

namespace Listas
{
    public class ListaLiga
    {
        private List<Liga> ligas = new List<Liga>();
        public List<Liga> Ligas { get { return ligas; } set { ligas = value; } }

        public ListaLiga() { Ligas = new List<Liga>(); }

        public void Agregar(Liga j)
        {
            Ligas.Add(j);
        }

        public void Registrar()
        {
            String el, ev;
            Int16 gl, gv;

            do
            {
                Console.Write("Escriba el nombre del equipo local: ");
                el = Console.ReadLine();
                if (el.Trim().Length == 0)
                {
                    Console.WriteLine("Este campo no puede estar vacio");
                }
            }
            while (el.Trim().Length == 0);

            do
            {
                Console.Write("Escriba el nombre del equipo visitante: ");
                ev = Console.ReadLine();
                if (ev.Trim().Length == 0 || ev == el)
                {
                    Console.WriteLine("Este campo es obligatorio y el equipo visitante no se puede llamar igual " +
                        "al equipo local");
                }
            }
            while (ev.Trim().Length == 0 || ev == el);

            do
            {
                Console.Write("Escriba la cantidad de goles del equipo local: ");
                gl = Convert.ToInt16(Console.ReadLine());
                if (gl < 0)
                {
                    Console.WriteLine("No pueden haber goles negativos");
                }
            }
            while (gl < 0);

            do
            {
                Console.Write("Escriba la cantidad de goles del equipo visitante: ");
                gv = Convert.ToInt16(Console.ReadLine());
                if (gv < 0)
                {
                    Console.WriteLine("Los goles no pueden ser negativos");
                }
            }
            while (gv < 0);

            Liga x = new Liga(el, ev, gl, gv);
            Agregar(x);
        }


        public void JuegosEmpatados()
        {
            bool empate = false;
            foreach (Liga f in ligas)
            {
                if (f.Goles_Local == f.Goles_Visitante)
                {
                    Console.WriteLine("El partido termino en empate con una cantidad de goles de: {0} y {1}",
                        f.Goles_Local, f.Goles_Visitante);
                    empate = true;
                }


            }
            if (!empate)
            {
                Console.WriteLine("No hubieron partidos empatados");
            }
        }


        public Int16 Paliza()
        {
            Int16 contador = 0, diferencia, gl = 0, gv = 0;
            bool paliza = false;
            const Int16 resta = 3;

            foreach (Liga f in ligas)
            {
                if (f.Goles_Local > f.Goles_Visitante)
                {
                    gl = f.Goles_Local;
                    diferencia = Convert.ToInt16(gl - resta);
                    if (diferencia > 0)
                    {
                        contador += 1;
                        paliza = true;
                    }

                }
                else if (f.Goles_Visitante > f.Goles_Local)
                {
                    gv = f.Goles_Visitante;
                    diferencia = Convert.ToInt16(gv - resta);
                    if (diferencia > 0)
                    {
                        contador += 1;
                        paliza = true;
                    }
                }


            }

            if (!paliza) {
                Console.WriteLine("No hubieron partidos con diferencia de goles mayor a 3");
            }

            return contador;

        }




        public Single PromedioGoles()
        {
            Single promedio;
            Int16 contador_partidos = 0, acumulador_goles = 0;

            foreach (Liga j in ligas)
            {
                contador_partidos += 1;
                acumulador_goles += j.Goles_Local;
                acumulador_goles += j.Goles_Visitante;
            }

            promedio = acumulador_goles / contador_partidos;
            return promedio;
        }



    }
}