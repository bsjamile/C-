using System;
class Pessoa
{
    public string nome;  //atributos
    public DateTime dataDeNascimento; //atributos
    public string email; //atributos
    public string sexo; //atributos
    public Pessoa(string nomeParm, DateTime dataDeNascimento, string email) //metodo construtor
    {
        nome = nomeParm;
        this.dataDeNascimento = dataDeNascimento;
        this.email = email;
    }
    public void TrocaSexo(string sexo)
    {
        this.sexo = sexo;
    }
    public int Idade() //metodo
    {
        return DateTime.Now.Year - dataDeNascimento.Year;
    }
    public override string ToString() //metodo
    {
        return $"{nome} - {dataDeNascimento} - {email}";
    }
}