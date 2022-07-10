Console.WriteLine("Quantos números deseja digitar?");
int.TryParse(Console.ReadLine(), out int n);
string result;

for(int i = 0; i < n; i++){
  Console.WriteLine("Digite um número: ");
  int.TryParse(Console.ReadLine(), out int x);

  if(x < 0){
    result = "negativo";
  } 
  else if(x > 0){
    result = "positivo";
  }
  else{
    result = "zero";
  }
  Console.WriteLine($"{x} é número " + result);
}