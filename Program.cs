using System.ComponentModel;
using DesafioPOO.Models;

// Implementado!

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "99797-0001", modelo: "C01 Plus", imei: "000005241000365", memoria: 32 );

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");
Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "99747-0002", modelo: "5c", imei: "111111111152365", memoria: 8 );
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");