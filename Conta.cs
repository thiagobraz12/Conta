
public class Conta
{
    public int id;
    public string agencia;
    public string Nconta;
    public string nomePro;
    public double saldo;

    public void Depositar(double valor)
    {
        if (valor >= 0)
        {
            saldo += valor;
            Console.WriteLine($"Depósito de {valor} realizado com sucesso. Saldo atual: {saldo}");
        }
        else
        {
            //Console.WriteLine("Valor de depósito inválido.");
            throw new Exception("Valor de depósito inválido."); //lançar exceção
                                                                //somente na logica 
        }
    }
    public void Sacar(double valor)
    {
        if (valor > 0 && valor <= saldo)
        {
            saldo -= valor;
            Console.WriteLine($"Saque de {valor} realizado com sucesso. Saldo atual: {saldo}");
        }
        else
        {
            Console.WriteLine("Valor de saque inválido ou saldo insuficiente.");
        }
    }
    public void depositar()
    {
        Console.WriteLine("Digite o valor do depósito");
        double valor = Convert.ToDouble(Console.ReadLine());
        Depositar(valor);
    }
    public void depositar(double valor)
    {
        Depositar(valor);
    } 
    public Conta()
    {
        this.id = id;
        this.agencia = agencia;
        this.Nconta = Nconta;
        this.nomePro = nomePro;
        this.saldo = saldo;
    }


}