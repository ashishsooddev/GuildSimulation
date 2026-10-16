using GuildSimulation.Controllers;

namespace GuildSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            GameController controller = new GameController();
            controller.Run();
        }
    }
}