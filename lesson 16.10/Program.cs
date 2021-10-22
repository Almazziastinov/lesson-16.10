using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_16._10
{
    enum AccountType 
    {
        Current,
        Savings 
    }
    class Bank
    {
        static public int number = 472384;
        private int AccBalanc;

        private AccountType type;

        public AccountType Type
        {
            get { return type; }
            set { type = value; }
        }

        public int Balanc
        {
            get { return AccBalanc; }
            set { AccBalanc = value; }
        }
        

        public Bank()
        {
            number++;
        }



        public void Put(int money)
        {
            Balanc += money;
            Console.WriteLine(Balanc);
        }

        public bool GetMoney(int money)
        {
            if (Balanc < money)
            {
                return false;
            }
            else
            {
                Balanc -= money;
                return true;
            }
        }
    }
    class Building
    {
        static public int housnum = 1;
        public Building()
        {
            housnum++;
        }
        private int floorHight;

        public int FloorHight
        {
            get { return floorHight; }
            set { floorHight = value; }
        }

        private int floor;

        public int Floor
        {
            get { return floor; }
            set { floor = value; }
        }

        private int appartNum;

        public int Appart
        {
            get { return appartNum; }
            set { appartNum = value; }
        }

        private int entrance;

        public int Entrance
        {
            get { return entrance; }
            set { entrance = value; }
        }
        public void Hight(int hight)
        {
            hight = FloorHight * Floor;
            Console.WriteLine($"Высота дома - {hight}");
        }
        
        public void AppartinEnt(int apent)
        {
            apent = Appart / Entrance;
            Console.WriteLine($"Количество квартир в подъезде - {apent}");
            AppartinFloor(apent);
        }

        public void AppartinFloor(int apoor)
        {
            apoor /= Floor;
            Console.WriteLine($"Количество квартир н этаже - {apoor}");
        }

    }


    class Program
    {
        static void Main()
        {
            Console.WriteLine("7.1-2");
            Bank alpha = new Bank();
            alpha.Balanc = 5000;
            alpha.Type = AccountType.Current;
            Console.WriteLine($"{Bank.number}\t{alpha.Balanc}\t{alpha.Type}");


            Bank alpha1 = new Bank();
            alpha1.Balanc = 5000;
            alpha1.Type = AccountType.Current;
            Console.WriteLine($"{Bank.number}\t{alpha1.Balanc}\t{alpha1.Type}");


            Console.WriteLine("7.3");
            Console.WriteLine("Назовите тип операции, которую хотите осуществить\nЕсли хотите положить деньги на счёт впишите: 1\nесли хотите снять: 2 ");
            int monney = Convert.ToInt32(Console.ReadLine());
            if (monney == 1)
            {
                Console.WriteLine("Какое количество средств хотите положить?");
                int put = Convert.ToInt32(Console.ReadLine());
                alpha1.Put(put);
            }
            else if (monney == 2)
            {
                Console.WriteLine("Какое количество средств хотите снять?");
                int get = Convert.ToInt32(Console.ReadLine());
                bool proverka = alpha1.GetMoney(get);
                if (proverka == false)
                {
                    Console.WriteLine("У вас недостаточно средств");

                }
                else
                {
                    Console.WriteLine(alpha1.Balanc);
                }
                
            }
            else
            {
                Console.WriteLine("Вы ввелине  не то число)");
            }

            Console.WriteLine("7.1");
            Building build = new Building();
            build.Floor = 10;
            build.Entrance = 5;
            build.Appart = 300;
            build.FloorHight = 5;
            Console.WriteLine($"колво этажей - {build.Floor}\tколво подъездо - {build.Entrance}\t колво квартир - {build.Appart}\t высота квартиры - {build.FloorHight}");
            int hight = 0;
            build.Hight(hight);
            int apent = 0;
            build.AppartinEnt(apent);



        }
        
    }

}
