using System;

namespace Exercise10
{
    class Fox
    {
        Random rnd = new Random();
        private string name;
        private string type;
        private string color;

        public Fox(string name, string type, string color)
        {
            this.Name = name;
            this.Color = color;
            this.Type = type;
        }

        public string Type { get => type; set => type = value; }
        public string Color { get => color; set => color = value; }
        public string Name { get => name; set => name = value; }
    }
}
