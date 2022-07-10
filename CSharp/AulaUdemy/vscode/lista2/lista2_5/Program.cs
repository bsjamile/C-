using System.Globalization;

Console.WriteLine("Quantos produtos deseja verificar? ");
int.TryParse(Console.ReadLine(), out int n);

for(int i = 0; i < n; i++){

Console.WriteLine("Digite o código: ");
int.TryParse(Console.ReadLine(), out int cod);

Console.WriteLine("Digite a quantidade: ");
int.TryParse(Console.ReadLine(), out int qtd);

float valor = 0f, total;

if(cod == 1){
  valor = 4f;
}
else if(cod == 2){
  valor = 4.5f;
}
else if(cod == 3){
  valor = 5f;
}
else if(cod == 4){
  valor = 2f;
}
else if(cod == 5){
  valor = 1.5f;
}
else{
  Console.WriteLine("O código vai de 1 a 5");
}

  total = qtd * valor;

  Console.WriteLine($"Total: R${total.ToString("F2", CultureInfo.InvariantCulture)}");
}


