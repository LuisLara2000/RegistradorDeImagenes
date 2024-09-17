using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registradorDePersonajes.BLL
{
    public class personajeBLL
    {   
        public string nombre {  get; set; }
        public int vida { get; set; }
        public int ataque { get; set; }
        public int defensa { get; set; }
        public byte[] imagen { get; set; }
    }
}
