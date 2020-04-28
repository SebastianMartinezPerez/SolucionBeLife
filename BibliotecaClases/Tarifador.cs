using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClases;

namespace BibliotecaClases
{
    public class Tarifador
    {
        public  Cliente clienteTarifador { get; set; }
        public Tarifador()
        {

        }

        public double CalcularPrima() // Calcular recargo de la prima
        {
            double recargo = 0;
            int años = (DateTime.Now.Date.Year - clienteTarifador.FechaNacimiento.Date.Year);
            // Filtro de edad
            if (años >= 18 && años<= 25)
                recargo += 0.036;
            else if (años >= 26 && años <= 45)
                recargo += 0.024;
            else if (años > 45)
                recargo += 0.060;

            // Filtro de sexo
            if (clienteTarifador.sexo.Descripcion.Equals("Hombre"))
                recargo += 0.024;
            else if (clienteTarifador.sexo.Descripcion.Equals("Mujer"))
                recargo += 0.012;

            // Filtro de estado civil
            if (clienteTarifador.estadoCivil.Descripcion.Equals("Soltero"))
                recargo += 0.048;
            else if (clienteTarifador.estadoCivil.Descripcion.Equals("Casado"))
                recargo += 0.024;
            else
                recargo += 0.036;

            return recargo;
        }
    }
}
