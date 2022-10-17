
using System;

namespace bytebank.Contas;
using bytebank.Titular;

public class ContaCorrente
{
    public int numero_agencia;
    public string conta = "";
    public double saldo = 0;

    public Titular titular;

    // Depositar
    public void Depositar(double valor) {
        this.saldo += valor;
    }

    public void Sacar(double valor) {

        if(valor >= this.saldo) {
            Console.WriteLine("Você esta sacando mais que pode meu rapaz pode não.");
        
        } else {
            this.saldo -= valor;
        }
    }

    public void Tranferir(double valor, ContaCorrente conta) {
        if (this.saldo < valor) {
            Console.WriteLine("O valor ultrapassa seu saldo.");
        } else {
            this.saldo -= valor;
            conta.saldo += valor;
            Console.WriteLine($"Valor R${valor} foi transferido com sucesso");
        }
    }
}


