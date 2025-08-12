Console.WriteLine("Informe seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine("Informe seu salario: ");
decimal salarioStr  = decimal.Parse(Console.ReadLine());
Console.WriteLine($"Bem vindo {nome}, Você tem ${salarioStr} kwanzas.");