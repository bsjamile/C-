class Retangulo
{
    public double altura; //atributos
    public double largura; //atributos

    public Retangulo(double altura, double largura) //construtor
    { //método construto
        this.altura = altura;
        this.largura = largura;
    }

    public double Area()
    {
        return largura * altura;
    }

    public override string ToString()
    {
        return $"Com {altura} e {largura}, a área é {Area()}";
    }
}