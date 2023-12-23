using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Testes SmartPhone Nokia!");
Nokia nokia = new("987654321","Nokia","222222222",200);
nokia.InstalarAplicativo("Discord");
nokia.Ligar("3213223");
nokia.ReceberLigacao("123123123");

Console.WriteLine("Testes Smartphone Iphone!");
Iphone iphone= new("1111111","Iphone","1111111",128);
iphone.InstalarAplicativo("gmail");
iphone.Ligar("1231321");
iphone.ReceberLigacao("321321");