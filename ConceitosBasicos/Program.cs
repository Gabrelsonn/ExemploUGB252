Console.WriteLine("Informe seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine("Informe seu salario: ");
decimal salario = decimal.Parse(Console.ReadLine());
Console.WriteLine($"Bem vindo {nome}, Você tem ${salario} kwanzas.");

//Informem o valor do IRPF a ser pago de acordo com salario informado. utilize a tabela real de desconto do IRPF



if (salario >= 2259.20m) {
    Console.WriteLine("Isento");
}
else if (salario <= 2259.20m && salario >= 2826.65m) {
    Console.WriteLine("Terá que pagar a aliquota de 7,5%");
}
else if (salario <= 2826.65m && salario >= 3751.05m)
{
    Console.WriteLine("Terá que pagar a aliquota de 15%-R$381,44");
}
else if (salario <= 2751.05m && salario >= 4664.68m)
{
    Console.WriteLine("Terá que pagar a aliquota de 22,5%-R$662,77");
}
else
    salario <= 4664.68m
        Console.WriteLine("Terá que pagar a aliquota de 27,5%-R$896,00");











