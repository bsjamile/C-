- Desafio Hacker Hank
Um palavra palíndroma é uma palavra que se lida de frente pra trás ou de trás pra frente é a mesma coisa. 
Por exemplo: AMA, ARARA, OVO, SOCOS. 
Podemos também ter números palíndromos, como por exemplo: 121, 11211, 98289, 8778.

Nesse desafio o que você deve fazer é: dada uma entrada, dizer se ela é palíndroma ou não, 
e quantas alterações nessa entrada precisam ser feitas pra ela se tornar uma palíndroma.

- Desafio Hacker Hank
Um palavra palíndroma é uma palavra que se lida de frente pra trás ou de trás pra frente é a mesma coisa. 
Por exemplo: AMA, ARARA, OVO, SOCOS. 
Podemos também ter numeros palíndromos, como por exemplo: 121, 11211, 98289, 8778.

Nesse desafio o que você deve fazer é: dada uma entrada, dizer se ela é palíndroma ou não, 
e quantas alterações nessa entrada precisam ser feitas pra ela se tornar uma palíndroma.


Importante: Número ou Strings

Console.WriteLine("Digite uma palavra");
var palavra = Console.ReadLine();

var palavraCharArray = palavra.ToCharArray();

string palavraInvertida = "";

for (int i = palavra.Length - 1; i >= 0; i--)
{
    palavraInvertida += palavraCharArray[i];
}
Console.WriteLine(palavraInvertida);


Console.WriteLine("Digite uma palavra: ");
var palavra = Console.ReadLine();


var minhaPalavra= Console.ReadLine();
var minhaPalavraArray= minhaPalavra.ToCharArray();

int i= 0;

do{
  Console.WriteLine(i + " - "+ minhaPalavraArray[i]);
  i++;
} while(i < minhaPalavraArray.Length);


int[] meuArrayDeInteiros= new int[5];
meuArrayDeInteiros[0] = 15;
meuArrayDeInteiros[1] = 251;
meuArrayDeInteiros[2] = 3123;
meuArrayDeInteiros[3] = 40;
meuArrayDeInteiros[4] = 554;

foreach(int meuInteiro in meuArrayDeInteiros){
  Console.WriteLine(meuInteiro);
}

Console.WriteLine("Digite uma palavra");
var palavra = Console.ReadLine();

var palavraCharArray = palavra.ToCharArray();

string palavraInvertida = "";

for (int i = palavra.Length - 1; i >= 0; i--)
{
    palavraInvertida += palavraCharArray[i];
}

Console.WriteLine(palavraInvertida);

