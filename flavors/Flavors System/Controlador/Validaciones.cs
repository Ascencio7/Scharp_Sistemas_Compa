using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flavors_System.Controlador
{
    internal class Validaciones
    {
        public static int BuscarIDCombo(string nombreID, string nombreColumna, DataTable data, string evaluar)
        {
            int idEncontrado = -1; // Valor por defecto si no se encuentra el nombre

            // Recorrer las filas del DataTable
            foreach (DataRow row in data.Rows)
            {
                string color = row[nombreColumna].ToString();

                if (color == evaluar)
                {
                    idEncontrado = Convert.ToInt32(row[nombreID]);
                    break; // Se encontró el color, salir del bucle
                }
            }

            if (idEncontrado != -1)
            {
                return idEncontrado;
            }
            else
            {
                // El color no se encontró en el DataTable
                MessageBox.Show("El color no se encontró en el DataTable.");
                return idEncontrado;
            }
        }
    }
}
