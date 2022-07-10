using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Endereco
{
    public string logradouro;
    public int numero;
    public string complemento;

    public Endereco(string logradouro, int numero, string complemento = "")
    {
        this.logradouro = logradouro;
        this.numero = numero;
        this.complemento = complemento;
    }

    public override string ToString()
    {
        if (complemento == null || complemento.Length == 0)
            return $"Endereco:{logradouro}, {numero}";
        return $"Endereco:{logradouro}, {numero} complemento: {complemento}";
    }
}