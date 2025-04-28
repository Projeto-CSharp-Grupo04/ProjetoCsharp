using System;

public class inclui_preferencial
{
    public void IncluiPreferencial(string nome)
    
        if (count<tamanhoFila)
        {
            inicio = (inicio - 1 + tamanhoFila) % tamanhoFila;
            fila[inicio] = nome;
            count++;
            Console.WriteLine("Cliente Preferencial {0} incluido na fila", nome);
        }
        else
{
    Console.WriteLine("Fila cheia! Não é possível adicionar clientes preferemc.");
}
    }
}
