using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
static void Main()
{
int procesadores = Environment.ProcessorCount;


    Console.WriteLine("Hola Mundo multihilo");
    Console.WriteLine($"Procesadores logicos disponibles: {procesadores}");

    ParallelOptions opciones = new ParallelOptions
    {
        MaxDegreeOfParallelism = procesadores
    };

    Parallel.For(0, 20, opciones, i =>
    {
        Console.WriteLine(
            $"Tarea {i} ejecutandose en el hilo {Thread.CurrentThread.ManagedThreadId}"
        );

        Thread.Sleep(500);
    });

    Console.WriteLine("Todas las tareas han completado.");
}


}
