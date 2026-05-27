double A = 0, B = 0, result;
int choose;

while (true)
{
    Console.WriteLine("Меню выбора \n выберете действие");
    Console.WriteLine("1: Ввести А");
    Console.WriteLine("2: Ввести В");
    Console.WriteLine("3: Выполнить операцию '+' ");
    Console.WriteLine("4: Выполнить операцию '-' ");
    Console.WriteLine("5: Выполнить операцию '*' ");
    Console.WriteLine("6: Выполнить операцию '/' ");
    choose = Convert.ToInt32(Console.ReadLine());

    switch (choose)
    {
        case 1:
            Console.WriteLine("Введите значение для A:");
            A = Convert.ToDouble(Console.ReadLine());
            break;

        case 2:
            Console.WriteLine("Введите значение для B:");
            B = Convert.ToDouble(Console.ReadLine());
            break;



    }
}
