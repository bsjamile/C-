

for(int i=0; i<4; i++){
  Console.WriteLine("Digite um número: ");
  int x = int.Parse(Console.ReadLine());

  if(x<0){
        Console.WriteLine($"{x} é número é negativo!");
  }
  else if(x>0){
        Console.WriteLine($"{x} é um número positivo!");
  }
  else{
        Console.WriteLine($"{x} é 0!");
  }
}
