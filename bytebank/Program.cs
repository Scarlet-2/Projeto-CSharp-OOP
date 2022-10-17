
// Mudando conteudo de uma classe

using bytebank;
using bytebank.Titular;
using bytebank.Contas;

ContaCorrente contaDoMatheus = new ContaCorrente();
// contaDoMatheus.titular = "Matheus";
contaDoMatheus.NumeroAgencia = 22;
contaDoMatheus.Saldo = 20000;
contaDoMatheus.Conta = "228";

// Usando deposito
contaDoMatheus.Depositar(2000); // Sucesso!!
Console.WriteLine($"O meu saldo atual é: {contaDoMatheus.Saldo}");

// Sacar
contaDoMatheus.Sacar(300);
Console.WriteLine($"Eu saquei 300 Reais agora meu saldo é: {contaDoMatheus.Saldo}");

/*
// Criação de outra conta 
ContaCorrente contaDaLuana = new ContaCorrente();
contaDaLuana.titular = "Luana";
contaDaLuana.numero_agencia = 29;
contaDaLuana.saldo = 0;
contaDaLuana.conta = "312";
*/

// Tranferencia
// contaDoMatheus.Tranferir(2000, contaDaLuana);

// Link de objeto com objeto
Titular conta = new Titular();
conta.nome = "Matheus";
conta.cpf = "56020676803";
conta.profissao = "Arquiteto";

ContaCorrente contaNormal = new ContaCorrente();
contaNormal.Saldo = 200;
contaNormal.Conta = "10x2";
contaNormal.NumeroAgencia = 35;
contaNormal.Titular = conta;

// System.Console.WriteLine($"O saldo da luana é {contaDaLuana.saldo}");

Console.WriteLine($"Titular da conta: {contaNormal.Titular.nome}"); // <== Acessando variavel dentro de Titular que tem link com ContaCorrente
Console.WriteLine($"Numero de Agência: {contaDoMatheus.NumeroAgencia}");
Console.WriteLine($"Saldo da conta: {contaDoMatheus.Saldo}");
Console.WriteLine($"Numero da conta: {contaDoMatheus.Conta}");

