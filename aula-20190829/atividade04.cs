using System;
namespace atividade04 {
    class Programa {
        static void Main (string[] args) {
            int codigo;
            int quantidade;
            int total;
            Console.WriteLine ("Digite o código do produto: ");
            codigo = int.Parse (Console.ReadLine ());
            Console.WriteLine ("Informe a quantidade de hotdog: ");
            quantidade = int.Parse (Console.ReadLine ());

            switch (codigo) {
                case 1:
                    total = quantidade * 4;
                    break;
                case 2:
                    total = quantidade * 4;
                    break;
                case 3:
                    total = quantidade * 4;
                    break;
                case 4:
                    total = quantidade * 4;
                    break;
                case 5:
                    total = quantidade * 4;
                    break;
                default:
                    break;
            }

            Console.ReadKey ();
        }
    }
}