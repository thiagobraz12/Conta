
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



}