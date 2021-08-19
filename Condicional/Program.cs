using System;
using System.Globalization;

namespace Condicional {
    class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Qual função deseja utilizar? ");
            Console.WriteLine("1) Verifica se o numero é negativo ou positivo");
            Console.WriteLine("2) Verifica se o numero é par ou impar");
            Console.WriteLine("3) Verifica se dois numeros sao multiplos");
            Console.WriteLine("4) Calcula duracao de um jogo");
            Console.WriteLine("5) Calcula valor conta");
            Console.WriteLine("6) Calcula faixa valor");
            Console.WriteLine("7) Calcula quadrante");
            Console.WriteLine("8) Calcula imposto renda");
            int opcaoSeleciona = int.Parse(Console.ReadLine());

            if (opcaoSeleciona == 1) {
                VerificaSeNegativoOuPositivo();

            } else if (opcaoSeleciona == 2) {
                VerificaSeParOuImpar();

            } else if (opcaoSeleciona == 3) {
                VerificaSeSaoMultiplos();

            } else if (opcaoSeleciona == 4) {
                CalculaDuracaoJogo();

            } else if (opcaoSeleciona == 5) {
                CalculaValorConta();

            } else if (opcaoSeleciona == 6) {
                CalculaFaixaValor();

            } else if (opcaoSeleciona == 7) {
                CalculaQuadrante();

            } else if (opcaoSeleciona == 8) {
                CalculaImpostoRenda();

            } else {
                Console.WriteLine("Opção Invalida!");
            }
        }

        public static void VerificaSeNegativoOuPositivo() {
            Console.WriteLine("Digite um número");

            int num = int.Parse(Console.ReadLine());
            if (num < 0) {
                Console.WriteLine("NEGATIVO");

            } else {
                Console.WriteLine("POSITIVO");
            }
        }

        public static void VerificaSeParOuImpar() {
            Console.WriteLine("Digite um número");

            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) {
                Console.WriteLine("PAR");

            } else {
                Console.WriteLine("IMPAR");
            }
        }

        public static void VerificaSeSaoMultiplos() {
            Console.WriteLine("Digite os números com espaço entre eles");

            string[] array = Console.ReadLine().Split(" ");
            int num1 = int.Parse(array[0]);
            int num2 = int.Parse(array[1]);

            if (num1 % num2 == 0 || num2 % num1 == 0) {
                Console.WriteLine("São Multiplos");

            } else {
                Console.WriteLine("Não são Multiplos");
            }
        }

        public static void CalculaDuracaoJogo() {
            Console.WriteLine("Digite o horario inicio e fim como inteiro e com espaço entre eles");

            string[] array = Console.ReadLine().Split(" ");

            int horaInicio = int.Parse(array[0]);
            int horaFim = int.Parse(array[1]);
            if (horaInicio >= horaFim) {
                int resultado = 24 - horaInicio + horaFim;
                Console.WriteLine($"O JOGO DUROU {resultado} HORA(S)");
            } else {
                int resultado = horaFim - horaInicio;
                Console.WriteLine($"O JOGO DUROU {resultado} HORA(S)");
            }
        }

        public static void CalculaValorConta() {
            Console.WriteLine("Digite o código do item e as unidades com espaço entre eles");

            string[] array = Console.ReadLine().Split(" ");
            double[] precos = { 4.00, 4.50, 5.00, 2.00, 1.50 };

            int codigoItem = int.Parse(array[0]);
            int qtdItem = int.Parse(array[1]);

            double valorConta = precos[codigoItem - 1] * qtdItem;
            Console.WriteLine($"Total: R$ {valorConta.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public static void CalculaFaixaValor() {
            Console.WriteLine("Digite os números com espaço entre eles");

            double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (num >= 0 && num <= 25.00) {
                Console.WriteLine("Intervalo [0,25]");

            } else if (num > 25.00 && num <= 50.00) {
                Console.WriteLine("Intervalo [25,50]");

            } else if (num > 50.00 && num <= 75.00) {
                Console.WriteLine("Intervalo [50,75]");

            } else if (num > 75.00 && num <= 100.00) {
                Console.WriteLine("Intervalo [75,100]");

            } else {
                Console.WriteLine("Fora de intervalo");
            }
        }

        public static void CalculaQuadrante() {
            Console.WriteLine("Digite as coordenadas com espaço entre elas");

            string[] coordenadas = Console.ReadLine().Split(" ");
            double coordenadaX = double.Parse(coordenadas[0]);
            double coordenadaY = double.Parse(coordenadas[1]);

            if (coordenadaX == 0.00 && coordenadaY == 0.00) {
                Console.WriteLine("Ponto de Origem");

            } else if (coordenadaX == 0.00) {
                Console.WriteLine("Sobre o Eixo Y");

            } else if (coordenadaY == 0.00) {
                Console.WriteLine("Sobre o Eixo X");

            } else if (coordenadaX > 0.00 && coordenadaY > 0.00) {
                Console.WriteLine("Quadrande Q1");

            } else if (coordenadaX < 0.00 && coordenadaY > 0.00) {
                Console.WriteLine("Quadrande Q2");

            } else if (coordenadaX < 0.00 && coordenadaY < 0.00) {
                Console.WriteLine("Quadrande Q3");

            } else {
                Console.WriteLine("Quadrande Q4");
            }
        }

        public static void CalculaImpostoRenda() {
            Console.WriteLine("Digite o valor do sálario");

            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (verificaFaixaSalarial(salario) == 1) {
                Console.WriteLine("Isento");

            } else if (verificaFaixaSalarial(salario) == 2) {
                double impostoAPagar = (salario - 2000.00) * 0.08;
                Console.WriteLine($"R$ {impostoAPagar}");

            } else if (verificaFaixaSalarial(salario) == 3) {
                double impostoAPagar = (1000 * 0.08) + ((salario - 3000.00) * 0.18);
                Console.WriteLine($"R$ {impostoAPagar.ToString("F2", CultureInfo.InvariantCulture)}");

            } else {
                double impostoAPagar = (1000 * 0.08) + (1500 * 0.18) + ((salario - 4500.00) * 0.28);
                Console.WriteLine($"R$ {impostoAPagar.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            int verificaFaixaSalarial(double salario) {
                if (salario <= 2000.00) {
                    return 1;
                } else if (salario > 2000.00 && salario <= 3000.00) {
                    return 2;
                } else if (salario > 3000.00 && salario <= 4500.00) {
                    return 3;
                } else {
                    return 4;
                }
            }
        }
    }
}
