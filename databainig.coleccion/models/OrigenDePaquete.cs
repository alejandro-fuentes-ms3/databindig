using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databainig.coleccion.models
{
    public class OrigenDePaquete
    {
        public string nombre {  get; set; } = string .Empty;
        public string origen { get; set; } = string.Empty;
        public bool EstaHabilitado { get; set; } = false;
        public override string ToString()
        {
            return $" ({nombre}) = ({origen}) ";
        }
        
    }
}
