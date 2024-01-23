using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_forca;

public class GameLogic
{
    private FruitList _fruitList;
    private string currentWord;
    private char[] displayWord;
    private int lives;


    public GameLogic(FruitList fruitList)
    {
        _fruitList = fruitList;
        currentWord = _fruitList.GetRandomFruit();
      
        lives = currentWord.Length;
        displayWord = new string('_', currentWord.Length).ToCharArray();


    }

    public void PlayGame()
    {
        //string currentWord = _fruitList.GetRandomFruit();

        //int lives = currentWord.Length;
        int user_option;
        //char[] displayWord = new string ('_', currentWord.Length).ToCharArray();

        while (lives > 0 && displayWord.Contains('_'))
        {
            string displayWordString = new string(displayWord);
            Console.Write($"Palavra: {displayWordString} ");
            Console.WriteLine($"Vidas: {lives}");
            Console.WriteLine();

            Console.Write("1 - digitar uma letra 2 - voltar -  3 - sair do programa");
            Console.Write(" Digite a opção: ");
            user_option = int.Parse(Console.ReadLine());
            switch (user_option)
            {
                case 1:
                    Console.WriteLine(  "DIGITE:");
                    char letter_user = char.Parse(Console.ReadLine());
                    GuessLetter(letter_user);
                    break;
                case 2:
                    return;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }


        }
        if(lives > 0)
            {
                Console.WriteLine(  "GANHOU");
            }
            else
            {
                Console.WriteLine(  "PERDEU");
            }


    }

    public void GuessLetter(char letter_user)
    {
        bool hit = false;

         for(int i = 0; i < currentWord.Length; i++)
        {
            if (currentWord[i] == letter_user)
            {
                displayWord[i] = letter_user;
                hit = true;
            }
        }

        if (!hit)
        {
            lives--;
            Console.WriteLine(  "VC ERROU");
        }
        else
        {
            Console.WriteLine(  "VC ACERTOU");
        }
    }

}
