using System;
using System.Collections.Generic;

namespace Tarea_Semana_07
{

 /*Tomando en cuenta la teoría de la clase sobre pilas, resuelva el código en C# la verificación  de una operación matemática se encuentran balanceados:
   Ej: {7+(8*5)-[(9-7)+(4+1)]} resultado => formula balanceada.*/

    public class Program
    {
        static bool AreParenthesesBalanced(string expression)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in expression)
            {
                // Si encontramos un carácter de apertura, lo empujamos a la pila
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                // Si encontramos un carácter de cierre, verificamos si coincide con el carácter de apertura en la cima de la pila
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0) // Si la pila está vacía, no hay carácter de apertura correspondiente
                    {
                        return false;
                    }

                    char top = stack.Pop();

                    if ((c == ')' && top != '(') ||
                        (c == '}' && top != '{') ||
                        (c == ']' && top != '['))
                    {
                        return false; // Los caracteres no coinciden
                    }
                }
            }

            // Si la pila está vacía, significa que todos los caracteres de apertura tienen sus correspondientes caracteres de cierre
            return stack.Count == 0;
        }

        static void Main(string[] args)
        {
            string expression = "{7+(8*5)-[(9-7)+(4+1)]}";
            bool result = AreParenthesesBalanced(expression);
            Console.WriteLine(result ? "La fórmula está balanceada." : "La fórmula no está balanceada.");
        }
    }




 /*Realice un algoritmo en C# y el uso de pilas para resolver el problema de las torres de Hanoi.
  * (El siguiente ejercicio esta como comentario borrar los "*//*" y colocar en comentario el anterior ejercicio para que se ejecute).*/


    /*class Program
    {
        // Definimos una pila para representar cada torre
        Stack<int> torreA = new Stack<int>();
        Stack<int> torreB = new Stack<int>();
        Stack<int> destino = new Stack<int>();

        // Método principal
        static void Main(string[] args)
        {
            Program program = new Program();
            program.InicializarTorres(3); // Inicializamos las torres con 3 discos
            program.ResolverHanoi(3, program.torreA, program.destino, program.torreB);
        }

        // Inicializa la torre de origen con los discos
        void InicializarTorres(int n)
        {
            for (int i = n; i >= 1; i--)
            {
                torreA.Push(i);
            }
        }

        // Método recursivo para resolver el problema de las Torres de Hanoi
        void ResolverHanoi(int n, Stack<int> torreA, Stack<int> destino, Stack<int> torreB)
        {
            if (n > 0)
            {
                // Mover n-1 discos de la torre origen a la torre auxiliar
                ResolverHanoi(n - 1, torreA, torreB, destino);
                // Mover el disco restante a la torre destino
                MoverDisco(torreA, destino);
                // Mover los n-1 discos de la torre auxiliar a la torre destino
                ResolverHanoi(n - 1, torreB, destino, torreA);
            }
        }

        // Mueve un disco de una torre a otra e imprime el movimiento
        void MoverDisco(Stack<int> torreA, Stack<int> destino)
        {
            int disco = torreA.Pop();
            destino.Push(disco);
            Console.WriteLine("Mover disco " + disco + " de " + ObtenerNombreTorre(torreA) + " a " + ObtenerNombreTorre(destino));
        }

        // Devuelve el nombre de la torre para fines de impresión
        string ObtenerNombreTorre(Stack<int> torre)
        {
            if (torre == torreA) return "torreA";
            else if (torre == destino) return "destino";
            else return "torreB";
        }
    }    */
}
