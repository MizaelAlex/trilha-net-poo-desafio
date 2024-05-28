using DesafioPOO.Models;

// Criando uma instância de Nokia e demonstrando suas funcionalidades
Console.WriteLine("Smartphone Nokia.");
Smartphone nokia = new Nokia(numero: "778692312", modelo: "Z360", imei: "29910", memoria: 128);
nokia.Ligar();//Simulando ação de ligar
nokia.ReceberLigacao();//Simulando ação de receber uma ligação
nokia.InstalarAplicativo("");//Simulando a instalação de um aplicativo

// Criando uma instância de Iphone e demonstrando suas funcionalidades
Console.WriteLine("Smartphone Iphone.");
Smartphone iphone = new Iphone(numero: "890312231", modelo: "C3", imei: "8834", memoria: 256);
iphone.Ligar();//Simulando ação de ligar
iphone.ReceberLigacao();//Simulando ação de receber uma ligação
iphone.InstalarAplicativo("");//Simulando a instalação de um aplicativo