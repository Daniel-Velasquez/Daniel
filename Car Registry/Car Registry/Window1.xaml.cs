using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Car_Registry
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

   

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Car myNewCar = new Car();

            myNewCar.Make = Make.Text;
            myNewCar.Make = Model.Text;
            myNewCar.Make = Year.Text;
            myNewCar.Make = Color.Text;
            myNewCar.Make = Capacity.Text;



            Result.Text = "\n--------------------------------------------------------------------------------------" + 
                "\n\t\tYOU REGISTERED THIS CAR" + "\n\nCar Name: " + Make.Text + "\nCar Model: " + Model.Text + "\nCar Year: " + Year.Text
               + "\nCar Color: " + Color.Text + "\nCar Capacity: " + Capacity.Text ;
        
         string carRegistry = Result.Text;
         System.IO.File.AppendAllText(@"C:\Users\Serbisyong Bayan\Desktop\Daniel Files\Car Registry\Registered Cars.txt", carRegistry.Replace("\n", Environment.NewLine));
        

            



        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
          
            
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }
        public string Capacity { get; set; }
    }

}
