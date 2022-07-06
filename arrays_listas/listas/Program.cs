using System;
using System.Collections.Generic;

List<string> list2 = new List<string> {"Maria", "Alex", "Bob", "Ana"}; //instanciando lista e adicionando elementos à lista

foreach(string y in list2){
  Console.WriteLine(y);
}

Console.WriteLine("------------------");

List<string> list = new List<string>(); //lista instanciada e vazia

list.Add("Maria"); //O Add adiciona por padrão ao final da lista
list.Add("Alex");
list.Add("Bob");
list.Add("Ana");
list.Add("Jamile");
list.Add("Gab");
list.Add("Simone");
list.Insert(2,"Marco"); //O Insert você escolhe a posição que quer adicionar

foreach(string x in list){
  Console.WriteLine(x);
}
Console.WriteLine("------------------");
Console.WriteLine("");
Console.WriteLine($"Tamanho da lista: {list.Count}");

Console.WriteLine("------------------");

string s1 = list.Find(Test);

static bool Test(string s){
    return s[0] == 'A';
  }

Console.WriteLine($"First A: {s1}");

Console.WriteLine("------------------");

string s2 = list.Find(x => x[0] == 'A');

Console.WriteLine($"First A: {s2}"); //expressão lambda, função anônima

Console.WriteLine("------------------");

string s3 = list.FindLast(Test);

Console.WriteLine($"Último Elemento: {s3}");

Console.WriteLine("------------------");

string s4 = list.FindLast(x => x[0] == 'A');

Console.WriteLine($"Último Elemento: {s4}");

Console.WriteLine("------------------");

int s5 = list.FindIndex(l => l[0] == 'A');

Console.WriteLine($"First Position 'A': {s5}");

Console.WriteLine("------------------");

int s6 = list.FindLastIndex(l => l[0] == 'A');
Console.WriteLine($"Last Position 'A': {s6}");

Console.WriteLine("------------------");

List<string> list3 = list.FindAll(w => w.Length == 5);

foreach(string x in list3)
{
    Console.WriteLine($"{x} tem 5 caracteres");
}
Console.WriteLine("------------------");

list.Remove("Marco");

foreach(string newLista in list){
  Console.WriteLine(newLista);
}

Console.WriteLine("------------------");

list.RemoveAll(x => x[0] == 'M');

foreach(string XX in list){
  Console.WriteLine(XX);
}

Console.WriteLine("------------------");

list.RemoveAt(0);

foreach(string YY in list){
  Console.WriteLine(YY);
}

Console.WriteLine("------------------");

list.RemoveRange(2,3);

foreach(string a in list){
  Console.WriteLine(a);
}

