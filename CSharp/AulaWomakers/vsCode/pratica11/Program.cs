//------------------DO WHILE---------------------------

// int soma = 0, numero;

// do{
//   Console.WriteLine("Digite um numero para somar ou 0 para sair");
//   int.TryParse(Console.ReadLine(), out numero);
//   soma += numero;
// } while(numero!= 0);

// Console.WriteLine(soma);

//--------------------WHILE--------------------------

int soma = 0, numero=1;

while(numero!= 0){
  Console.WriteLine("Digite um numero para somar ou 0 para sair");
  int.TryParse(Console.ReadLine(), out numero);
  soma += numero;
}
Console.WriteLine(soma);