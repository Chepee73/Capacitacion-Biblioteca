using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsBiblioteca
{
    public partial class Form1 : Form
    {
        List<Entidades.Autor> autores = new List<Entidades.Autor>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Entidades.Autor autor = new Entidades.Autor(
                Convert.ToInt32(txtCodigo.Text), cboNacionalidad.SelectedItem.ToString(), txtNombre.Text, txtApellido.Text);
            autor.FechaNacimiento = dtpFNacimiento.Value;

            Logica.Autor.Agregar(autores, autor);

            MessageBox.Show("Autor Agregado");
            
        }
    }
}
