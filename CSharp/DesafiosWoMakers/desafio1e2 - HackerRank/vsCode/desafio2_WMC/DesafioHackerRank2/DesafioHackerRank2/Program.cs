using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
class Solution
{
    static void Main(String[] args)
    {
        Conversor conv = new Conversor();

        Console.Write("Qts ns: ");
        int qtd = int.Parse(Console.ReadLine());

        for (int u = 0; u < qtd; u++)
        {

            string[] line = Console.ReadLine().Split(' ');

            double v = double.Parse(line[1]);

            string convertido = Conversor.paraExtenso(v);




            Console.WriteLine(convertido);
        }


    }
    public class Conversor
    {
        public static string paraExtenso(double valor)
        {

            ulong limite = 18446744073709551615;

            if (valor < 0 || valor > limite)
            {
                return "valor nao suportado";
            }
            else
            {
                string escValor = valor.ToString("000000000000000000000.00");
                string extenso = string.Empty;

                for (int i = 0; i < 24; i += 3)
                {
                    extenso += escrevendo(decimal.Parse(escValor.Substring(i, 3)));
                    if (i == 0 & extenso != string.Empty)
                    {
                        if (Convert.ToInt32(escValor.Substring(0, 3)) == 1)
                            extenso += " QUINTILHAO" + ((decimal.Parse(escValor.Substring(3, 12)) > 0) ? "," : string.Empty);
                        else if (Convert.ToInt32(escValor.Substring(0, 3)) > 1)
                            extenso += " QUINTILHOES" + ((decimal.Parse(escValor.Substring(3, 12)) > 0) ? "," : string.Empty);
                    }

                    else if (i == 3 & extenso != string.Empty)
                    {
                        if (Convert.ToInt32(escValor.Substring(3, 3)) == 1)
                            extenso += " QUARTILHAO" + ((decimal.Parse(escValor.Substring(6, 9)) > 0) ? "," : string.Empty);
                        else if (Convert.ToInt32(escValor.Substring(3, 3)) > 1)
                            extenso += " QUARTILHOES" + ((decimal.Parse(escValor.Substring(6, 9)) > 0) ? "," : string.Empty);
                    }


                    else if (i == 6 & extenso != string.Empty)
                    {
                        if (Convert.ToInt32(escValor.Substring(6, 3)) == 1)
                            extenso += " TRILHAO" + ((decimal.Parse(escValor.Substring(9, 6)) > 0) ? "," : string.Empty);
                        else if (Convert.ToInt32(escValor.Substring(6, 3)) > 1)
                            extenso += " TRILHOES" + ((decimal.Parse(escValor.Substring(9, 6)) > 0) ? "," : string.Empty);
                    }
                    else if (i == 9 & extenso != string.Empty)
                    {
                        if (Convert.ToInt32(escValor.Substring(9, 3)) == 1)
                            extenso += " BILHAO" + ((decimal.Parse(escValor.Substring(12, 9)) > 0) ? "," : string.Empty);
                        else if (Convert.ToInt32(escValor.Substring(9, 3)) > 1)
                            extenso += " BILHOES" + ((decimal.Parse(escValor.Substring(12, 9)) > 0) ? "," : string.Empty);
                    }
                    else if (i == 12 & extenso != string.Empty)
                    {
                        if (Convert.ToInt64(escValor.Substring(12, 3)) == 1)
                            extenso += " MILHAO" + ((decimal.Parse(escValor.Substring(15, 12)) > 0) ? "," : string.Empty);
                        else if (Convert.ToInt64(escValor.Substring(12, 3)) > 1)
                            extenso += " MILHOES" + ((decimal.Parse(escValor.Substring(15, 12)) > 0) ? "," : string.Empty);
                    }
                    else if (i == 15 & extenso != string.Empty)
                        if (Convert.ToInt64(escValor.Substring(15, 3)) > 0)
                            extenso += " MIL" + ((decimal.Parse(escValor.Substring(18, 3)) > 0) ? " E " : string.Empty);

                    if (i == 18)
                    {
                        if (extenso.Length > 8)
                            if (extenso.Substring(extenso.Length - 6, 6) == "BILHAO" | extenso.Substring(extenso.Length - 6, 6) == "MILHAO")
                                extenso += " DE";
                            else
                                if (extenso.Substring(extenso.Length - 7, 7) == "BILHOES" | extenso.Substring(extenso.Length - 7, 7) == "MILHOES" | extenso.Substring(extenso.Length - 8, 7) == "TRILHOES" | extenso.Substring(extenso.Length - 9, 7) == "QUADRILHOES" | extenso.Substring(extenso.Length - 10, 7) == "QUINTILHOES")
                                extenso += " DE";
                            else
                                    if (extenso.Substring(extenso.Length - 8, 8) == "TRILHOES" | extenso.Substring(extenso.Length - 8, 8) == "QUARTILHOES" | extenso.Substring(extenso.Length - 9, 8) == "QUINTILHOES")
                                extenso += " DE";
                            else
                                    if (extenso.Substring(extenso.Length - 9, 9) == "QUARTILHOES" | extenso.Substring(extenso.Length - 9, 9) == "QUINTILHOES")
                                extenso += " DE";
                            else
                                    if (extenso.Substring(extenso.Length - 10, 10) == "QUINTILHOES")
                                extenso += " DE";

                        if (Convert.ToInt32(escValor.Substring(0, 21)) == 1)
                            extenso += " REAL";
                        else if (Convert.ToInt32(escValor.Substring(0, 21)) > 1)
                            extenso += " REAIS";

                        if (Convert.ToInt32(escValor.Substring(22, 2)) > 0 && extenso != string.Empty)
                            extenso += " E ";
                    }

                    if (i == 21)
                        if (Convert.ToInt32(escValor.Substring(22, 2)) == 1)
                            extenso += " CENTAVO";
                        else if (Convert.ToInt32(escValor.Substring(22, 2)) > 1)
                            extenso += " CENTAVOS";
                }
                return extenso;
            }
        }

