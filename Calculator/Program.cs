/*
Checkpoint 1 - Desenvolver uma calculadora em aplicação Console C#.

O programa deve permitir ao usuário realizar operações básicas como adição, subtração, multiplicação e divisão. 
Utilizem estruturas de controle e fluxo, como if/else, switch, for, while e do-while.

Requisitos do Trabalho:
1-O programa deve apresentar o título "Calculadora (Adição / Subtração / Multiplicação / Divisão)", logo abaixo, deve apresentar menu com as seguintes opções:

Escolha uma opção:
1-Adição
2-Subtração
3-Multiplicação
4-Divisão
5-Sair

2-O usuário deve escolher uma operação digitando o número correspondente.
3-Após escolher a operação, o programa deve solicitar dois números ao usuário.
4-O programa deve realizar a operação escolhida e exibir o resultado.
5-O programa deve continuar executando até que o usuário escolha a opção de sair.
6-O programa deve tratar erros, como divisão por zero.

Entrega:
O código-fonte deve ser postado como 'público' no GitHub, a entrega será o link deste repositório!
Adicione ao readme do GitHub:
- O nome dos integrantes (até 5 pessoas)
- O print da tela com as opções da calculadora carregada (1-Adição, 2-Subtração, etc).
- 4 Print de evidência de teste, um print evidenciando o correto funcionamento de cada operação (1-Adição, 2-Subtração, etc).

Critérios de Avaliação:
Uso correto dos operadores de fluxo if/else ou switch/case	4 pts
Uso correto de tipos de dados das variáveis 4 pts
Boas práticas: Nomes das variáveis (PascalCase)	2 pts
Total	10 pts 
*/
Console.WriteLine("SEIA\n" +
    "Joao Victor Oliveira dos Santos - RM557948\r\nMatheus Alcântara Estevão - RM558193\r\nNicolle Pellegrino Jelinski - RM558610\r\nPedro Pereira dos Santos - RM552047\r\nEric Segawa Montagner - RM558224\n");
Console.WriteLine("Calculadora (Adição / Subtração / Multiplicação / Divisão)\n");


while (true)
{
    Console.WriteLine(
    "Escolha uma opção:\n" +
    "1-Adição\n" +
    "2-Subtração\n" +
    "3-Multiplicação\n" +
    "4-Divisão\n" +
    "5-Sair");

    Console.Write("Digite a opção desejada: ");
    string opt = Console.ReadLine();
    if (int.TryParse(opt, out int option))
    {
        if (option > 5)
        {
            Console.WriteLine("##########\nApenas numeros abaixo de 5\n##########");
        }
        else if (option == 1)
        {
            Console.Write("-----\nDigite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Resultado: {num1 + num2}\n-----");
        }
        else if (option == 2)
        {
            Console.Write("-----\nDigite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Resultado: {num1 - num2}\n-----");
        }
        else if (option == 3)
        {
            Console.Write("-----\nDigite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Resultado: {num1 * num2}\n-----");
        }
        else if (option == 4)
        {
            Console.Write("-----\nDigite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine("##########\nErro: Divisão por zero não permitida.##########\n");
            }
            else
            {
                Console.WriteLine($"Resultado: {num1 / num2}\n-----");
            }
        }
        else if (option == 5)
        {
            Console.WriteLine("Saindo...");
            break;
        }
        else
        {
            Console.WriteLine("Opção inválida.");
        }
    }
    else
    {
        Console.WriteLine("##########\nEscreva um numero\n##########");
        
    }
}