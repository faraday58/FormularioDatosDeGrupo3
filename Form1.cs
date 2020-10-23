using System;
using System.Windows.Forms;

namespace FormularioDatosDeGrupo3
{
    public partial class Form1 : Form
    {
        Alumno[] alumnos;
        int indice;
        public Form1()
        {
            InitializeComponent();
            alumnos = new Alumno[3];

            //int [] miEntero= new int[5];  0 0 0 0 0  
        }

        public int Indice { 
            get => indice;
            set
            {
                if( value >= 3  )
                {
                    MessageBox.Show("Se llegó al límite de cupo");

                    indice = 0;
                }
                else
                {
                    indice = value;
                }
            } 
                
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtbNombreAlumno.Text;
            string numeroCuenta = txtbNumeroCuenta.Text;
            string materia = txtbMateria.Text;
            alumnos[Indice++] = new Alumno(nombre, numeroCuenta, materia);
            MessageBox.Show("Elemento Agregado");
            txtbNumeroCuenta.Clear();
            txtbNombreAlumno.Clear();
            txtbMateria.Clear();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                txtbNombreAlumno.Text = alumnos[Indice].Nombre;
                txtbNumeroCuenta.Text = alumnos[Indice].NumeroCuenta;
                txtbMateria.Text = alumnos[Indice].Materia;
                Indice++;
            }
            catch(NullReferenceException )
            {
                MessageBox.Show("No hay más alumnos, es necesario ingresarlos");
            }

        }
    }


}
