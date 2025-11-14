
string name = Console.ReadLine();
int number = int.Parse(Console.ReadLine());
number -= 1;
for (int i = 0; i < name.Length; i++)
    {
        if (i != number)
            Console.Write(name[i]);

        if (i > name.Length)
            Console.Write("عدد بزرگتر از رشته وارد سده است");
    }
Console.ReadKey();
           