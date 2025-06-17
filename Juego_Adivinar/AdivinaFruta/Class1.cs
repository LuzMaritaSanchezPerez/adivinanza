using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinaFruta
{
    public class JuegoFruta
    {
        private static Random rand = new Random();
        private string[] frutas = { "manzana", "platano", "naranja", "piña", "fresa" };
        private string[] pistas = 
        {
            "Es roja, dulce y crujiente.",
            "Es amarilla y tiene una cáscara fácil de pelar.",
            "Es redonda y su color es su nombre.",
            "Tiene una corona y es tropical.",
            "Es pequeña, roja y con semillas por fuera."
        };

        private static List<int> indicesDisponibles = new List<int>();
        private string frutaSecreta;
        private string pista;

        public JuegoFruta()
        {
            SeleccionarFrutaSinRepetir();
        }

        private void SeleccionarFrutaSinRepetir()
        {
            if (indicesDisponibles.Count == 0)
            {
                for (int i = 0; i < frutas.Length; i++)
                    indicesDisponibles.Add(i);
                for (int i = 0; i < indicesDisponibles.Count; i++)
                {
                    int j = rand.Next(indicesDisponibles.Count);
                    int temp = indicesDisponibles[i];
                    indicesDisponibles[i] = indicesDisponibles[j];
                    indicesDisponibles[j] = temp;
                }
            }

            int indice = indicesDisponibles[0];
            indicesDisponibles.RemoveAt(0);

            frutaSecreta = frutas[indice];
            pista = pistas[indice];
        }

        public string ObtenerPista()
        {
            return pista;
        }

        public bool Adivinar(string intento)
        {
            return intento.Trim().ToLower() == frutaSecreta;
        }

        public string ObtenerFruta()
        {
            return frutaSecreta;
        }
    }
}