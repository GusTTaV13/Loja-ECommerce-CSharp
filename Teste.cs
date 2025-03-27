using System;

public class Class1
{
	public Class1()
	{
	}
}
// See https://aka.ms/new-console-template for more information

String Nome = "Gustavo";
//Console.WriteLine(Nome);

void ExibirNome(string Nome)
{
    Console.WriteLine(Nome);
}

ExibirNome(Nome);

int Soma(int Numero1, int Numero2)
{
    return Numero1 + Numero2;
}

Console.WriteLine(Soma(1, 1));

int[] ListaNumeros = new int[5] { 1, 4, 9, 16, 25 };
void ExibirListaNumeros(int[] ListaNumeros)
{
    for (int i = 0; i < ListaNumeros.Length; i++)
    {
        Console.WriteLine(ListaNumeros[i]);
    }
}

ExibirListaNumeros(ListaNumeros);

