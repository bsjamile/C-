using System.Globalization;

Console.WriteLine("Quantos produtos deseja verificar? ");
int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++){

Console.WriteLine("Digite o código e a quantidade do seu produto (na mesma linha): ");
string[] cod = Console.ReadLine().Split(' ');

int cod1 = int.Parse(cod[0]);
int qtd = int.Parse(cod[1]);

float valor = 0f, total;

if(cod1 <= 0 || cod1 > 5){
  Console.WriteLine("Digite um Código Válido: de 1 a 5");
}

else{

if(cod1 == 1){
valor = 4f;
}
else if(cod1 == 2){
  valor = 4.5f;
}
else if(cod1 == 3){
  valor = 5f;
}
else if(cod1 == 4){
  valor = 2f;
}
else (cod1 == 5){
  valor = 1.5f;
}
  total = qtd * valor;

  Console.WriteLine($"Total: R${total.ToString("F2", CultureInfo.InvariantCulture)}");
  }
}
