using DesafioPOO.Models;

Smartphone nokia = new Nokia("11999990000", "Nokia Brick", "123456789012345", 128);
Smartphone iphone = new Iphone("11988887777", "iPhone 15", "987654321098765", 256);

Console.WriteLine("=== Teste Nokia ===");
Console.WriteLine($"Numero: {nokia.Numero}");
Console.WriteLine($"Modelo: {nokia.Modelo}");
Console.WriteLine($"IMEI: {nokia.IMEI}");
Console.WriteLine($"Memoria: {nokia.Memoria}GB");
nokia.InstalarAplicativo("WhatsApp");
nokia.Ligar();

Console.WriteLine();
Console.WriteLine("=== Teste iPhone ===");
Console.WriteLine($"Numero: {iphone.Numero}");
Console.WriteLine($"Modelo: {iphone.Modelo}");
Console.WriteLine($"IMEI: {iphone.IMEI}");
Console.WriteLine($"Memoria: {iphone.Memoria}GB");

iphone.InstalarAplicativo("Instagram");
iphone.ReceberLigacao();
