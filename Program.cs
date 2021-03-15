using System;

namespace Gritador {
    class Program {
        static void Main(string[] args) {
            Console.Clear();
            Console.Beep();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("VAMOS BRINCAR EM DEIXAR TUDO MAISCULO, AQUILO QUE O AMIGUINHO DIGITAR");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;;
            Console.WriteLine("Olá prazer me chamo Fabiano e você, como se chama? ");
            string nome = Console.ReadLine();

            if (nome == nome.ToUpper()) {
                Console.WriteLine("Desligue o CAPS LOK");
            } else {
                Console.WriteLine($"Seja bem vindo, {nome.ToUpper()}, como foi o seu dia? ");
                string textoDigitado = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{textoDigitado.ToUpper()}, Ual!!! {nome.ToUpper()}, o que houve? no proximo encontro quero saber, Tchau.");
                Console.ResetColor();
            }
        }
    }
}
