# Filas e Pilhas:

## Filas:

Filas em C# são declaradas da seguinte maneira:

```cs
    Queue<int> fila = new Queue<int>();
    fila.Enqueue(2);
    fila.Enqueue(4);
    fila.Enqueue(6);
    fila.Enqueue(8);

    foreach (int i in fila)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
    fila.Enqueue(10);
    foreach (int i in fila)
    {
        Console.WriteLine(i);
    }
```

Em uma fila, assim como na vida real, os elementos seguem uma ordem de chegada, ou seja: o **primeiro** elemento é o primeiro a sair, e o último, o último.

## Pilhas:

```cs
    Stack<int> pilha = new Stack<int>();
    pilha.Push(4);
    pilha.Push(6);
    pilha.Push(8);
    pilha.Push(10);

    foreach (int i in pilha)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
    
    pilha.Push(20);
    foreach (int i in pilha)
    {
        Console.WriteLine(i);
    }
```

As pilhas, por sua vez, são de forma contraria as filas. O **primeiro** elemento é o *último* a ser removido, e o **último**, o *primeiro*.