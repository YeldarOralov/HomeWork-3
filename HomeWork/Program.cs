using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int counter = 0;
            char key;
            while (true)
            {
                key = Console.ReadKey().KeyChar;
                if (key == ' ')
                {
                    counter++;
                }
                if (key == '.')
                {
                    Console.WriteLine(counter);
                    break;
                }
            }

            //2
            counter = 3;
            int ticketNumber;
            int leftSum=0;
            int rightSum=0;
            ticketNumber = int.Parse(Console.ReadLine());
            while (counter!=0)
            {
                rightSum += ticketNumber % 10;
                ticketNumber /= 10;
                counter--;
            }
            counter = 3;
            while (counter != 0)
            {
                leftSum += ticketNumber % 10;
                ticketNumber /= 10;
                counter--;
            }
            if(leftSum == rightSum)
            {
                Console.WriteLine("Lucky Ticket");
            }
            else
            {
                Console.WriteLine("Not so lucky ticket");
            }

            //3
            int keyNumber;
            while (true)
            {
                keyNumber = Console.Read();
                if (keyNumber >= 65 && keyNumber <= 90)
                {
                    keyNumber += 32;
                    key = (char)keyNumber;
                    Console.Write(key);
                }
                else if (keyNumber >= 97 && keyNumber <= 122)
                {
                    keyNumber -= 32;
                    key = (char)keyNumber;
                    Console.Write(key);
                }
                else if (keyNumber == 13)
                {
                    break;
                }
                else
                {
                    key = (char)keyNumber;
                    Console.Write(key);
                }

            }

            //4

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            for (int i = A; i < B; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.ReadLine();
            }


            //5

            int N;
            string number="";
            N = int.Parse(Console.ReadLine());
            while (N > 0)
            {
                number += Convert.ToString(N%10);
            }
            Console.WriteLine(Convert.ToInt32(number));
            Console.ReadKey();
        }
    }
}
