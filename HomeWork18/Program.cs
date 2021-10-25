using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork18
{
    // Проверить, корректно ли в строке расставлены скобки.
    class Program
    {
        static void Main(string[] args)
        {
            char[] line = new char[] { '(','d', 'f', '[', '{', '}', ']', '(', ')' };
            Console.WriteLine("Содержание строки");
            foreach (var i in line)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Stack stack = new Stack();

            for (int i = 0; i < line.Length; i++)
            {
                if ((line[i] == ')' || line[i] == '}' || line[i] == ']') && (stack.Count == 0))
                {
                    Console.WriteLine("Расстановка скобок в строке не корректная");
                    break;
                }
                if (line[i] == '(')
                {
                    stack.Push(')');
                }
                if (line[i] == '{')
                {
                    stack.Push('}');
                }
                if (line[i] == '[')
                {
                    stack.Push(']');
                }
                if ((line[i] == ')' || line[i] == '}' || line[i] == ']') && (stack.Count != 0))
                {
                    stack.Pop();
                }
                if (stack.Count == 0 && i == line.Length - 1)
                {
                    Console.WriteLine("Расстановка скобок в строке корректная");
                }
                if (stack.Count != 0 && i == line.Length - 1)
                {
                    Console.WriteLine("Расстановка скобок в строке не корректная");
                }
            }
            Console.ReadKey();
        }
    }
}
