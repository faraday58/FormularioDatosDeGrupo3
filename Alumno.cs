using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioDatosDeGrupo3
{
    class Alumno
    {
        private string nombre;
        private string numeroCuenta;
        private string materia;

        public string Nombre { get => nombre;
            set
            {
                if( value == ""  )
                {
                    nombre = " Juan Carlos Bodoque ";
                }
                else
                {
                    nombre = value;
                }
                
            }
        }
        public string NumeroCuenta {
            get => numeroCuenta;
            set
            {
                if( value == ""  )
                {

                }
                numeroCuenta = value;
            }
        }
        public string Materia { get => materia; set => materia = value; }




        private string GenerarNumeroCuenta()
        {
            Random aleatorio = new Random();
            string numeroCuenta = "";
            for(int i=0; i < 9; i++ )
            {                
                numeroCuenta += aleatorio.Next(9);
            }
            return numeroCuenta;

        }


    }
}
