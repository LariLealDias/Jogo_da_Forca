
using Jogo_da_forca;

class Program
{
    //static Reception Reception = new Reception();
    public static FruitList fruitList = new FruitList();
    public static GameLogic gameLogic = new GameLogic(fruitList);

    static void Main(string[] args)
    {
        int user_option;
        do
        {
            Reception.Welcome();
            Console.Write(" Digite a opção: ");
            user_option = int.Parse(Console.ReadLine());

            //string user_option = Console.ReadLine();

            switch (user_option) {
                case 1:
                    //Console.WriteLine("jogar");
                    gameLogic.PlayGame();
                    break;
                case 2:
                    fruitList.AddNewFruit();
                    break;
                case 3:
                    Console.WriteLine("Encerrar");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

        } while (user_option != 3);

    }
}