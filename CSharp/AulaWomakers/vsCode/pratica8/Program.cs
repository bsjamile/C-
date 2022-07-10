Console.Write("Digite uma palavra: ");
var minhaPalavra= Console.ReadLine();
var charArray= minhaPalavra.ToCharArray();
foreach(var cadaLetra in charArray){
  Console.WriteLine(cadaLetra);
}
Console.Write("Digite uma palavra: ");
string word = Console.ReadLine();
foreach(char letra in word){
  Console.WriteLine(letra);
}
