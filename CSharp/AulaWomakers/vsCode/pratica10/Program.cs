var minhaPalavra= Console.ReadLine();
var minhaPalavraArray= minhaPalavra.ToCharArray();

int i= 0;

do{
  Console.WriteLine(i + " - "+ minhaPalavraArray[i]);
  i++;
} while(i < minhaPalavraArray.Length);
