using System;
using System.Globalization;

namespace ExerciciosParte2
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio 01
            //Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
            
            int num = int.Parse(Console.ReadLine());

            if(num >= 0){
                Console.WriteLine("NÃO É NEGATIVO!");
            }
            else
            {
                Console.WriteLine("É NEGATIVO!");
            }            
            //fim exercicio 01

            //exercicio 02
            //Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
            
            int N = int.Parse(Console.ReadLine());

            if(N % 2 == 0)
            {
                Console.WriteLine(N + " é par!");
            }
            else
            {
                Console.WriteLine(N + " é ímpar!");
            }            
            //fim exercicio 02

            //exercicio 03
            /*Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
            Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser
            digitados em ordem crescente ou decrescente.*/
            
            string[] valores = Console.ReadLine().Split(' ');
            int A = int.Parse(valores [0]);
            int B = int.Parse(valores [1]);

            if(A % B == 0 || B % A == 0)
            {
                Console.WriteLine("São Múltiplos!");
            }
            else
            {
                Console.WriteLine("Não São Múltiplos!");
            }            
            //fim exercicio 03

            //exercicio 04
            /*Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode 
            começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.*/
            
            string[] horas = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(horas[0]);
            int horaFinal = int.Parse(horas[1]);
            int duracao;

            if(horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORAS!");            
            //fim exercicio 04

            //exercicio 05
            /*Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A 
            seguir, calcule e mostre o valor da conta a pagar.
            
            Código      Especificação           Preço
                1       Cachorro Quente         R$ 4,00
                2       X-Salada                R$ 4,50
                3       X-Bacon                 R$ 5,00
                4       Torrada Simples         R$ 2,00
                5       Refrigerante            R$ 1,50
            */
            
            string[] item = Console.ReadLine().Split(' ');
            int valores = int.Parse(item[0]);
            int qtd = int.Parse(item[1]);

            double total;

            if (valores == 1)
            {
                total = qtd * 4.00;
            } 
            else if (valores == 2)
            {
                total = qtd * 4.50;
            }
            else if (valores == 3)
            {
                total = qtd * 5.00;
            }
            else if (valores == 4)
            {
                total = qtd * 2.00;
            }
            else
            {
                total = qtd * 1.50;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));            
            //fim exercicio 05

            //exercicio 06
            /*Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos 
            seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor
            não estiver em nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.*/
            
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor >= 0.00 && valor <= 25.00) {
                Console.WriteLine("Intervalo entre (0,25)");
            }else if (valor > 25.00 && valor <= 50.00) {
                Console.WriteLine("Intervalo entre (25,50)");
            }else if (valor > 50 && valor <= 75) {
                Console.WriteLine("Intervalo entre (50,75)");
            }else if (valor > 75 && valor <= 100) {
                Console.WriteLine("Intervalo entre (75,100)");
            }else {
                Console.WriteLine("Fora de intervalo");
            }  
            //fim exercicio 06

            //exercicio 07
            /*Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano.
            A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou
            na origem (x = y = 0). Se o ponto estiver na origem, escreva a mensagem “Origem”. Se o ponto estiver sobre um
            dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.*/
            
            string[] valores = Console.ReadLine().Split(' ');
            double X = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double Y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if (X == 0.0 && Y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (X > 0.0 && Y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (X < 0.0 && Y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (X < 0.0 && Y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
            //fim exercicio 07

            //exercicio 08
            //enunciado não acoplado, mas fala sobre imposto de renda
            
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto;

            if (salario <= 2000.00)
            {
                imposto = 0.0;
            }else if (salario <= 3000.00)
            {
                imposto = (salario - 2000) * 0.08;
            }else if (salario <= 4500.00)
            {
                imposto = (salario - 3000.00) * 0.18 + 1000 * 0.08;
            }else
            {
                imposto = (salario - 4500.00) * 0.28 + 1500.00 * 0.18 + 1000.00 * 0.08;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine(imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            //fim exercicio 08
        }
    }
}
