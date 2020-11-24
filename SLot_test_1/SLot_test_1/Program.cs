using System;

namespace SLot_test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int pos1 = 0, pos2 = 0, pos3 = 0, rp1=0, rp2=0, rp3=0, rpALL=0, rpv1=0,rpv2=0,rpv3=0;//для рандома и позиции на барабане
            int dev1 = 28, dev2 = 28, dev3 = 28;//обозначения переменных(символов на барабане)
            int des1 = 50, des2 = 50, des3 = 50;
            int j1 = 70, j2 = 70, j3 = 70;
            int q1 = 85, q2 = 85, q3 = 85;
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
           

            while (sum > 0)
            {
                if (bet > sum) { Console.WriteLine("Ставка превышает баланс! Вы проиграли :("); break; }
                else
                {
                    Console.ReadLine();
                    rp1 = random.Next(100);//первый прогон рандома
                    rp2 = random.Next(100);
                    rp3 = random.Next(100);
                    rpALL = random.Next(100);

                    if (rp1 <= 28 || rp2 <= 28 || rp3 <= 28)
                    {
                        if (rp1 <= 28) { pos1 = dev1; };
                        if (rp2 <= 28) { pos2 = dev2; };
                        if (rp3 <= 28) { pos3 = dev3; };
                    }
                    if (rp1 <= 50 || rp2 <= 50 || rp3 <= 50)
                    {
                        if (rp1 <= 50 && rp1 > 28) { pos1 = des1; };
                        if (rp2 <= 50 && rp2 > 28) { pos2 = des2; };
                        if (rp3 <= 50 && rp3 > 28) { pos3 = des3; };
                    }
                    if (rp1 <= 70 || rp2 <= 70 || rp3 <= 70)
                    {
                        if (rp1 <= 70 && rp1 > 50) { pos1 = j1; };
                        if (rp2 <= 70 && rp2 > 50) { pos2 = j2; };
                        if (rp3 <= 70 && rp3 > 50) { pos3 = j3; };
                    }
                    if (rp1 <= 85 || rp2 <= 85 || rp3 <= 85)
                    {
                        if (rp1 <= 85 && rp1 > 70) { pos1 = q1; };
                        if (rp2 <= 85 && rp2 > 70) { pos2 = q2; };
                        if (rp3 <= 85 && rp3 > 70) { pos3 = q3; };
                    }
                    if (rp1 <= 95 || rp2 <= 95 || rp3 <= 95)
                    {
                        if (rp1 <= 95 && rp1 > 85) { pos1 = k1; };
                        if (rp2 <= 95 && rp2 > 85) { pos2 = k2; };
                        if (rp3 <= 95 && rp3 > 85) { pos3 = k3; };
                    }
                    if (rp1 <= 100 || rp2 <= 100 || rp3 <= 100)
                    {
                        if (rp1 <= 100 && rp1 > 95) { pos1 = a1; };
                        if (rp2 <= 100 && rp2 > 95) { pos2 = a2; };
                        if (rp3 <= 100 && rp3 > 95) { pos3 = a3; };
                    }
                    if (rpALL > 65)//срезание шанса на победу(второй прогон рандома)
                    {
                        //Console.WriteLine("RpALL(шанс на победу для отладки и тестов)=");
                        //Console.Write(rpALL);
                        Console.WriteLine();
                        Console.Write(pos1);
                        Console.WriteLine();
                        Console.Write(pos2);
                        Console.WriteLine(); //Отображение символов
                        Console.Write(pos3);
                        if (pos1 == pos2 || pos1 == pos3)
                        {
                            if ((pos1 == pos2 && pos1 == 28) || (pos1 == pos3 && pos1 == 28)) { win = bet * 0.5; };
                            if ((pos1 == pos2 && pos1 == 50) || (pos1 == pos3 && pos1 == 50)) { win = bet * 2.5; };
                            if ((pos1 == pos2 && pos1 == 70) || (pos1 == pos3 && pos1 == 70)) { win = bet * 5; };
                            if ((pos1 == pos2 && pos1 == 85) || (pos1 == pos3 && pos1 == 85)) { win = bet * 7; };
                            if ((pos1 == pos2 && pos1 == 95) || (pos1 == pos3 && pos1 == 95)) { win = bet * 9; };
                            if ((pos1 == pos2 && pos1 == 100) || (pos1 == pos3 && pos1 == 100)) { win = bet * 12; };

                        }
                        if (pos1 == pos2 && pos1 == pos3)
                        {
                            if (pos1 == 28) { win = bet * 7; };
                            if (pos1 == 50) { win = bet * 12; };
                            if (pos1 == 70) { win = bet * 20; };
                            if (pos1 == 85) { win = bet * 25; };
                            if (pos1 == 95) { win = bet * 30; };
                            if (pos1 == 100)
                            {
                                Console.WriteLine("\nДжекпот :)");
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
                    else//3 прогон рандома для срезанного шанса победы
                    {
                        rpv1 = random.Next(1, 7);
                        rpv2 = random.Next(1, 7);
                        rpv3 = random.Next(1, 7);
                        if (rpv1 == 1) { pos1 = dev1; };
                        if (rpv2 == 1 && rpv2 != rpv1) { pos2 = dev2; };
                        if (rpv3 == 1 && rpv3 != rpv1) { pos3 = dev3; };
                        if (rpv1 == 2) { pos1 = des1; };
                        if (rpv2 == 2 && rpv2 != rpv1) { pos2 = des2; };
                        if (rpv3 == 2 && rpv3 != rpv1) { pos3 = des3; };
                        if (rpv1 == 3) { pos1 = j1; };
                        if (rpv2 == 3 && rpv2 != rpv1) { pos2 = j2; };
                        if (rpv3 == 3 && rpv3 != rpv1) { pos3 = j3; };
                        if (rpv1 == 4) { pos1 = q1; };
                        if (rpv2 == 4 && rpv2 != rpv1) { pos2 = q2; };
                        if (rpv3 == 4 && rpv3 != rpv1) { pos3 = q3; };
                        if (rpv1 == 5) { pos1 = k1; };
                        if (rpv2 == 5 && rpv2 != rpv1) { pos2 = k2; };
                        if (rpv3 == 5 && rpv3 != rpv1) { pos3 = k3; };
                        if (rpv1 == 6) { pos1 = a1; };
                        if (rpv2 == 6 && rpv2 != rpv1) { pos2 = a2; };
                        if (rpv3 == 6 && rpv3 != rpv1) { pos3 = a3; };
                        Console.WriteLine();
                        Console.Write(pos1);
                        Console.WriteLine();
                        Console.Write(pos2);
                        Console.WriteLine(); //Отображение символов
                        Console.Write(pos3);
                        if (pos1 == pos2 || pos1 == pos3)
                        {
                            if ((pos1 == pos2 && pos1 == 28) || (pos1 == pos3 && pos1 == 28)) { win = bet * 0.5; };
                            if ((pos1 == pos2 && pos1 == 50) || (pos1 == pos3 && pos1 == 50)) { win = bet * 2.5; };
                            if ((pos1 == pos2 && pos1 == 70) || (pos1 == pos3 && pos1 == 70)) { win = bet * 5; };
                            if ((pos1 == pos2 && pos1 == 85) || (pos1 == pos3 && pos1 == 85)) { win = bet * 6; };
                            if ((pos1 == pos2 && pos1 == 95) || (pos1 == pos3 && pos1 == 95)) { win = bet * 8; };
                            if ((pos1 == pos2 && pos1 == 100) || (pos1 == pos3 && pos1 == 100)) { win = bet * 12; };

                        }
                        if (pos1 == pos2 && pos1 == pos3)
                        {
                            if (pos1 == 28) { win = bet * 7; };
                            if (pos1 == 50) { win = bet * 12; };
                            if (pos1 == 70) { win = bet * 20; };
                            if (pos1 == 85) { win = bet * 25; };
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
                }
            }//end while
        }
    }
}
