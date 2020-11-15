using System;

namespace SLot_test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int pos1, pos2, pos3, rp1, rp2, rp3;//для 
            int dev1=0, dev2=10, dev3=20;//обозначения переменных(символов на барабане)
            int des1=21, des2=30, des3=40;
            int j1=41, j2=50, j3=60;
            int q1=61, q2=70, q3=75;
            int k1=76, k2=80, k3=90;
            int a1=91, a2=95, a3=100;
            double win, sum, bet;//выигрыш, начальная сумма, ставка
            Console.Write("Введите начальную сумму(>0): ");
            sum = Convert.ToDouble(Console.ReadLine());
            //Console.Write(sum);//ввод и проверка начальной суммы начальной суммы. Рандом через костыли пока
            Console.Write("Введите сумму ставки(>0): ");
            bet = Convert.ToDouble(Console.ReadLine());//тож самое только со ставкой

            /*pos1 = random.Next(100);//рандом вроде работает
            //Console.Write(pos1);
            pos2 = random.Next(100);
            //Console.Write(pos2);
            pos3 = random.Next(100);
            //Console.Write(pos3);*/
            for (sum=sum; sum < 0; sum -= bet)
            {
                rp1 = random.Next(100);
                rp1 = random.Next(100);
                rp1 = random.Next(100);
               
            }
        }
    }
}
