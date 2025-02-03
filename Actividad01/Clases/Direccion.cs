using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad01.Clases
{
    public class Direccion
    {
        private string Provincia { get; set; }
        private string Canton { get; set; }
        private string Distrito { get; set; }
        private string OtrasSenas { get; set; }

        public Direccion(string provincia, string canton, string distrito, string otrasSenas)
        {
            this.Provincia  = provincia;
            this.Canton     = canton;
            this.Distrito   = distrito;
            this.OtrasSenas = otrasSenas;
        }
        public string MostrarDireccion()
        {
            return $"Provincia: {Provincia}, Cantón: {Canton}, Distrito: {Distrito}, Otras señas: {OtrasSenas}";
        }
    }
}
