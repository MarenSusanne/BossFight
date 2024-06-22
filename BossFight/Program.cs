namespace BossFight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Hero hero = new Hero(100, 20, 40);
            Boss boss = new Boss(400, 10);
            game.StartBattle(hero, boss);
        }
    }
}
