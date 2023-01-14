using System.Runtime.InteropServices;

Console.WriteLine("***** Testes com .NET 7 | Nanossegundos e Microssegundos *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName}- Kernel: {Environment
    .OSVersion.VersionString}");

var momento1 = DateTime.Now;
ExibirInfoMomento(momento1, "Primeiro momento");

Console.WriteLine();
Console.WriteLine("Aguardar 500 mil microssegundos...");
Thread.Sleep(TimeSpan.FromMicroseconds(500_000));

var momento2 = DateTime.Now;
ExibirInfoMomento(momento2, "Segundo momento");

void ExibirInfoMomento(DateTime momento, string mensagem)
{
    Console.WriteLine();
    Console.WriteLine($"--- {mensagem} ---");
    Console.WriteLine($"Horario: {momento.Hour:00}:{momento.Minute:00}:{momento.Second:00}");
    Console.WriteLine($"  + Milissegundos: {momento.Millisecond}");
    Console.WriteLine($"  + Nanossegundos: {momento.Nanosecond}");
    Console.WriteLine($"  + Microssegundos: {momento.Microsecond}");
}