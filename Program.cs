using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_HW7_Struct
{
    class Program
    {
        struct Complex
        {
            public double r, i;
            public Complex Sum(Complex a, Complex b)
            {
                Complex result = new Complex();
                result.r = a.r + b.r;
                result.i = a.i + b.i;
                return result;
            }
            public Complex Substract(Complex a, Complex b)
            {
                Complex result = new Complex();
                result.r = a.r - b.r;
                result.i = a.i - b.i;
                return result;
            }
            public Complex Multiplication(Complex a, Complex b)
            {
                Complex result = new Complex();
                result.r = (a.r * a.i) - (b.r * b.i);
                result.i = (a.r * b.i) + (b.r * a.i);
                return result;
            }
            public void Print()
            {
                if (i < 0) Console.WriteLine($"z = {r}{i}i");
                else Console.WriteLine($"z = {r}+{i}i");
            }
        }
        struct Car
        {
            public int length;
            public int clearance;
            public string engineType;
            public double engineVolume;
            public int hp;
            public int rimsDiameter;
            public string color;
            public string transType;


            //Constructor

            public Car(
                 int length, int clearance, string engineType,
                 double engineVolume, int hp, int rimsDiameter,
                 string color, string transType
                 )
            {
                this.length = length;
                this.clearance = clearance;
                this.engineType = engineType;
                this.engineVolume = engineVolume;
                this.hp = hp;
                this.rimsDiameter = rimsDiameter;
                this.color = color;
                this.transType = transType;

            }
            public void MakeACar()
            {
                Console.WriteLine("Конструктор автомобиля!");
                Console.Write("Введите длину авто: ");
                this.length = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите клиренс авто: ");
                this.clearance = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите тип двигателя авто: ");
                this.engineType = Console.ReadLine();
                Console.Write("Введите обьем двигателя авто: ");
                this.engineVolume = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите мощность авто: ");
                this.hp = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите диаметр дисков авто: ");
                this.rimsDiameter = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите цвет авто: ");
                this.color = Console.ReadLine();
                Console.Write("Введите тип КПП авто: ");
                this.transType = Console.ReadLine();
            }
            public void Print()
            {
                Console.WriteLine($"Создан автомобиль длиной {length}, с клиренсом: {clearance}, с двигателем {engineType} обьемом {engineVolume}, мощностью {hp} и коробкой передач - {transType} на дисках {rimsDiameter} радиуса, цвет - {color}!");
            }



        }
        public static void Main(string[] args)
        {
            Task_Complex(); 



        }
        public static void Task_Complex()
        {
            //Your code goes here
            Console.Write("Введите целую часть первого комплексного числа: ");
            double r1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите мнимую часть первого комплексного числа: ");
            double i1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите целую часть второго комплексного числа: ");
            double r2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите мнимую часть первого комплексного числа: ");
            double i2 = Convert.ToDouble(Console.ReadLine());

            Complex c1 = new Complex();
            Complex c2 = new Complex();
            Complex res = new Complex();
            c1.r = r1;
            c1.i = i1;
            c2.r = r2;
            c2.i = i2;
            c1.Print();
            c2.Print();
            do
            {
                Console.WriteLine("Какое действие надо комплексными числами вы хотите совершить?");
                char act = Convert.ToChar(Console.ReadLine());
                switch (act)
                {
                    case '+':
                        res = res.Sum(c1, c2);
                        res.Print();
                        break;
                    case '-':
                        res = res.Substract(c1, c2);
                        res.Print();
                        break;
                    case '*':
                        res = res.Multiplication(c1, c2);
                        res.Print();
                        break;
                    default: break;
                }
            } while (Console.ReadKey().KeyChar == ' ');
        }
        public static void Task_Car()
        {
            Car Lada = new Car();
            Lada.MakeACar();
            Car MiniCooper = new Car();
            MiniCooper.MakeACar();
            List<Car> cars = new List<Car>(3);
            cars.Add(new Car()
            { length = 5500, clearance = 140, engineType = "V4", engineVolume = 3.5, hp = 300, rimsDiameter = 16, color = "Black", transType = "AT" });
            cars.Add(Lada);
            cars.Add(MiniCooper);
            foreach (Car item in cars)
            {
                if (item.hp > 185) item.Print();
            }
        }
        
    }
}
