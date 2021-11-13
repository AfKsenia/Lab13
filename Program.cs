using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {

            Building building = new Building("улица Кржижановского", 80, 30, 25);
            building.Print();
            Console.ReadKey();

            MultiBuilding multiBuilding = new MultiBuilding("улица Кржижановского", 80, 30, 25, 9);
            multiBuilding.Print();

            Console.ReadKey();
        }
    }
    class Building
    {
        public string address { get; set; }
        double lenght;
        public double Lenght
        {
            set
            {
                if (value > 0)
                {
                    value = lenght;
                }
                else
                {
                    Console.WriteLine("Длина не может быть отрицательной");
                }
            }
        }
        double hight;
        public double Height
        {
            set
            {
                if (value > 0)
                {
                    value = hight;
                }
                else
                {
                    Console.WriteLine("Высота не может быть отрицательной");
                }
            }
        }
        double width;
        public double Width
        {
            set
            {
                if (value > 0)
                {
                    value = width;
                }
                else
                {
                    Console.WriteLine("Ширина не может быть отрицательной");
                }
            }
        }
        public Building(string add, double len, double h, double w)
        {
            address = add;
            lenght = len;
            hight = h;
            width = w;
        }
        public void Print()
        {
            Console.WriteLine("Адрес здания: {0} \nДлина здания: {1} \nШирина здания: {2} \nВысота здания: {3}", address, lenght, width, hight);
        }

    }
    sealed class MultiBuilding : Building
    {
        int levels { get; set; }
        public MultiBuilding(string add, double len, double h, double w, int n)
            : base(add, len, h, w)
        {
            levels = n;
        }
        public void Print()
        {
            base.Print();
            Console.WriteLine("В здании {0} этажей", levels);
        }
    }
}
