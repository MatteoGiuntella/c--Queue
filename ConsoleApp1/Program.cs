
        // Inizializzo la queue con valori
        Queue<int> queue = new Queue<int>(new int[] { 1, 2, 3, 4 });

        // Rimuovo il primo elemento dalla coda
        int primoNumeroRimosso = queue.Dequeue();
        Console.WriteLine("Queue aggiornata:");
        foreach (int numero in queue)
        {
            Console.WriteLine(numero);
        }
