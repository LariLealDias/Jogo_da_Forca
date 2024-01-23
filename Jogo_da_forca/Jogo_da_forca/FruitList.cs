using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_forca;

public class FruitList
{
    private  List<string> fruits;
    private Random _random;


    public FruitList()
    {
        fruits = new List<string> { "maça", "banana", "manga" };
        _random = new Random();

    }

     public void AddNewFruit()
    {
        Console.Write("  Digite uma nova fruta: ");
        string fruit = Console.ReadLine();

        bool isValid = System.Text.RegularExpressions.Regex.IsMatch(fruit, @"^[a-zA-Z]+$");

        if (!isValid)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($" Caracteres inválidos para: {fruit}");
            Console.ResetColor();
            return;
        }

        fruits.Add(fruit);

        Console.WriteLine("Fruta adicionada com sucesso");
     }

    public string GetRandomFruit()
    {
        int index = _random.Next(fruits.Count);

        return fruits[index];
    }




}
