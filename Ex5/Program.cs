﻿Console.Write("Ввведите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же маша");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}