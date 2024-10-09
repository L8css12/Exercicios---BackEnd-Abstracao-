using Atv___04;

Carro carro1 = new Carro("Bmw", "320i", 90);
Carro carro2 = new Carro("Mercedes - benz", "c300", 95);
Carro carro3 = new Carro("Audi", "Q7", 80);


Console.WriteLine($"A marca do primeiro carro é: {carro1.Marca}, O modelo é: {carro1.Modelo} e a velocidade é de: {carro1.Velocidade}");
Console.WriteLine($"A marca do primeiro carro é: {carro2.Marca}, O modelo é: {carro2.Modelo} e a velocidade é de: {carro2.Velocidade}");
Console.WriteLine($"A marca do primeiro carro é: {carro3.Marca}, O modelo é: {carro3.Modelo} e a velocidade é de: {carro3.Velocidade}");

carro1.acelerar();
carro1.desacelerar();
carro2.acelerar();
carro2.desacelerar();
carro3.acelerar();
carro3.desacelerar();

Console.ReadKey();