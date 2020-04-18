using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class Vientos
    {
        private Instrumento inst;

        public Vientos(string name)
        {
            this.inst = new Instrumento(name);
        }
        public Vientos(Instrumento inst)
        {
            this.Inst = inst;
        }

        public Instrumento Inst
        {
            get
            {
                return this.inst;
            }
            private set
            {
                this.inst = value;
            }
        }


        public void play()
        {
            Console.WriteLine("Estoy tocando el instrumento: " + Inst.Name);
            Inst.Sound();
        }
    }
}
