using System;

namespace PropertiesInterface
{
    interface INamedValue
    {   // Interface Property
        string Name { get; set; }        

        string Value { get; set; }

        // Interface Property는 구현은 안됨
    }
    class NamedValue : INamedValue
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
    
    class MainApp
    {
        static void Main(string[] args)
        {
            NamedValue name = new NamedValue()
            {
                Name = "이름",
                Value = "kdw"
            };

            NamedValue height = new NamedValue()
            {
                Name = "키",
                Value = "177cm"
            };

            Console.WriteLine($"{name.Name}: {name.Value}");
            Console.WriteLine($"{height.Name}: {height.Value}");
        }
    }
}
