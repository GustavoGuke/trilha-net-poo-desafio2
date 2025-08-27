using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("123", "Nokia", "1234", 32);
Iphone iphone = new Iphone("456", "Iphone", "4567", 64);

nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

iphone.ReceberLigacao();
iphone.InstalarAplicativo("Spotify");