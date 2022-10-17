
// Mudando conteudo de uma classe

using bytebank;
using bytebank.Titular;
using bytebank.Contas;

ContaCorrente contaDoMatheus = new ContaCorrente();
// contaDoMatheus.titular = "Matheus";
contaDoMatheus.numero_agencia = 22;
contaDoMatheus.saldo = 20000;
contaDoMatheus.conta = "228";

// Usando deposito
contaDoMatheus.Depositar(2000); // Sucesso!!
Console.WriteLine($"O meu saldo atual é: {contaDoMatheus.saldo}");

// Sacar
contaDoMatheus.Sacar(300);
Console.WriteLine($"Eu saquei 300 Reais agora meu saldo é: {contaDoMatheus.saldo}");

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
contaNormal.saldo = 200;
contaNormal.conta = "10x2";
contaNormal.numero_agencia = 35;
contaNormal.titular = conta;

// System.Console.WriteLine($"O saldo da luana é {contaDaLuana.saldo}");

Console.WriteLine($"Titular da conta: {contaNormal.titular.nome}"); // <== Acessando variavel dentro de Titular que tem link com ContaCorrente
Console.WriteLine($"Numero de Agência: {contaDoMatheus.numero_agencia}");
Console.WriteLine($"Saldo da conta: {contaDoMatheus.saldo}");
Console.WriteLine($"Numero da conta: {contaDoMatheus.conta}");

