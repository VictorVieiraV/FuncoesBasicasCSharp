using System;
using System.Globalization;

namespace Sequencial {
    class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Qual função deseja utilizar? ");
            Console.WriteLine("1) Soma dois numeros");
            Console.WriteLine("2) Calcula raio do circulo");
            Console.WriteLine("3) Calcula diferenca entre numeros");
            Console.WriteLine("4) Calcula salario por horas trabalhadas");
            Console.WriteLine("5) Calcula valores a serem pagos");
            Console.WriteLine("6) Calcula area");
            int opcaoSeleciona = int.Parse(Console.ReadLine());

            if (opcaoSeleciona == 1) {
                SomaDoisNumeros();

            } else if (opcaoSeleciona == 2) {
                CalculaRaioDoCirculo();

            } else if (opcaoSeleciona == 3) {
                CalculaDiferencaEntreNumeros();

            } else if (opcaoSeleciona == 4) {
                CalculaSalarioPorHorasTrabalhadas();

            } else if (opcaoSeleciona == 5) {
                CalculaValoresASeremPagos();

            } else if (opcaoSeleciona == 6) {
                CalculaArea();

            } else {
                Console.WriteLine("Opção Invalida!");
            }
        }

        public static void SomaDoisNumeros() {
            int A, B, soma;
            Console.WriteLine("Digite o primeiro numero ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero ");
            B = int.Parse(Console.ReadLine());

            soma = A + B;

            Console.WriteLine("SOMA = " + soma);
        }

        public static void CalculaRaioDoCirculo() {
            double R, A, pi = 3.14159;
            Console.WriteLine("Digite o valor do raio");
            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A = pi * R * R;

            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));
        }

        public static void CalculaDiferencaEntreNumeros() {
            int A, B, C, D, dif;
            Console.WriteLine("Digite o valor de A");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de D");
            D = int.Parse(Console.ReadLine());

            dif = A * B - C * D;

            Console.WriteLine("DIFERENCA = " + dif);
        }

        public static void CalculaSalarioPorHorasTrabalhadas() {
            int numero, horas;
            double valorHora, salario;

            Console.WriteLine("Digite o id do funcionario");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite as horas trabalhadas");
            horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da hora trabalhada");
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = valorHora * horas;

            Console.WriteLine("Numero = " + numero);
            Console.WriteLine("Salario = R$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void CalculaValoresASeremPagos() {
            int qte1, qte2;
            double preco1, preco2, total;

            Console.WriteLine("Digite a quantidade e preco separados por espaço");
            string[] valores = Console.ReadLine().Split(' ');
            qte1 = int.Parse(valores[0]);
            preco1 = double.Parse(valores[1], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            qte2 = int.Parse(valores[0]);
            preco2 = double.Parse(valores[1], CultureInfo.InvariantCulture);

            total = preco1 * qte1 + preco2 * qte2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void CalculaArea() {
            Console.WriteLine("Qual forma geometrica deseja calcular a area?");
            Console.WriteLine("1) Triangulo");
            Console.WriteLine("2) Circulo");
            Console.WriteLine("3) Trapezio");
            Console.WriteLine("4) Quadrado");
            Console.WriteLine("5) Retangulo");
            Console.WriteLine("Digite a opção: ");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1) {
                Console.WriteLine("Digite a base e altura separados por espaço");
                string[] array = Console.ReadLine().Split(" ");
                float A = float.Parse(array[0], CultureInfo.InvariantCulture);
                float B = float.Parse(array[1], CultureInfo.InvariantCulture);
                float areaTriangulo = (A * B) / 2;
                Console.WriteLine($"Triangulo: {areaTriangulo.ToString("F3", CultureInfo.InvariantCulture)}");

            } else if (opcao == 2) {
                Console.WriteLine("Digite o valor do raio");
                int raio = int.Parse(Console.ReadLine());
                float pi = 3.14159F;
                float areaCirculo = pi * (raio * raio);
                Console.WriteLine($"Circulo: {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}");

            } else if (opcao == 3) {
                Console.WriteLine("Digite o valor das bases e altura separados por espaço");
                string[] array = Console.ReadLine().Split(" ");
                float A = float.Parse(array[0], CultureInfo.InvariantCulture);
                float B = float.Parse(array[1], CultureInfo.InvariantCulture);
                float C = float.Parse(array[2], CultureInfo.InvariantCulture);
                float areaTrapezio = ((A + B) / 2) * C;
                Console.WriteLine($"Trapezio: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");

            } else if (opcao == 4) {
                Console.WriteLine("Digite o valor da base");
                int B = int.Parse(Console.ReadLine());
                float areaQuadrado = B * B;
                Console.WriteLine($"Quadrado: {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}");

            } else if (opcao == 5) {
                Console.WriteLine("Digite o valor da e altura separados por espaço");
                string[] array = Console.ReadLine().Split(" ");
                float A = float.Parse(array[0], CultureInfo.InvariantCulture);
                float B = float.Parse(array[1], CultureInfo.InvariantCulture);
                float areaRetangulo = A * B;
                Console.WriteLine($"Retangulo: {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            } else {
                Console.WriteLine("Opção Invalida!");
            }
        }
    }
}
