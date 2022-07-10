/*
Leia uma palavra
Imprima a palavra na vertical usando foreach
*/
Console.WriteLine("Digite uma palavra");
var palavra = Console.ReadLine();
var palavraCharArray = palavra.ToCharArray();
string palavraInvertida = "";
for (int i = palavra.Length - 1; i >= 0; i--)
{
    palavraInvertida += palavraCharArray[i];
}
Console.WriteLine(palavraInvertida);