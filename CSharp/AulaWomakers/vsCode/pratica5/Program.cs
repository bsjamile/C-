Console.WriteLine("Digite um numero");
var numeroAStr= Console.ReadLine();

Console.WriteLine("Digite um numero");
var numeroBStr= Console.ReadLine();

var numeroA= Convert.ToInt32(numeroAStr);
var numeroB= Convert.ToInt32(numeroBStr);

int multiplicacao= 0;

for(int i= 0; i< numeroB; i++){
  multiplicacao+= numeroA;
}
Console.WriteLine(multiplicacao);
