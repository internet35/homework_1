Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32((Console.ReadLine()));
int i, remainder = 0, newnum = 0;
for (i = n; i > 0; i = (i / 10))
        {
            remainder = i % 10;
            Console.Write(remainder);

            newnum = (newnum*10) + remainder;

        }


        if (newnum == n)
        {
            Console.WriteLine("число-палиндром");
        }
        else
        {
            Console.WriteLine("число не является палиндромом");
        }



