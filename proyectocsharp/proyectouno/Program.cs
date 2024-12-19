// See https://aka.ms/new-console-template for more information
// programa inútil excepto como practica
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kali {
    class Programa {
        static void Main(string[] args) {
            Console.WriteLine("Hola desde kali");
	    Console.WriteLine("Hola desde a consola");
	    List<int> miLista = new List<int>();
	    miLista.Add(8);
	    miLista.Add(12);
	    miLista.Add(23);	
	    miLista.Add(4);
	    foreach (int nu in miLista){
		    Console.Write(nu +" ");
	    }
        miLista.Sort();
        Console.WriteLine("");
        foreach (int num in miLista){
            Console.Write(num +" ");
        }
        int total=0;
        Console.WriteLine("");
        foreach (int numero in miLista){
            total += numero;
        }
        Console.WriteLine("suma total: " +total);
        
	Console.Write("Cómo te chamas? ");
        string? nombre=Console.ReadLine();
        if (nombre=="Azrael" || nombre=="azrael")
        
        Console.WriteLine("Que nombre mais feo, ti chamaste tonecho"); 
        
        else if (nombre=="Elena")
        Console.WriteLine("Non me aburras");
        else
        
        Console.WriteLine("Hola {0}",nombre);

    }
    }
}
