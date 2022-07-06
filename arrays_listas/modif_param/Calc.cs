class Calc{
  public static void Triple(ref int x){
    x = x * 3;
  }

  public static void Mult(int origin, out int final){
    final = origin * 3;
  }
}