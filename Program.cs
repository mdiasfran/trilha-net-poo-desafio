using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Nokia");

Smartphone nokia = new Nokia("489526352", "2280", "320098452136", 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Jogo da cobrinha");

Console.WriteLine("Iphone");

Smartphone iphone = new Iphone("2156894265", "15", "08000215487454", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");