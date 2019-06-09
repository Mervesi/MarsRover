using MarsRoverAppLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            //Planet ctora 2 servis veriyorum, input ve output yani şu anda input ve outputun Console dan işleyeceği bildirisini yapıyorum. 
            //Bu tip temelde IInputService ve IOutputService interfacelerini implemente ettiklerinden, uygulama ileride input ve outputun 
            //Console dan değil de bir json dosyasından yada bir webservisden yada bir database den alınması istendiğinde 
            //tüm uygulamayı değiştirmeden programın başlangıç noktasından onu enjecte edebileyim. (Dependency Injection)
            Planet planet = new Planet(new ConsoleInputService(), new ConsoleOutputService());
            planet.CreateMap();
            planet.GenarateRovers();
            planet.RunRovers();
        }
    }
}
