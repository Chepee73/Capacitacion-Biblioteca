using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class Autor
    {
        // Methods

        // TODO improve this calculation
        public static int CalcularEdad(Entidades.Autor autor)
        {
            int edad = 0;

            edad = DateTime.Today.Year - autor.FechaNacimiento.Year;
            return edad;
        }


        /// <summary>
        /// Description: Adds an autor to a generic list
        /// Author: C.H.A.F
        /// Date: 13/07/2016
        /// </summary>
        /// <param name="autores">Generic list of autor"</param>
        /// <param name="autor">Autor to add to the list</param>
        public static void Agregar(List<Entidades.Autor> autores, Entidades.Autor autor)
        {
            autores.Add(autor);
        }
    }
}
