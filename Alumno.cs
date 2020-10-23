using System;

namespace FormularioDatosDeGrupo3
{
    class Alumno
    {
        #region Atributos
        private string nombre;
        private string numeroCuenta;
        private string materia;

        
        #endregion


        #region Propiedades
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
                    numeroCuenta=GenerarNumeroCuenta();
                }
                else
                {
                    numeroCuenta = value;
                }
                
            }
        }
        public string Materia {
            get => materia;
            set
            {
                if( value=="" )
                {
                    materia = "Técnicas de Programación";
                }
                else
                {
                    materia = value;
                }
                
            }
        }
        #endregion

        public Alumno(string nombre, string numeroCuenta, string materia)
        {
            Nombre = nombre;
            NumeroCuenta = numeroCuenta;
            Materia = materia;
        }

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
