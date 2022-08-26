using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lista_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ex1a();
            // Ex1b();
            // Ex1c();
            // Ex1d();
            // Ex1e();
            // Ex1f();
            Ex1g();
            // Ex1h();
            // Ex1i();
            // Ex1j();
            // Ex1k();
        }
        static void Ex1a()
        {
            int a, b, c, x;
            Console.WriteLine("Entre com o primeiro valor: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo valor: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o terceiro valor: ");
            c = int.Parse(Console.ReadLine());
            if (a > b)
            {
                x = a;
                a = b;
                b = x;
            }
            if (a > c)
            {
                x = c;
                c = a;
                c = x;
            }
            if (c > b)
            {
                x = c;
                c = b;
                b = x;
            }
            Console.WriteLine("A ordem crescente e {0}{1}{2}", a, b, c);
            Console.ReadKey();
        }
        static void Ex1b()
        {
            int r;
            float g, pi = 3.14f;
            Console.WriteLine("Entre com o angulho em radioanos:");
            r = int.Parse(Console.ReadLine());
            g = (r * 180 / pi);
            Console.WriteLine("Graus {0}", g);
            Console.ReadKey();
        }
        static void Ex1c()
        {
            int a, b;
            double hipotenusa;
            Console.WriteLine("Insira o cateto A");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o cateto B");
            b = int.Parse(Console.ReadLine());

            hipotenusa = Math.Sqrt((a * a) + (b * b));
            Console.WriteLine("A Hipotenusa e:" + hipotenusa);
            Console.ReadKey();
        }
        static void Ex1d()
        {
            int a;
            Console.WriteLine("Insira um Valor:");
            a = int.Parse(Console.ReadLine());
            if (a % 2 == 0 && a > 0)
            {
                Console.WriteLine(Math.Sqrt(a));
                Console.ReadKey();
            }
        }
        static void Ex1e()
        {
            int a, b;
            Console.WriteLine("Entre com o primeiro valor: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo valor: ");
            b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("O primeiro valor e maior:" + a);
                Console.ReadKey();
            }
            else if (b > a)
            {
                Console.WriteLine("O segundo valor e maior:" + b);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Os valores sao iguais");
                Console.ReadKey();
            }
        }
        static void Ex1f()
        {
            int dia;
            Console.WriteLine("Entre com um valor entre 1 e 7 para o dia da Semana:");
            dia = int.Parse(Console.ReadLine());
            while (dia >= 1 || dia <= 7)
            {
                Console.WriteLine("Voce entrou com um valor invalido, insira novamente");
                dia = int.Parse(Console.ReadLine());
            }
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda - Feira");
                    break;
                case 3:
                    Console.WriteLine("Terça - Feira");
                    break;
                case 4:
                    Console.WriteLine("Quarta - Feira");
                    break;
                case 5:
                    Console.WriteLine("Quinta - Feira");
                    break;
                case 6:
                    Console.WriteLine("Sexta - Feira");
                    break;
                case 7:
                    Console.WriteLine("Sabado");
                    break;
            }
            Console.ReadKey();
        }
        static void Ex1g()
        {
            int a, b, op;

            Console.WriteLine("Insira um valor");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um segundo valor");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Voce deseja fazer qual operação \n1-Soma \n2-Subtracao \n3-Multiplicacao\n4-Divisao\n");
            op = char.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("A Soma e:{0}", a + b);
                    break;
                case 2:
                    Console.WriteLine("A Subtraçao e:{0}", a - b);
                    break;
                case 3:
                    Console.WriteLine("A Multriplicação e:{0}", a * b);
                    break;
                case 4:
                    Console.WriteLine("A Divisão e:{0}", a / b);
                    break;
            }
            Console.ReadKey();
        }
        static void Ex1h()
        {
            int x;

            Console.WriteLine("Insira um valor:");
            x = int.Parse(Console.ReadLine());

            if (x % 3 == 0)
                Console.WriteLine("O valor e divisivel por 3");
            else if (x % 5 == 0)
                Console.WriteLine("O valor e divisivel por 5");
            else
                Console.WriteLine("O valor nao e divisivel por 3 ou 5");
            Console.ReadKey();
        }
        static void Ex1i()
        {
            int KM, l, cm;

            Console.WriteLine("Insira quantos KM voce andou:");
            KM = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira quantos Litros de gasolina voce gastou:");
            l = int.Parse(Console.ReadLine());

            cm = KM / l;
            if (cm < 8)
                Console.WriteLine("Venda o carro ou compre um posto!\r\n");
            else if (cm == 8 || cm < 14)
                Console.WriteLine("Econômico!\r\n");
            else if (cm > 14)
                Console.WriteLine("Super econômico!");
        }
        static void Ex1j()
        {
            int x, y, z;
            char op;

            Console.WriteLine("Insira o valor de X");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor de Y");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor de Z");
            z = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Qual operação voce deseja \na-Ponderada \nb-Harmônica \nc-Aritmética");
            op = char.Parse(Console.ReadLine());

            switch (op)
            {
                case 'a':
                    Console.WriteLine("Ponderada: {0}", (x + (2 * y) + (3 * z)) / 6);
                    break;
                case 'b':
                    Console.WriteLine("Harmônica:{0}", 1 / ((1f / x) + (1f / y) + (1f / z)));
                    break;
                case 'c':
                    Console.WriteLine("Aritmética:{0}", (x + y + z) / 3);
                    break;
            }
            Console.ReadKey();
        }
        static void Ex1k()
        {
            float venda, tt;

            Console.WriteLine("Entre com o valor de venda:");
            venda = float.Parse(Console.ReadLine());

            if (venda >= 100000)
            {
                tt = 700 + (venda * 0.14f);
                Console.WriteLine("A comissao e:{0}", tt);
            }
            else if (venda < 100000 || venda >= 80000)
            {
                tt = 650 + (venda * 0.14f);
                Console.WriteLine("A comissao e:{0}", tt);
            }
            else if (venda < 80000 || venda > 60000)
            {
                tt = 600 + (venda * 0.14f);
                Console.WriteLine("A comissao e:{0}", tt);
            }
            else if (venda < 60000 || venda > 40000)
            {
                tt = 550 + (venda * 0.14f);
                Console.WriteLine("A comissao e:{0}", tt);
            }
            else if (venda < 40000 || venda > 20000)
            {
                tt = 500 + (venda * 0.14f);
                Console.WriteLine("A comissao e:{0}", tt);

            }
            else if (venda < 20000)
            {
                tt = 400 + (venda * 0.14f);
                Console.WriteLine("A comissao e:{0}", tt);
            }
            Console.ReadKey();

        }
    }
}

