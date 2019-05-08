using System;

namespace LearningCsharp
{
    class Cat : Animal
    {
        // private fields
        private string name;
        private string color;

        // public Name property
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // public Color property
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        // Default Constructor
        public Cat()
        {
            Name = "Misho";
            Color = "White";
        }

        // Constructor with parameters
        public Cat(string cat_name, string cat_color)
        {
            Name = cat_name;
            Color = cat_color;
        }

        // behaviour: say "miau"
        public void SayMiau()
        {
            Console.WriteLine("Cat {0} said Miaauu!", Name);
        }

        // activity
        public override string Activity()
        {
            return $"The Cat runs, and {base.Activity()}";
        }
    }
}
