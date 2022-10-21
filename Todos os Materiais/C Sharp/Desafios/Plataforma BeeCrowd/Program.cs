




// double nota1 = double.Parse(Console.ReadLine());
// double nota2 = double.Parse(Console.ReadLine());

// double media = ((3.5*nota1)+(7.5*nota2))/(3.5+7.5);

// Console.WriteLine($"MEDIA = {media.ToString("0.00000")}");





// double nota1 = double.Parse(Console.ReadLine());
// double nota2 = double.Parse(Console.ReadLine());
// double nota3 = double.Parse(Console.ReadLine());

// double media = (0.2*nota1)+(0.3*nota2)+(0.5*nota3);

// Console.WriteLine($"MEDIA = {media.ToString("0.0")}");



// string[] ABS = Console.ReadLine().Split(' ');

// int A = Convert.ToInt32(ABS[0]);
// int B = Convert.ToInt32(ABS[1]);
// int C = Convert.ToInt32(ABS[2]);

// int maiorAB = (A+B+(Math.Abs(A-B)))/2;

// int maiorABC = (maiorAB+C+(Math.Abs(maiorAB-C)))/2;

// Console.WriteLine($"{maiorABC} eh o maior");



// string[] ABC = Console.ReadLine().Split(' ');

// double A = Convert.ToDouble(ABC[0]);
// double B = Convert.ToDouble(ABC[1]);
// double C = Convert.ToDouble(ABC[2]);

// double calculo = ((B*B)-(4*A*C));

// if(calculo <= 0 || A == 0 )
// {
//     Console.WriteLine("Impossivel calcular");
//     return;
// }

// double delta = Math.Sqrt(calculo);

// double R1 = (-B+delta)/(2*A);
// double R2 = (-B-delta)/(2*A);

// Console.WriteLine($"R1 = {R1.ToString("0.00000")}");
// Console.WriteLine($"R2 = {R2.ToString("0.00000")}");








// string[] valores = Console.ReadLine().Split(' ');

// double A = Convert.ToDouble(valores[0]);
// double B = Convert.ToDouble(valores[1]);
// double C = Convert.ToDouble(valores[2]);
// double pi = 3.14159; 

// double areaTriangulo = (A*C)/2;
// double areaCirculo = pi*(Math.Pow(C,2));
// double areaTrapezio = ((A+B)*C)/2;
// double areaQuadrado = B*B;
// double areaRetangulo = (A*B);

// Console.WriteLine($"TRIANGULO: {areaTriangulo.ToString("0.000")}");
// Console.WriteLine($"CIRCULO: {areaCirculo.ToString("0.000")}");
// Console.WriteLine($"TRAPEZIO: {areaTrapezio.ToString("0.000")}");
// Console.WriteLine($"QUADRADO: {areaQuadrado.ToString("0.000")}");
// Console.WriteLine($"RETANGULO: {areaRetangulo.ToString("0.000")}");







// int quantidadeDeDias = int.Parse(Console.ReadLine());

// int umAno = 365;
// int umMes = 30;

// if(quantidadeDeDias > 365)
// {
//     int anos = (quantidadeDeDias/umAno);
//     int meses = ((quantidadeDeDias-(anos*umAno))/umMes);
//     int dias = ((quantidadeDeDias-(anos*umAno))-(meses*umMes));

//     Console.WriteLine($"{anos.ToString("0")} ano(s)");
//     Console.WriteLine($"{meses.ToString("0")} mes(es)");
//     Console.WriteLine($"{dias.ToString("0")} dia(s)");
// }
// else if (quantidadeDeDias < 365)
// {
//     int anos = 0;
//     int meses = (quantidadeDeDias/umMes);
//     int dias = (quantidadeDeDias-(meses*umMes));
//     Console.WriteLine($"{anos.ToString("0")} ano(s)");
//     Console.WriteLine($"{meses.ToString("0")} mes(es)");
//     Console.WriteLine($"{dias.ToString("0")} dia(s)");
// }
// else if(quantidadeDeDias <= 30)
// {
//     int anos = 0;
//     int meses = 0;    
//     Console.WriteLine($"{anos.ToString("0")} ano(s)");
//     Console.WriteLine($"{meses.ToString("0")} mes(es)");
//     Console.WriteLine($"{quantidadeDeDias.ToString("0")} dia(s)");    
// }








