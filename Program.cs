using DesafioPOO.Models;

// Testes com o Nokia
Nokia nokia = new Nokia("1234-5678", "Nokia G60", "123XYZ", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

// Testes com o iPhone
Iphone iphone = new Iphone("1234-5678", "iPhone 15 Pro", "123XYZ", 264);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");
