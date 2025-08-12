Console.WriteLine("Informe seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine("Informe seu salario: ");
decimal salarioStr  = decimal.Parse(Console.ReadLine());
Console.WriteLine($"Bem vindo {nome}, Você tem ${salarioStr} kwanzas.");

//Informem o valor do IRPF a ser pago de acordo com salario informado. utilize a tabela real de desconto do IRPF