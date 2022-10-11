
// Mudando conteudo de uma classe

using bytebank;

ContaCorrente matheus = new ContaCorrente();
matheus.titular = "Matheus";
matheus.numero_agencia = 22;
matheus.saldo = 20000;

Console.WriteLine("O saldo da minha conta corrente é: " + matheus.saldo);