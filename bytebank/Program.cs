
// Mudando conteudo de uma classe

using bytebank;
using bytebank.Titular;
using bytebank.Contas;

ContaCorrente contaDoMatheus = new ContaCorrente(
    22, "228-X"
    );
// contaDoMatheus.titular = "Matheus";
contaDoMatheus.NumeroAgencia = 22;

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
conta.Nome = "Matheus";
conta.Cpf = "56020676803";
conta.Profissao = "Arquiteto";

ContaCorrente contaNormal = new ContaCorrente(35, "10x2");
contaNormal.Saldo = 200;
contaNormal.Titular = conta;

// System.Console.WriteLine($"O saldo da luana é {contaDaLuana.saldo}");

Console.WriteLine($"Titular da conta: {contaNormal.Titular.Nome}"); // <== Acessando variavel dentro de Titular que tem link com ContaCorrente
Console.WriteLine($"Numero de Agência: {contaDoMatheus.NumeroAgencia}");
Console.WriteLine($"Saldo da conta: {contaDoMatheus.Saldo}");
Console.WriteLine($"Numero da conta: {contaDoMatheus.Conta}");

Console.WriteLine(" ");
Console.WriteLine("//------------//----------------//----------------//");
// Assim que você acessa o metodo da classe não do objeto (static / statico)
Console.WriteLine($"O total de contas criadas até agora é: {ContaCorrente.TotalDeContasCriadas}");
Console.WriteLine("//------------//----------------//----------------//");

