using System;
namespace atividade03 {
    class Programa {
        static void Main (string[] args) {
            Console.WriteLine ("Informe um valor inteiro: ");
            int n1 = int.Parse (Console.ReadLine ());
            Console.WriteLine ("Informe outro valor inteiro: ");
            int n2 = int.Parse (Console.ReadLine ());

            if (n1 % n2 == 0 || n2 % n1 == 0) {
                Console.WriteLine ("Ps numeros sao multiplos");
            } else {
                Console.WriteLine("Não são multiplos");
            }
            Console.ReadKey ();
        }
    }
}