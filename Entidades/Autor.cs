using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Autor
    {
        // Constructor
        public Autor()
        {
            this.codigo = 1;
            this.Nacionalidad = "Argentina";
            this.Nombre = "Jorge Luis";
            this.Apellido = "Borges";
            this.FechaNacimiento = new DateTime(1899, 8, 24);
        }

        public Autor(int codigo, string nacionalidad = "Argentina", string nombre = "Jorge Luis", string apellido = "Borges", string fechaNacimiento = "1899/08/24")
        {
            this.codigo = codigo;
            this.Nacionalidad = nacionalidad;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNacimiento = DateTime.Parse(fechaNacimiento);
        }
        // Private variables
        private int codigo;
        private string apellido;
        private string nombre;
        private DateTime fechaNacimiento;
        private string nacionalidad;


        // Properties
        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Nacionalidad
        {
            get
            {
                return nacionalidad;
            }

            set
            {
                nacionalidad = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }

            set
            {
                fechaNacimiento = value;
            }
        }
    }
}
