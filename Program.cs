
/*Conta c1 = new Conta();

Console.WriteLine("Digite o valor ID");
c1.id = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a agencia");
c1.agencia = Console.ReadLine();

Console.WriteLine("Digite o numero da conta");
c1.Nconta = Console.ReadLine();

Console.WriteLine("Digite o nome do proprietario");
c1.nomePro = Console.ReadLine();

Console.WriteLine("\n");

c1.Depositar(100);
c1.Sacar(50);*/

/*List<Conta> contas = new List<Conta>(); // criar lista

while (true)
{
    Console.WriteLine("Digite 1 para cadastrar nova conta");
    Console.WriteLine("Digite 2 para listar todas");
    int opc = Convert.ToInt32(Console.ReadLine());

    if (opc == 1)
    {
        Console.WriteLine("Digite o valor ID");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite a agencia");
        string agencia = Console.ReadLine();
        Console.WriteLine("Digite o numero da conta");
        string Nconta = Console.ReadLine();
        Console.WriteLine("Digite o nome do proprietario");
        string nomePro = Console.ReadLine();
        Conta c1 = new Conta();
        c1.id = id;
        c1.agencia = agencia;
        c1.Nconta = Nconta;
        c1.nomePro = nomePro;
        contas.Add(c1);
    }
    else if (opc == 2)
    {
        foreach (var item in contas)
        {
            Console.WriteLine($"ID: {item.id}, Agencia: {item.agencia}, Conta: {item.Nconta}, Nome: {item.nomePro}");
        }

    }
}*/

try
{
    Console.WriteLine("Digite um numero");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite um segundo numero");
    int num2 = Convert.ToInt32(Console.ReadLine());

    int resultado = num / num2;
    Console.WriteLine($"Resultado: {resultado}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Não é possível dividir por zero" + ex.Message); ;
}
catch (FormatException ex)
{
    Console.WriteLine("Formato inválido" + ex.Message); ;
}
catch (OverflowException ex)
{
    Console.WriteLine("Número muito grande" + ex.Message); ;
}
catch (Exception ex)
{

    Console.WriteLine("Ocorreu um erro" + ex.Message); ;
}