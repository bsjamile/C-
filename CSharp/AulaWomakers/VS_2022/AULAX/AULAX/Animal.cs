using System;

/*
Crie uma classe chamada animal
Com o atributo tipoDoAnimal que é uma string
Crie um construtor que receba o tipoDoAnimal como parâmetro
Crie um método chamado SomDoAnimal que não retorna nada, mas imprime:
"AuAu" se o tipoDoAnimal for cachorro
"Miau" se o tipoDoAnimal for gato
"QuacQuac" se o tipoDoAnimal for pato
"PiuPiu" se o tipoDoAnimal for passaro
"eita, não sei qual o som desse animal" se o tipoDoAnimal não for nenhum dos anteriores
 */

class Animal
{
    public string tipoDoAnimal;//atributo
    public string Animal(string tipo);
    {
        this.tipoDoAnimal = tipo;
    }
}