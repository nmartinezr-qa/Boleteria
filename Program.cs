
using Boleteria.Presentacion;

namespace Boleteria
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Principal());
        }


    }
}