
// Mudando conteudo de uma classe

using bytebank;

ContaCorrente contaDoMatheus = new ContaCorrente();
contaDoMatheus.titular = "Matheus";
contaDoMatheus.numero_agencia = 22;
contaDoMatheus.saldo = 20000;
contaDoMatheus.conta = "228";

// Usando deposito
contaDoMatheus.Depositar(2000); // Sucesso!!
System.Console.WriteLine($"O meu saldo atual é: {contaDoMatheus.saldo}");

// Sacar
contaDoMatheus.Sacar(300);
System.Console.WriteLine($"Eu saquei 300 Reais agora meu saldo é: {contaDoMatheus.saldo}");

// Criação de outra conta 
ContaCorrente contaDaLuana = new ContaCorrente();
contaDaLuana.titular = "Luana";
contaDaLuana.numero_agencia = 29;
contaDaLuana.saldo = 0;
contaDaLuana.conta = "312";

// Tranferencia
contaDoMatheus.Tranferir(2000, contaDaLuana);

System.Console.WriteLine($"O saldo da luana é {contaDaLuana.saldo}");

System.Console.WriteLine($"Titular da conta: {contaDoMatheus.titular}");
System.Console.WriteLine($"Numero de Agência: {contaDoMatheus.numero_agencia}");
System.Console.WriteLine($"Saldo da conta: {contaDoMatheus.saldo}");
System.Console.WriteLine($"Numero da conta: {contaDoMatheus.conta}");

