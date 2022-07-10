Console.Write("Quantos vezes? ");
int.TryParse(Console.ReadLine(), out int n);

string result = "";

for (int i = 0; i < n; i++)
{
  Console.Write("Digite o x: ");
  float.TryParse(Console.ReadLine(), out float x);

  Console.Write("Digite o y: ");
  float.TryParse(Console.ReadLine(), out float y);

  if ((x > 0) && (y > 0))
  {
      result = "Q1";
  }
  else if ((x < 0) && (y > 0))
  {
      result = "Q2";
  }
  else if ((x < 0) && (y < 0))
  {
      result = "Q3";
  }
  else if ((x == 0) && (y == 0))
  {
      result = "Origem";
  }
  else if (x == 0.0) 
  {
      result = "Eixo Y";
  }
  else if (y == 0.0) 
  {
      result = "Eixo X";
  }
  else
  {
      result = "Q4";
  }
  Console.WriteLine(result);
}