        static string escrevendo(decimal valor)
        {
            if (valor <= 0)
                return string.Empty;
            else
            {
                string retorno = string.Empty;
                if (valor > 0 & valor < 1)
                {
                    valor *= 100;
                }
                string escValor = valor.ToString("000");
                int e = Convert.ToInt32(escValor.Substring(0, 1));
                int f = Convert.ToInt32(escValor.Substring(1, 1));
                int g = Convert.ToInt32(escValor.Substring(2, 1));

                if (e == 1) retorno += (f + g == 0) ? "CEM" : "CENTO";
                else if (e == 2) retorno += "DUZENTOS";
                else if (e == 3) retorno += "TREZENTOS";
                else if (e == 4) retorno += "QUATROCENTOS";
                else if (e == 5) retorno += "QUINHENTOS";
                else if (e == 6) retorno += "SEISCENTOS";
                else if (e == 7) retorno += "SETECENTOS";
                else if (e == 8) retorno += "OITOCENTOS";
                else if (e == 9) retorno += "NOVECENTOS";

                if (f == 1)
                {
                    if (g == 0) retorno += ((e > 0) ? " E " : string.Empty) + "DEZ";
                    else if (g == 1) retorno += ((e > 0) ? " E " : string.Empty) + "ONZE";
                    else if (g == 2) retorno += ((e > 0) ? " E " : string.Empty) + "DOZE";
                    else if (g == 3) retorno += ((e > 0) ? " E " : string.Empty) + "TREZE";
                    else if (g == 4) retorno += ((e > 0) ? " E " : string.Empty) + "QUATORZE";
                    else if (g == 5) retorno += ((e > 0) ? " E " : string.Empty) + "QUINZE";
                    else if (g == 6) retorno += ((e > 0) ? " E " : string.Empty) + "DEZESSEIS";
                    else if (g == 7) retorno += ((e > 0) ? " E " : string.Empty) + "DEZESSETE";
                    else if (g == 8) retorno += ((e > 0) ? " E " : string.Empty) + "DEZOITO";
                    else if (g == 9) retorno += ((e > 0) ? " E " : string.Empty) + "DEZENOVE";
                }
                else if (f == 2) retorno += ((e > 0) ? " E " : string.Empty) + "VINTE";
                else if (f == 3) retorno += ((e > 0) ? " E " : string.Empty) + "TRINTA";
                else if (f == 4) retorno += ((e > 0) ? " E " : string.Empty) + "QUARENTA";
                else if (f == 5) retorno += ((e > 0) ? " E " : string.Empty) + "CINQUENTA";
                else if (f == 6) retorno += ((e > 0) ? " E " : string.Empty) + "SESSENTA";
                else if (f == 7) retorno += ((e > 0) ? " E " : string.Empty) + "SETENTA";
                else if (f == 8) retorno += ((e > 0) ? " E " : string.Empty) + "OITENTA";
                else if (f == 9) retorno += ((e > 0) ? " E " : string.Empty) + "NOVENTA";

                if (escValor.Substring(1, 1) != "1" & g != 0 & retorno != string.Empty) retorno += " E ";

                if (escValor.Substring(1, 1) != "1")
                    if (g == 1) retorno += "UM";
                    else if (g == 2) retorno += "DOIS";
                    else if (g == 3) retorno += "TRES";
                    else if (g == 4) retorno += "QUATRO";
                    else if (g == 5) retorno += "CINCO";
                    else if (g == 6) retorno += "SEIS";
                    else if (g == 7) retorno += "SETE";
                    else if (g == 8) retorno += "OITO";
                    else if (g == 9) retorno += "NOVE";

                return retorno;
            }

        }

    }
}

