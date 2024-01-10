Random rnd = new Random();
Console.WriteLine("Как вас зовут");
string name = Console.ReadLine();
Console.WriteLine($"Здраствуйте, {name} попробуйте угадать число ");
bool rematch = true;
int tryes = 0;
string answers;
int unknow_number = rnd.Next(1, 101);
while (rematch)
{

    int answer = int.Parse(Console.ReadLine());
    if (answer == unknow_number)
    {
        Console.WriteLine("Вы угадали ");
        Console.WriteLine($"Вам понадобилось,{tryes} попыток. Хотите еще раз?");
        answers = Console.ReadLine();
        if (answers == "Да")
        {
            unknow_number = rnd.Next(1, 101);
            Console.WriteLine("Попробуйте угадать число");
            continue;
        }
        else
        {
            rematch = false;
        }

    }
    else if (answer > unknow_number)
    {
        Console.WriteLine("много");
        tryes++;
    }
    else if (answer < unknow_number)
    {
        Console.WriteLine("мало");
        tryes++;
    }
}