using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas29
{
    public class Sistema
    {
        public void MenuPrincipal()
        {
            Validador.Bienvenida();
            Console.WriteLine("\n Recuerde seguir las instrucciones. Presione cualquier tecla para continuar");
            Console.ReadKey();
            DateTime fecha = Validador.ValidarFechaIngresada("\n Ingrese una Fecha");

            DateTime fechaDos = new DateTime(fecha.Year, fecha.Month - 1, 1);

            Console.Clear();
            Console.WriteLine("\n La fecha ingresada es: " + fecha.ToLongDateString());
            Console.WriteLine("\n El primer dia y mes anterior de la fecha ingresada es: " + fechaDos.ToLongDateString());

            Validador.Despedida();
        }

        public void Iniciar()
        {
            MenuPrincipal();
        }
    }
}
