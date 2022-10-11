
// Mudando conteudo de uma classe

using bytebank;

ContaCorrente contaDoMatheus = new ContaCorrente();
contaDoMatheus.titular = "Matheus";
contaDoMatheus.numero_agencia = 22;
contaDoMatheus.saldo = 20000;
contaDoMatheus.conta = 228.ToString();

// Usando deposito
contaDoMatheus.Depositar(2000); // Sucesso!!
System.Console.WriteLine($"O meu saldo atual é: {contaDoMatheus.saldo}");

// Sacar
contaDoMatheus.Sacar(300);
System.Console.WriteLine($"Eu saquei 300 Reais agora meu saldo é: {contaDoMatheus.saldo}");

System.Console.WriteLine($"Titular da conta: {contaDoMatheus.titular}");
System.Console.WriteLine($"Numero de Agência: {contaDoMatheus.numero_agencia}");
System.Console.WriteLine($"Saldo da conta: {contaDoMatheus.saldo}");
System.Console.WriteLine($"Numero da conta: {contaDoMatheus.conta}");

