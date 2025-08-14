using DesafioPOO.Models;

Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 64);
Iphone iphone = new Iphone("987654321", "iPhone 12", "987654321098765", 128);
nokia.Ligar();
nokia.ReceberLigacao();
iphone.Ligar();
iphone.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
iphone.InstalarAplicativo("Instagram");
Console.WriteLine(nokia);
Console.WriteLine(iphone);