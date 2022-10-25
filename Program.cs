using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// IMPLEMENTADO

Console.WriteLine("Smartphone Nokia:");
Nokia n1 = new Nokia("987654321", "5125", "102030405060708090", 512);
Console.WriteLine(n1.Numero);
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Firefox");

Console.WriteLine("\nSmartphone Iphone:");
Iphone i1 = new Iphone("876543210", "14", "203040506070809010", 1042);
Console.WriteLine(i1.Numero);
i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("GitHub");