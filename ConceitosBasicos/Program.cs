Console.WriteLine("Informe seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine("Informe seu salario: ");
decimal salario = decimal.Parse(Console.ReadLine());
Console.WriteLine($"Bem vindo {nome}, Você tem ${salario} kwanzas.");

//Informem o valor do IRPF a ser pago de acordo com salario informado. utilize a tabela real de desconto do IRPF

var calculo = salario * 0.075m;
var calculo1 = salario * 0.15m;
var calculo2 = salario * 0.225m;
var calculo3 = salario * 0.275m;

if (salario <= 2259.20m)
    Console.WriteLine("Isento");
else if (salario >= 2259.20m && salario <= 2826.65m)
{
    Console.WriteLine($"Terá que pagar a aliquota de 7,5% que é {calculo} que será descontado");
    Console.WriteLine($"Seu salario liquido é de {salario - calculo} kwanzas");
}
else if (salario >= 2826.65m && salario <= 3751.05m)
{
    Console.WriteLine($"Terá que pagar a aliquota de 15% que é {calculo1}");
    Console.WriteLine($"Seu salario liquido é de {salario - calculo1} kwanzas");
}
else if (salario >= 2751.05m && salario <= 4664.68m)
{
    Console.WriteLine($"Terá que pagar a aliquota de 22,5% que é {calculo2}");
    Console.WriteLine($"Seu salario liquido é de {salario - calculo2} kwanzas");
}
else
{
    Console.WriteLine($"Terá que pagar a aliquota de 27,5% que é {calculo3}");
    Console.WriteLine($"Seu salario liquido é de {salario - calculo3} kwanzas");
}











