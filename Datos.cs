using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyA2
{
     class Datos
    {
        //Declarar listas para ocupar en el combobox
        private List<string> ListaFacul = new List<string>();
        private List<string> Listasexo = new List<string>();
        public Datos()
        {
            ListaFacul.Add("FEC");
            ListaFacul.Add("FARQ");
            ListaFacul.Add("FIQ");
            ListaFacul.Add("FCM");
            Listasexo.Add("Masculino");
            Listasexo.Add("Femenino");
            Listasexo.Add("No binario");
        }
    }
}
