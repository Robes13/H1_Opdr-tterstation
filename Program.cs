using Opdrætterstation.Controller;

namespace Opdrætterstation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Starting the program.
            MainController controller = new MainController();
            controller.Start();
        }
    }
}