    using System;

namespace ahorcado
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            Console.WriteLine("¿Cual es tu nombre? ");
            Nombre=Console.ReadLine();
            string palabra = "politecnico";
            int intentos = 3;
            string palabraAdivinada = new string('.', palabra.Length);

            Console.WriteLine("Bienvenido(a) " + Nombre + " al juego del ahorcado");
            Console.WriteLine("Esta palabra tiene " + palabra.Length + " letras, adivinala");

            while (intentos > 0 && palabraAdivinada != palabra)
            {
                Console.WriteLine("Intentos restantes " + intentos);
                Console.WriteLine("¿Conoces la palabra?: " + palabraAdivinada);

                string input = Console.ReadLine();
                if (input.Length == 1)
                {
                    char letra = input[0];
                    if (palabra.Contains(letra))
                    {
                        for (int i = 0; i < palabra.Length; i++)
                        {
                            if (palabra[i] == letra)
                            {
                                palabraAdivinada = palabraAdivinada.Substring(0, i) + letra + palabraAdivinada.Substring(i + 1);
                            }
                        }
                    }
                    else
                    {
                        intentos--;
                        Console.WriteLine("La " +letra+ " no está, coloca otra letra");
                    }
                }
                else
                {
                    if (palabra == input)
                    {
                        palabraAdivinada = palabra;
                    }
                    else
                    {
                        intentos--;
                        Console.WriteLine("La palabra " + input + " no es correcta");
                    }
                }
            }

            if (intentos == 0)
            {
                Console.WriteLine(Nombre+" !ESTAS AHORCADO¡, la palabra correcta era " +palabra);
            }
            else
            {
                Console.WriteLine(Nombre+" !GANASTE!");
            }
        }
    }
}
