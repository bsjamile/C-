Console.WriteLine("Digite um numero");
var numeroStr= Console.ReadLine();

var numero= Convert.ToInt32(numeroStr);

for(int i= 0; i < numero; i++){
  Console.WriteLine($"olha aqui eu no loop -{i}");
}
