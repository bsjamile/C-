using System;

class Calculator{

  public static int Sum(int sum1, int sum2){
    return sum1 + sum2;
  }

   public static int Sum(int sum1, int sum2, int sum3){
    return sum1 + sum2 + sum3;
  }

   public static int Sum(int sum1, int sum2, int sum3, int sum4){
    return sum1 + sum2 + sum3 + sum4;
  }

  public static int SumVet(int[] numbers){
    int sum = 0;
    for(int i = 0; i < numbers.Length; i++){
      sum += numbers[i];
    }
    return sum;
  }

  public static int SumVetP(params int[] numbers){
    int sum = 0;
    for(int i = 0; i < numbers.Length; i++){
      sum += numbers[i];
    }
    return sum;
  }

}

