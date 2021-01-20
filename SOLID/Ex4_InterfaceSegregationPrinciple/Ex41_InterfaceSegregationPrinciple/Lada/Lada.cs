using System;
using System.Collections.Generic;
using System.Text;

namespace Ex41_InterfaceSegregationPrinciple.Lada
{

    public abstract class Lada : Car
    {
        public Lada(string model, string brand)
                : base(model, brand) { }
    }
}