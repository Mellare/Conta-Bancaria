using System;

class Program {
  public static void Main (string[] args) {

    //Valores Fictícios
    var conta = new Conta(123456);
    conta.status = 1;
    conta.saldo = 500.00;
    
    //Método Creditar
    conta.Creditar(conta.saldo);
    Console.WriteLine("Categoria de Conta: " + conta.categoria);
    
    //Método Debitar
    conta.Debitar(10.00);
    Console.WriteLine("Saldo: " + conta.saldo);
      
  
  }
}