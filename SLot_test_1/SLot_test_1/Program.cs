using System;

namespace SLot_test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int pos1 = 0, pos2 = 0, pos3 = 0, rp1, rp2, rp3, rpALL;//для 
            int dev1 = 27, dev2 = 27, dev3 = 27;//обозначения переменных(символов на барабане)
            int des1 = 48, des2 = 48, des3 = 48;
            int j1 = 67, j2 = 67, j3 = 67;
            int q1 = 80, q2 = 80, q3 = 80;
            int k1 = 95, k2 = 95, k3 = 95;
            int a1 = 100, a2 = 100, a3 = 100;
            double win = 0, sum, bet;//выигрыш, начальная сумма, 
            do
            {
                Console.Write("Введите начальную сумму(>0): ");
                sum = Convert.ToDouble(Console.ReadLine());
                //Console.Write(sum);//ввод и проверка начальной суммы начальной суммы. Рандом через костыли пока
                Console.Write("Введите сумму ставки(>0): ");
                bet = Convert.ToDouble(Console.ReadLine());//тож самое только со ставкой
            } while (sum < 0 || bet < 0);
            /*pos1 = random.Next(100);//рандом вроде работает
            //Console.Write(pos1);
            pos2 = random.Next(100);
            //Console.Write(pos2);
            pos3 = random.Next(100);
            //Console.Write(pos3);*/

            while (sum > 0)
            {
                if (bet > sum) { Console.WriteLine("Ставка превышает баланс! Вы проиграли :("); }
                else
                {
                    Console.ReadLine();
                    rp1 = random.Next(100);
                    rp2 = random.Next(100);
                    rp3 = random.Next(100);
                    rpALL = random.Next(100);

                    if (rp1 <= 27 || rp2 <= 27 || rp3 <= 27)
                    {
                        if (rp1 <= 27) { pos1 = dev1; };
                        if (rp2 <= 27) { pos2 = dev2; };
                        if (rp3 <= 27) { pos3 = dev3; };
                    }
                    if (rp1 <= 48 || rp2 <= 48 || rp3 <= 48)
                    {
                        if (rp1 <= 48 && rp1 > 27) { pos1 = des1; };
                        if (rp2 <= 48 && rp2 > 27) { pos2 = des2; };
                        if (rp3 <= 48 && rp3 > 27) { pos3 = des3; };
                    }
                    if (rp1 <= 67 || rp2 <= 67 || rp3 <= 67)
                    {
                        if (rp1 <= 67 && rp1 > 48) { pos1 = j1; };
                        if (rp2 <= 67 && rp2 > 48) { pos2 = j2; };
                        if (rp3 <= 67 && rp3 > 48) { pos3 = j3; };
                    }
                    if (rp1 <= 80 || rp2 <= 80 || rp3 <= 80)
                    {
                        if (rp1 <= 80 && rp1 > 67) { pos1 = q1; };
                        if (rp2 <= 80 && rp2 > 67) { pos2 = q2; };
                        if (rp3 <= 80 && rp3 > 67) { pos3 = q3; };
                    }
                    if (rp1 <= 95 || rp2 <= 95 || rp3 <= 95)
                    {
                        if (rp1 <= 95 && rp1 > 80) { pos1 = k1; };
                        if (rp2 <= 95 && rp2 > 80) { pos2 = k2; };
                        if (rp3 <= 95 && rp3 > 80) { pos3 = k3; };
                    }
                    if (rp1 <= 100 || rp2 <= 100 || rp3 <= 100)
                    {
                        if (rp1 <= 100 && rp1 > 95) { pos1 = a1; };
                        if (rp2 <= 100 && rp2 > 95) { pos2 = a2; };
                        if (rp3 <= 100 && rp3 > 95) { pos3 = a3; };
                    }
                    //sum = sum - bet;//это в конец вместе с sum=sum+win
                    Console.WriteLine();
                    Console.Write(pos1);
                    Console.WriteLine();
                    Console.Write(pos2);
                    Console.WriteLine();
                    Console.Write(pos3);
                    if (rpALL > 40)
                    {
                        Console.WriteLine("\nRpALL=");
                        Console.Write(rpALL);

                        if (pos1 == pos2 || pos1 == pos3)
                        {
                            if ((pos1 == pos2 && pos1 == 27) || (pos1 == pos3 && pos1 == 27)) { win = bet * 0.5; };
                            if ((pos1 == pos2 && pos1 == 48) || (pos1 == pos3 && pos1 == 48)) { win = bet * 2.5; };
                            if ((pos1 == pos2 && pos1 == 67) || (pos1 == pos3 && pos1 == 67)) { win = bet * 5; };
                            if ((pos1 == pos2 && pos1 == 80) || (pos1 == pos3 && pos1 == 80)) { win = bet * 7; };
                            if ((pos1 == pos2 && pos1 == 95) || (pos1 == pos3 && pos1 == 95)) { win = bet * 9; };
                            if ((pos1 == pos2 && pos1 == 100) || (pos1 == pos3 && pos1 == 100)) { win = bet * 12; };

                        }
                        if (pos1 == pos2 && pos1 == pos3)
                        {
                            if (pos1 == 27) { win = bet * 8; };
                            if (pos1 == 48) { win = bet * 12; };
                            if (pos1 == 67) { win = bet * 20; };
                            if (pos1 == 80) { win = bet * 25; };
                            if (pos1 == 95) { win = bet * 30; };
                            if (pos1 == 100)
                            {
                                Console.WriteLine("Джекпот :)");
                                win = bet * 80;
                            }
                        }
                        sum -= bet;
                        sum += win;
                        Console.WriteLine("\nВаш выигрыш: ");
                        Console.Write(win);
                        Console.WriteLine("\nБаланс:");
                        Console.WriteLine(sum);
                        win = 0;
                        if (sum == 0) { Console.Write("Игра завершена. Вы проиграли :("); };
                    }
                    else
                    {
                        sum -= bet;
                        sum += win;
                        Console.WriteLine("\nВаш выигрыш: ");
                        Console.Write(win);
                        Console.WriteLine("\nБаланс:");
                        Console.WriteLine(sum);
                        win = 0;
                        if (sum == 0) { Console.Write("Игра завершена. Вы проиграли :("); };
                    }
                }
            }//end while
        }
    }
}
