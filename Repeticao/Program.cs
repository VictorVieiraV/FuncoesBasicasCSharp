using System;
using System.Globalization;

namespace Repeticao {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Qual função deseja utilizar? ");
            Console.WriteLine("1) Verifica senha correta");
            Console.WriteLine("2) Verifica quadrante pertencente");
            Console.WriteLine("3) Calcula preferência de combustível");
            Console.WriteLine("4) Imprime numeros impares ate numero digitado");
            Console.WriteLine("5) Imprime qtd de numeros dentro do intervalo");
            Console.WriteLine("6) Calcula media ponderada");
            Console.WriteLine("7) Calcula divisao de pares");
            Console.WriteLine("9) Calculo fatorial");
            Console.WriteLine("9) Calcula divisores");
            Console.WriteLine("10) Calcula raiz quadrada e cubica");
            int opcaoSeleciona = int.Parse(Console.ReadLine());

            if (opcaoSeleciona == 1) {
                VerificaSenhaCorreta();
            } else if (opcaoSeleciona == 2) {
                VerificaQuadrantePertencente();
            } else if (opcaoSeleciona == 3) {
                CalculaPrerenciaCombustivel();
            } else if (opcaoSeleciona == 4) {
                ImprimeNumerosImparesAteNumeroDigitado();
            } else if (opcaoSeleciona == 5) {
                ImprimeQtdNumerosDentroDoIntervalo();
            } else if (opcaoSeleciona == 6) {
                CalculaMediaPonderada();
            } else if (opcaoSeleciona == 7) {
                CalculaDivisaoDePares();
            } else if (opcaoSeleciona == 8) {
                CalculoFatorial();
            } else if (opcaoSeleciona == 9) {
                CalculaDivisores();
            } else if (opcaoSeleciona == 10) {
                CalculaPotenciaQuadradaECubica();
            } else {
                Console.WriteLine("Opção Invalida!");
            }
        }
        static void VerificaSenhaCorreta() {
            Console.Write("Digite sua senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002) {
                Console.WriteLine("Senha incorreta!");
                Console.Write("Digite novamente sua senha: ");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido!");
        }
        static void VerificaQuadrantePertencente() {
            Console.WriteLine("Digite duas coordenadas com espaços entre elas");
            string[] coordenadas = Console.ReadLine().Split(" ");
            double coordenadaX = double.Parse(coordenadas[0]);
            double coordenadaY = double.Parse(coordenadas[1]);

            while (double.Parse(coordenadaX.ToString("F4")) != 0 &&
                   double.Parse(coordenadaY.ToString("F4")) != 0) {
                if (coordenadaX >= 0.00 && coordenadaY >= 0.00) {
                    Console.WriteLine("primeiro quadrante");
                } else if (coordenadaX <= 0.00 && coordenadaY >= 0.00) {
                    Console.WriteLine("segundo quadrante");
                } else if (coordenadaX <= 0.00 && coordenadaY <= 0.00) {
                    Console.WriteLine("terceiro quadrante");
                } else {
                    Console.WriteLine("quarto quadrante");
                }
                Console.WriteLine(" ");
                Console.WriteLine("Digite novas coordenadas");
                coordenadas = Console.ReadLine().Split();
                coordenadaX = double.Parse(coordenadas[0]);
                coordenadaY = double.Parse(coordenadas[1]);
            }
        }
        static void CalculaPrerenciaCombustivel() {
            Console.WriteLine("Informe qual foi combutível abastecido");
            Console.WriteLine("1) Álcool");
            Console.WriteLine("2) Gasolina");
            Console.WriteLine("3) Diesel");
            Console.WriteLine("4) Fim");
            Console.Write("Digite a opção: ");
            int opcao = int.Parse(Console.ReadLine());

            int opcaoAlcool = 0;
            int opcaoGasolina = 0;
            int opcaoDiesel = 0;

            while (OpcaoValida(opcao)) {
                if (opcao == 1) {
                    opcaoAlcool++;
                    opcao = int.Parse(Console.ReadLine());

                } else if (opcao == 2) {
                    opcaoGasolina++;
                    opcao = int.Parse(Console.ReadLine());

                } else if (opcao == 3) {
                    opcaoDiesel++;
                    opcao = int.Parse(Console.ReadLine());

                } else {
                    Console.WriteLine("Opção Invalida");
                    Console.WriteLine("Digite uma nova opção: ");
                    opcao = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {opcaoAlcool}");
            Console.WriteLine($"Gasolina: {opcaoGasolina}");
            Console.WriteLine($"Diesel: {opcaoDiesel}");

            static bool OpcaoValida(int opcao) {
                if (opcao != 4) {
                    return true;
                } else {
                    return false;
                }
            }
        }
        static void ImprimeNumerosImparesAteNumeroDigitado() {
            Console.WriteLine("Digite um numero");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Numeros ímpares até o valor digitado");

            for (int i = 0; i < num; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine($"{i}");
                }
            }
        }
        static void ImprimeQtdNumerosDentroDoIntervalo() {
            Console.WriteLine("Quantos numeros vai digitar?");
            int qtdMaxima = int.Parse(Console.ReadLine());
            int fora = 0;
            int dentro = 0;

            for (int i = 0; i < qtdMaxima; i++) {
                Console.WriteLine("Digite um numero");
                int numeroDigitado = int.Parse(Console.ReadLine());
                if (estaNoIntervalo(numeroDigitado)) {
                    dentro++;
                } else {
                    fora++;
                }
            }
            Console.WriteLine($"{dentro} int");
            Console.WriteLine($"{fora} out");

            static bool estaNoIntervalo(int num) {
                if (num >= 10 && num <= 20) {
                    return true;
                } else {
                    return false;
                }
            }
        }
        static void CalculaMediaPonderada() {
            Console.WriteLine("Digite a quantidade de casos de testes");
            int casosTeste = int.Parse(Console.ReadLine());

            for (int i = 0; i < casosTeste; i++) {
                Console.WriteLine("Digite 3 valores reais separados por espaço");
                string[] array = Console.ReadLine().Split(" ");
                double num1 = double.Parse(array[0], CultureInfo.InvariantCulture);
                double num2 = double.Parse(array[1], CultureInfo.InvariantCulture);
                double num3 = double.Parse(array[2], CultureInfo.InvariantCulture);
                double media = ((num1 * 2) + (num2 * 3) + (num3 * 5)) / 10;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
        static void CalculaDivisaoDePares() {
            Console.WriteLine("Digite a quantidade de casos de testes");
            int casosTeste = int.Parse(Console.ReadLine());

            for (int i = 0; i < casosTeste; i++) {
                Console.WriteLine("Digite 2 valores separados por espaço");
                string[] array = Console.ReadLine().Split(" ");
                double num1 = int.Parse(array[0]);
                double num2 = int.Parse(array[1]);

                if (num2 == 0) {
                    Console.WriteLine("divisão impossível");
                } else {
                    double divisao = num1 / num2;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
        static void CalculoFatorial() {
            Console.Write("Digite um valor para o calculo fatorial: ");
            int num = int.Parse(Console.ReadLine());
            int resultado = 1;

            for (int i = 1; i <= num; i++) {
                resultado = resultado * i;
            }
            Console.WriteLine(resultado);
        }
        static void CalculaDivisores() {
            Console.WriteLine("Digite o numero que para calculo de seus divisores");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Divisores");
            for (int i = 1; i <= num; i++) {
                if (num % i == 0) {
                    Console.WriteLine(i);
                }
            }
        }
        static void CalculaPotenciaQuadradaECubica() {
            Console.WriteLine("Digite um numero");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++) {
                Console.WriteLine($"{i}, {Math.Pow(i, 2)}, {Math.Pow(i, 3)}");
            }
        }
    }
}
