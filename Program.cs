using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ast
{
    class Ast
    {
        public int a, b;
        public Ast(int a = 0, int b = 0)
        {
            this.a = a;
            this.b = b;
        }
        public static bool operator ==(Ast obj1, Ast obj2)
        {
            if ((obj1.a == obj2.a) && (obj1.b == obj2.b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Ast obj1, Ast obj2)
        {
            if ((obj1.a != obj1.a) || (obj1.b != obj1.b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }

    class program
    {
        static void Main(string[] args)
        {
            Ast ast = new Ast(a: 5, b: 7);
            //Ast ast2 = new Ast(a: 5, b: 7);
            Ast ast2 = new Ast(a: 6, b: 8);

            if (ast == ast2)
            {
                Console.WriteLine("Objects are equal");
            }
            else
            {
                Console.WriteLine("Objects are not equal");
            }

            Console.ReadLine();
        }
    }

}

