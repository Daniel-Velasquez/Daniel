using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Registry.Classes
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }
        public string Capacity { get; set; }

        public void saveToFile()
        {
            System.IO.File.AppendAllText(@"Registered Cars.txt", getResult().Replace("\n", Environment.NewLine));
        }

        public string getResult()
        {
            return ("\n--------------------------------------------------------------------------------------" +
                "\n\t\tYOU REGISTERED THIS CAR" + "\n\nCar Name: " + Make + "\nCar Model: " + Model + "\nCar Year: " + Year
               + "\nCar Color: " + Color + "\nCar Capacity: " + Capacity);
        }
    }
}
