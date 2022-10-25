using System {


  class Program {
    public static void main() {
      Triangulo t = new Triangulo();
      t.b = 10;
      t.h = 20;
    }
  }



  class Triangulo {
    public double b, h; // campos ou atributos
    public double CalcArea(); {
      double area = b * h / 2;
            
    }
    return area;
  }
}
