using System;
namespace PacotePrograma {
    class Programa {
        static void Main (string[] args) {
            int n1;
            Console.WriteLine ("Informe um valor inteiro: ");
            n1 = int.Parse (Console.ReadLine ());

            if (n1 % 2 == 0) {
                Console.WriteLine ("Este número é par");
            } else {
                Console.WriteLine ("Este número é impar")
            }
            Console.ReadKey ();
        }
    }
}