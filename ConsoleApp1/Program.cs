/* Instituto Federal de Educação, Ciência e Tecnologia de Rondônia - IFRO
 * C.S.T. em Análise e Desenvolvimento de Sistemas
 * Disciplina de Algoritmo e Lógica  de Programação I
 * Professor Clayton Ferraz Andrade
 *
 * Acadêmico Vinícius de Oliveira Pinheiro
 * Aula do dia 05-04-2023
 */

// Variáveis

Console.WriteLine("Bem vindo ao IFRO.\nEscolha aqui o seu futuro.\nDigite 1 para " +
    "escolher Análise e Desenvolvimento de Sistemas.\nDigite 2 para escolher " +
    "Licenciatura em Química.\nDigite 3 para escolher Engenharia Florestal.");

int opcao = 0;
opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
        Console.WriteLine("Você escolheu Análise e Desenvolvimento de Sistemas " +
            "- Tecnólogo");
        break;

    case 2:
        Console.WriteLine("Você escolheu Química - Licenciatura");
        break;

    case 3:
        Console.WriteLine("Você escolheu Engenharia Florestal - Bacharel");
        break;

    default:
        Console.WriteLine("Não entendi bem. Poderia repetir?");
        break;
}


Console.WriteLine("\nBem vindo ao IFRO.\nEscolha aqui o seu futuro.\nDigite ADS para " +
    "escolher Tecnólogo em Análise e Desenvolvimento de Sistemas.\nDigite QUÍMICA para escolher " +
    "Licenciatura em Química.\nDigite ENG para escolher Engenharia Florestal.");

string op;
op = Console.ReadLine();
op = op.ToUpper();
switch (op)
{
    case "ADS":
        Console.WriteLine("Você escolheu Análise e Desenvolvimento de Sistemas " +
            "- Tecnólogo");
        break;

    case "QUÍMICA" or "QUIMICA":
        Console.WriteLine("Você escolheu Química - Licenciatura");
        break;

    case "ENG" or "ENGENHARIA" or "ENGENHARIA FLORESTAL" or "FLORESTA" or "FLORESTAL":
        Console.WriteLine("Você escolheu Engenharia Florestal - Bacharel");
        break;

    default:
        Console.WriteLine("Não entendi bem. Poderia repetir?");
        break;
}

Console.ReadLine();