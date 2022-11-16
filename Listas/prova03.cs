using System;

class Program {
  
}

class Cartas {
  private int carta;
  private string naipe;
  public void SetCarta(int carta) {
    if (carta > 0 && carta <=13) this.carta = carta;
    }
  public void SetNaipe(string naipe) {
    if (naipe == "ouro" || naipe == "copas" || naipe == "espadas" || naipe == "paus") this.naipe = naipe;
    }

  public override string ToString() {
    return $"A carta de valor {carta} é do naipe de {naipe}"
  }
}
