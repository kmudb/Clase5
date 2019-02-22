using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_de_clase
{
   public class Automovil
    {
        //Declaracion de propiedades
        public string Fabricante { get; set; }
        public string modelo { get; set; }
        public string color { get; set; }
        //constructor
        public Automovil()
        {
            this.Fabricante = "Toyota";
            this.color = "Azul";
            this.modelo = "Corolla";

        }
        //Declaración de metodos
        public string avanzar()
        {
            return "Estoy avanzando";
        }
        public string retroceder()
        {
            return "Estoy retrocediente";
        }
        public string girar()
        {
            return "Estoy girando";
        }
    }
}
