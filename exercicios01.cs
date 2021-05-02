using System;
using System.Globalization;

namespace ExerciciosParte1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*exercicio 01
             Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
            mensagem explicativa, conforme exemplos.*/
            
            int d = 0;
            int e = 0;

            Console.WriteLine(d + e);
            //fim do exercicio 01

            //exercicio 02
            /*Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo
            com quatro casas decimais conforme exemplos.

            Fórmula da área: area = π . raio2

            Considere o valor de π = 3.14159*/

            double pi = 3.14159;
            double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = pi * Math.Pow(r, 2);

            Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));
            //fim do exercicio 2

            //exercicio 3
            /*Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a
            diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).*/
            
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            int dif = A * B - C * D;

            Console.WriteLine("DIFERENÇA = " + dif );
            //fim exercicio 3

            //exercicio 4
            /*Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas,
            o valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o
            número e o salário do funcionário, com duas casas decimais.*/
            
            int funcionario = int.Parse(Console.ReadLine());
            int horasTrab = int.Parse(Console.ReadLine());
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salarioCalc = horasTrab * valorHora;

            Console.WriteLine("NUMBER = " + funcionario);
            Console.WriteLine("SALARY = R$ " + salarioCalc.ToString("F2", CultureInfo.InvariantCulture));
            //fim exercicio 4

            //exercicio 5
            /*Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de
            cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.
            Calcule e mostre o valor a ser pago.*/
            
            string[] valor = Console.ReadLine().Split(' '); //.Split(' ') - Permite ler o espaço em branco entre as
                                                            //aspas, também permite que tudo seja digitado em uma
                                                            //única linha, se digitar apenas um vetor e der enter o
                                                            //programa dará erro!

            int codp1 = int.Parse(valor[0]);
            int nump1 = int.Parse(valor[1]);
            double valorp1 = double.Parse(valor[2], CultureInfo.InvariantCulture);

            valor = Console.ReadLine().Split(' ');

            int codp2 = int.Parse(valor[0]);
            int nump2 = int.Parse(valor[1]);
            double valorp2 = double.Parse(valor[2], CultureInfo.InvariantCulture);

            double valortotal = nump1 * valorp1 + nump2 * valorp2;

            Console.WriteLine("VALOR A PAGAR: R$ " + valortotal.ToString("F2", CultureInfo.InvariantCulture));
            //fim exercicio 5

            //exercicio 6
            /*Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida,
            calcule e mostre:
              a) a área do triângulo retângulo que tem A por base e C por altura.
              b) a área do círculo de raio C. (pi = 3.14159)
              c) a área do trapézio que tem A e B por bases e C por altura.
              d) a área do quadrado que tem lado B.
              e) a área do retângulo que tem lados A e B.*/
            
            double a, b, c, PI = 3.14159;
            string[] valores = Console.ReadLine().Split(' ');
            a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double tri = (A * C) / 2;
            double cir = pi * (C * C);
            double tra = ((A + B) * C) / 2;
            double qua = B * B;
            double ret = A * B;

            Console.WriteLine("TRIÂNGULO = " + tri.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CÍRCULO = " + cir.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPÉZIO = " + tra.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO = " + qua.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETÂNGULO = " + ret.ToString("F3", CultureInfo.InvariantCulture));
            //fim exercicio 6
        }
    }
}
