using System;

namespace SLot_test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int pos1, pos2, pos3;
            int dev1, dev2, dev3;
            int des1, des2, des3;
            int j1, j2, j3;
            int q1, q2, q3;
            int k1, k2, k3;
            int a1, a2, a3;
            double win, sum, bet;
            Console.Write("Введите начальную сумму(>0): ");
            sum = Convert.ToDouble(Console.ReadLine());
            //Console.Write(sum);//ввод и проверка начальной суммы начальной суммы. Рандом через костыли пока
            Console.Write("Введите сумму ставки(>0): ");
            bet = Convert.ToDouble(Console.ReadLine());//тож самое только со ставкой

            pos1 = random.Next(100);//рандом вроде работает
            Console.Write(pos1);
        }
    }
}
