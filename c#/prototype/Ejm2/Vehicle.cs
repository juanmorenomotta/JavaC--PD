using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype.Ejm2
{
    public class Vehicle:Prototype
    {
        private string name;
        private string features;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Features
        {
            get { return features; }
            set { features = value; }
        }
        /// <summary>
        /// Retorna una copia superficial (shallow copy)
        /// </summary>
        /// <returns>Copia del objeto</returns>
        public override Prototype Clone()
        {
            //El método MemberwiseClone crea una copia superficial
            return (Prototype)this.MemberwiseClone();
        }
        public override string ToString()
        {
            return "Name: " + name + " Features: " +  features;
        }
    }
}
