Console.WriteLine("Quantos números deseja digitar?");
int.TryParse(Console.ReadLine(), out int n );

for(int i = 0; i < n; i++){

  string result;

  Console.WriteLine("Digite um número: ");
  int.TryParse(Console.ReadLine(), out int x);

  Console.WriteLine("Digite outro número: ");
  int.TryParse(Console.ReadLine(), out int y);

  if((x % y == 0) || (y % x == 0)){
    result = "são múltiplos.";
  } 
  else{
      result = "não são múltiplos.";
  }
  Console.WriteLine($"{x} e {y} " + result)
}
