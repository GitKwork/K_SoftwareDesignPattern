using System;

namespace NullObject.Products
{
    class Cake : Product
    {
        public Cake()
            : base(energy: 1826, "Три шоколада")
        { }

        public override void Eat() => Console.WriteLine("Это настоящий праздник для любителей сладкого!");
    }
}
