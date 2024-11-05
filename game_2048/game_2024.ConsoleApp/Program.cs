using game.Domain;

namespace game_2024.ConsoleApp
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            game.generator_random_num();
            game.generator_random_num();
            
            game.Show_fila();

            int x = 0;
            while (x == 0)
            {
                game.in_value();


                switch (game.input)
                {
                    case "w":

                        game.move_up();

                        break;

                    case "s":
                        game.move_down();

                        break;

                    case "a":
                        game.move_left();

                        break;

                    case "d":
                        game.move_right();

                        break;

                        
                }
            }
        }
    }
}
