using System;
namespace atividade02 {
    public static class Programa {
        static void Main (string[] args) {
            int x;
            Console.WriteLine ("Informe um valor inteiro: ");
            x = int.Parse (Console.ReadLine ());

            if (x >= 0) {
                Console.WriteLine ("Não negativo");
            } else {
                Console.WriteLine ("Negativo");
            }
            Console.ReadKey ();
        }
    }
}