// double distanciaTotal = double.Parse(Console.ReadLine());
// double gasolinaUsada = double.Parse(Console.ReadLine());

// double consumoMedio = distanciaTotal/gasolinaUsada;

// Console.WriteLine($"{consumoMedio.ToString("0.000")} km/l");








// double horaViagem = double.Parse(Console.ReadLine());
// double velocidadeMedia = double.Parse(Console.ReadLine());

// double kmRodados = velocidadeMedia*horaViagem;

// double litrosGasolina = kmRodados/12;

// Console.WriteLine($"{litrosGasolina.ToString("0.000")}");







// double R = double.Parse(Console.ReadLine());;

// double pi = 3.14159;

// double volume = (Math.Pow(R, 3))*(4.0/3)*(pi);

// Console.WriteLine($"VOLUME = {volume.ToString("0.000")}");






// string[] dadosProduto1 = Console.ReadLine().Split(' ');
// string[] dadosProduto2 = Console.ReadLine().Split(' ');

// double quantidadeProduto1 = double.Parse(dadosProduto1[1]);
// double quantidadeProduto2 = double.Parse(dadosProduto2[1]);
// double valorProduto1 = double.Parse(dadosProduto1[2]);
// double valorProduto2 = double.Parse(dadosProduto2[2]);

// double valorDaCompra = (quantidadeProduto1*valorProduto1) + (quantidadeProduto2*valorProduto2);

// Console.WriteLine($"VALOR A PAGAR: R$ {valorDaCompra.ToString("0.00")}");






// int cabelo = 100;
// int bunda = 0;

// Console.WriteLine("Deseja cortar o cabelo?");
// Console.WriteLine("Digite sim ou não: ");
// Console.ReadLine();

// bool sim = true;

// if(sim)
// {
// cabelo -= cabelo;
// bunda += bunda;
// }
// else
// {
// Console.WriteLine($"hidratação");
// }





// using System.Globalization;


// string[] p1 = Console.ReadLine().Split(' ');

// double x1 = double.Parse(p1[0]);
// double y1 = double.Parse(p1[1]);

// string[] p2 = Console.ReadLine().Split(' ');

// double x2 = double.Parse(p2[0]);
// double y2 = double.Parse(p2[1]);

// double parte1 = Math.Pow(x2-x1, 2);
// double parte2 = Math.Pow(y2-y1, 2);

// double Distancia = Math.Sqrt(parte1 + parte2);

// Console.WriteLine($"{Distancia.ToString("0.0000")}");



// int A = int.Parse(Console.ReadLine());
// int B = int.Parse(Console.ReadLine());

// int resultado = A + B;

// Console.WriteLine($"X = {resultado}");




// double pi = 3.14159, r;

// r = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine(r);

// Console.WriteLine("A=" + (pi * (r * r)).ToString("0.0000"));



// double R = double.Parse(Console.ReadLine());
// // Console.WriteLine(R);

// double pi = 3.14159;

// double A = (pi*(R*R));

// Console.WriteLine($"A={A.ToString("0.0000")}");




// // int A = int.Parse(Console.ReadLine());
// // int B = int.Parse(Console.ReadLine());
// // int soma = A+B;
// // Console.WriteLine($"SOMA = {soma}");


// int A = int.Parse(Console.ReadLine());
// int B = int.Parse(Console.ReadLine());
// int C = int.Parse(Console.ReadLine());
// int D= int.Parse(Console.ReadLine());

// int DIFERENCA = (A*B-C*D);

// Console.WriteLine($"DIFERENCA = {DIFERENCA}");



// double number = double.Parse(Console.ReadLine());

// double hours = double.Parse(Console.ReadLine());
// double workedHours = double.Parse(Console.ReadLine());

// double salary = hours*workedHours;

// Console.WriteLine($"NUMBER = {number}");
// Console.WriteLine($"SALARY = U$ {salary.ToString("0.00")}");



// string name = Console.ReadLine();

// double FixedSalary = double.Parse(Console.ReadLine());
// double valueSold = double.Parse(Console.ReadLine());

// double bonusSalary = valueSold*(0.15);

// double bonusPlusSalary = FixedSalary+(bonusSalary);

// Console.WriteLine($"TOTAL = R$ {bonusPlusSalary.ToString("0.00")}");



