using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia Lumia 740: ");
Nokia nokiaLumia = new Nokia(numero:"(81)99955-6633",  modelo:"Nokia Lumia 740" , imei:"7-2989543698", memoria:32);
nokiaLumia.Ligar();
nokiaLumia.InstalarAplicativo("Facebook");
nokiaLumia.ReceberLigacao();

Console.WriteLine("\n");


Console.WriteLine("Smartphone Iphone 10: ");
Iphone iphone10 = new Iphone(numero: "(81)98844-5522", modelo:"Iphone 10 Plus", imei: "9-455865564", memoria:64);
iphone10.Ligar();
iphone10.InstalarAplicativo("Instagram");
iphone10.ReceberLigacao();
