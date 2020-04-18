using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Example
{
    public class Instrumento
    {
        private string name;


        public Instrumento(string name)
        {
            this.Name = name;
        }


        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (!(value is String))
                {
                    Console.WriteLine("Estas mal");
                }
                this.name = value;
            }
        }

        public string getName()
        {
            return name;
        }

        private void setName(string name)
        {
            this.name = name;
        }

        public void Sound()
        {
            Console.WriteLine("Estoy emitiendo el sonido que me corresponde..");

        }
    }
}
