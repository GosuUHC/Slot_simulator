﻿using System;

namespace SLot_test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int pos1=0, pos2=0, pos3=0, rp1, rp2, rp3;//для 
            int dev1=20, dev2=20, dev3=20;//обозначения переменных(символов на барабане)
            int des1=40, des2=40, des3=40;
            int j1=60, j2=60, j3=60;
            int q1=75, q2=75, q3=75;
            int k1=90, k2=90, k3=90;
            int a1=100, a2=100, a3=100;
            double win=0, sum, bet;//выигрыш, начальная сумма, ставка
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
            
            while(sum>0)
            {
                Console.ReadLine();
                rp1 = random.Next(100);
                rp2 = random.Next(100);
                rp3 = random.Next(100);
                if (rp1 <= 20 || rp2 <= 20 || rp3 <= 20)
                {
                    if (rp1 <= 20) { pos1 = dev1; };
                    if (rp2 <= 20) { pos2 = dev2; };
                    if (rp3 <= 20) { pos3 = dev3; };
                }
                if (rp1 <= 40 || rp2 <= 40 || rp3 <= 40)
                {
                    if (rp1 <= 40 && rp1 > 20) { pos1 = des1; };
                    if (rp2 <= 40 && rp2 > 20) { pos2 = des2; };
                    if (rp3 <= 40 && rp3 > 20) { pos3 = des3; };
                }
                if (rp1 <= 60 || rp2 <= 60 || rp3 <= 60)
                {
                    if (rp1 <= 60 && rp1 > 40) { pos1 = j1; };
                    if (rp2 <= 60 && rp2 > 40) { pos2 = j2; };
                    if (rp3 <= 60 && rp3 > 40) { pos3 = j3; };
                }
                if (rp1 <= 75 || rp2 <= 75 || rp3 <= 75)
                {
                    if (rp1 <= 75 && rp1 > 60) { pos1 = q1; };
                    if (rp2 <= 75 && rp2 > 60) { pos2 = q2; };
                    if (rp3 <= 75 && rp3 > 60) { pos3 = q3; };
                } 
                if (rp1 <= 90 || rp2 <= 90 || rp3 <= 90)
                {
                    if (rp1 <= 90 && rp1 > 75) { pos1 = k1; };
                    if (rp2 <= 90 && rp2 > 75) { pos2 = k2; };
                    if (rp3 <= 90 && rp3 > 75) { pos3 = k3; };
                }
                if (rp1 <= 100 || rp2 <= 100 || rp3 <= 100)
                {
                    if (rp1 <= 100 && rp1 > 90) { pos1 = a1; };
                    if (rp2 <= 100 && rp2 > 90) { pos2 = a2; };
                    if (rp3 <= 100 && rp3 > 90) { pos3 = a3; };
                }
                //sum = sum - bet;//это в конец вместе с sum=sum+win
                System.Console.WriteLine();
                Console.Write(pos1);
                System.Console.WriteLine();
                Console.Write(pos2);
                System.Console.WriteLine();
                Console.Write(pos3);
                if (pos1 == pos2 || pos1 == pos3)
                {
                    if ((pos1 == pos2 && pos1 == 20) || (pos1 == pos3 && pos1 == 20)) { win = bet * 0.5; };
                    if ((pos1 == pos2 && pos1 == 40) || (pos1 == pos3 && pos1 == 40)) { win = bet * 2.5; };
                    if ((pos1 == pos2 && pos1 == 60) || (pos1 == pos3 && pos1 == 60)) { win = bet * 5; };
                    if ((pos1 == pos2 && pos1 == 75) || (pos1 == pos3 && pos1 == 75)) { win = bet * 8; };
                    if ((pos1 == pos2 && pos1 == 100) || (pos1 == pos3 && pos1 == 100)) { win = bet * 10; };

                }
                if (pos1 == pos2&&pos1==pos3)
                {
                    if(pos1==20) { win = bet * 15; };
                    if (pos1 == 40) { win = bet * 25; };
                    if (pos1 == 60) { win = bet * 40; };
                    if (pos1 == 75) { win = bet * 60; };
                    if (pos1 == 90) { win = bet * 100; };
                    if (pos1 == 100) { win = bet * 200; };
                }
                sum -= bet;
                sum += win;
                win = 0;
            }//end while

        }
    }
}
