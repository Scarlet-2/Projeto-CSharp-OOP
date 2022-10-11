
using System;

namespace bytebank;

public class ContaCorrente
{
    public int numero_agencia;
    public string conta;
    public string titular;
    public double saldo;

    // Depositar
    public void Depositar(double valor) {
        this.saldo += valor;
    }

    public void Sacar(double valor) {

        if(valor >= this.saldo) {
            System.Console.WriteLine("Você esta sacando mais que pode meu rapaz pode não.");
        
        } else {
            this.saldo -= valor;

        }

    }
}


