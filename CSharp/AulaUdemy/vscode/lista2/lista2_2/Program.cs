Console.WriteLine("Quantos números deseja digitar?");
int.TryParse(Console.ReadLine(), out int n);

for(int i = 0; i < n; i++){
  Console.WriteLine("Digite um número: ");
  int.TruParse(Console.ReadLine(), out int x);

  string result;

  if(x % 2 == 0){
    result = "PAR!";
  } 
  else{
    result = "ÍMPAR!";
  }
  Console.WriteLine($"{x} é " + result);
}