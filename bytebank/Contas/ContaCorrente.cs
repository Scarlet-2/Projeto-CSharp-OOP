
using System;

namespace bytebank.Contas;
using bytebank.Titular;

public class ContaCorrente
{
    private int numero_agencia;
    private string conta = "";
    private double saldo = 0;

    private Titular titular;

    // Depositar
    public Titular Titular
    {
        get => titular;
        set => titular = value ?? throw new ArgumentNullException(nameof(value));
    }

    public double Saldo
    {
        get => saldo;
        set => saldo = value;
    }

    public string Conta
    {
        get => conta;
        set => conta = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int NumeroAgencia
    {
        get => numero_agencia;
        set => numero_agencia = value;
    }

    public void Depositar(double valor) {
        Saldo += valor;
    }

    public void Sacar(double valor) {

        if(valor >= Saldo) {
            Console.WriteLine("Você esta sacando mais que pode meu rapaz pode não.");
        
        } else {
            Saldo -= valor;
        }
    }

    public void Tranferir(double valor, ContaCorrente conta) {
        if (Saldo < valor) {
            Console.WriteLine("O valor ultrapassa seu saldo.");
        } else {
            Saldo -= valor;
            conta.saldo += valor;
            Console.WriteLine($"Valor R${valor} foi transferido com sucesso");
        }
    }
}


