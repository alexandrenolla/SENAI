using aulas.Classes;
Carro carro1 = new Carro();

carro1.cor = "Azul Marinho";
carro1.marca = "Mercedez-Benz";
carro1.modelo = "Maybach AMG";
carro1.tipoCarro = TipoCarroEnum.PREMIUM;

Carro carro2 = new Carro();

carro2.cor = carro1.cor;

Console.WriteLine(carro1.cor);
Console.WriteLine(carro1.tipoCarro);
Console.WriteLine(carro2.cor);

Carro carro3 = new Carro();
carro3.cor = "Vermelho";
// carro3.cor substituído pelo default do AlterarCor:
carro3.AlterarCor();

Console.WriteLine(carro3.cor);

// -------------------------------
Calculadora calculadora = new Calculadora();

// calculadora.numero1 = 5;
// calculadora.numero2 = 10;

Console.WriteLine(calculadora.Somar(5,10));
Console.WriteLine(calculadora.Multiplicar(5,10));
Console.WriteLine(calculadora.Multiplicar(calculadora.Somar(5,10), 2));



