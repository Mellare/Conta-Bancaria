using System;

public class Conta {
  
  public int numero;
  public double saldo;
  public int status;
  public int categoria;

  public Conta(int numero){
    this.numero = numero;
  }

  public void Creditar(double saldo){
    this.saldo = saldo;
    this.status = status;

    if(status != 1){
      Console.WriteLine("Conta Indisponível!");
    } else {
      
    //Comum
    if(saldo <= 50.000){
      this.categoria = 1;
    }
    //Especial
    if(saldo > 50.000){
      this.categoria = 2;
    }
    //VIP
    if(saldo > 100.000){
      this.categoria = 3;
     }    
    }
  }

  public void Debitar(double valor){
    this.saldo = saldo - valor;

    if(status != 1){
      Console.WriteLine("Conta Indisponível!");
    } else {
      if(saldo < 0){
        this.saldo = saldo - 10.0;
      }
      if(saldo >= 0){
        this.saldo = saldo - 0.0;
      }
    }
  }
}