// /* DESAFIO 01
// 1. Insira uma palavra ou texto
// 2. Verifique se e um palindromo
// 3. Conte quantas letras faltam para que se torne um palindromo
// 4. A resposta deve ser no formato {TRUE - 0} ou {FALSE - 1}, {FALSE - 2}, etc.
// */

// //Solução Ingrid

// Console.Write("Digite o conteúdo a ser verificado: ");
// string content = Console.ReadLine();

// // Quantidade de alterações que faltam para ser um palíndromo:
// int numChanges = 0;

// for (int ltr = 0, rtl = content.Length - 1; ltr < rtl; ltr++, rtl--) {
//     if (content[ltr] != content[rtl]) {
//         numChanges++;
//     }
// }

// // Verificação se é ou não é palíndromo:
// string palindromo;
// if (numChanges == 0) {
//     palindromo = "TRUE";
// } else {
//     palindromo = "FALSE";
// }

// // Exibição de resultado no console:
// Console.WriteLine($"{palindromo} - {numChanges}");

// //-------------------------------------------------------------------

// // Minha solução
// string palavra = Console.ReadLine();

// string palavraInvertida = "";
// int tamanhoPalavra = palavra.Length;
// int invert = palavra.Length - 1; 

// for (int i = 0; i < tamanhoPalavra; i++)
// {
//     palavraInvertida += palavra[invert - i].ToString();
// }

// }

// string verificacao;
// if (palavra == palavraInvertida)
// {
//     verificacao = "TRUE";
// }
// else
// {
//     verificacao = "FALSE";
// }
// Console.WriteLine($"{verificacao} - {mudancas}");
    
// //  -------------------------------


// string palavra = Console.ReadLine();
// string palavraInvertida = new string(palavra.Reverse().ToArray());
// bool result = palavra.Equals(palavraInvertida);

// int contador = 0;

// for (int i = 0; i <= palavra.Length - 1; i++)
// {
//     char letra = palavra[i];
//     char letraInvertida = palavraInvertida[i];

//     if (letra != letraInvertida)
//     {
//         contador+=1;
//     }
// }

// string uuper = result.ToString().ToUpper();

// Console.WriteLine($"{uuper} - {contador}");





















string palavra = Console.ReadLine();
string palavraInvertida = new string(palavra.Reverse().ToArray());
bool result = palavra.Equals(palavraInvertida);

int contador = 0;
for (int normal = 0; normal < invert; normal++, invert--)
{
    if (palavra[normal] != palavra[invert])
    {
        contador++;
    }
}

Console.WriteLine($"{result} - {contador}");