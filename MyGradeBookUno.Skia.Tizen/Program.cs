using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace MyGradeBookUno.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new MyGradeBookUno.App(), args);
            host.Run();
        }
    }
}
