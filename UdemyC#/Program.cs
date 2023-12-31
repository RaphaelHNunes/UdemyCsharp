﻿//// TIPOS DE DADOS VALOR
//bool completo = false;// VARIAVEL QUE RECEBE SOMENTE DOIS TIPOS DE VALOR
//char genero = 'F';
//char letra = '\u0041'; //CODIGO ENCONTRADO NA TABELA UNICODE. 
//byte n1 = 126;
//int n2 = 1000;
//int n3 = 2147483647;
//long n4 = 2147483647L; //# 
//float n5 = 4.5f;
//double n6 = 4.5;
//int n7 = int.MaxValue; //comando utilizado para saber o maximo que uma string pode receber.

////TIPOS DE DADOS REFERENCIA
//string nome = "Maria Green";
//object obj1 = "Alex Brown";

//Console.WriteLine(completo);
//Console.WriteLine(genero);
//Console.WriteLine(letra);
//Console.WriteLine(n1);
//Console.WriteLine(n2);
//Console.WriteLine(n3);
//Console.WriteLine(n4);
//Console.WriteLine(n5);
//Console.WriteLine(n6);
//Console.WriteLine(nome);
//Console.WriteLine(obj1);
//Console.WriteLine(n7);


// Placeholders, concatenação e interpolação 

//using System.Globalization;

//int idade = 32;
//double saldo = 10.4587;
//string nomes = "João";

////Foi utilizado o metodo Placeholders no exemplo a baixo : 
//Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nomes, idade, saldo);

////no exemplo abaixo, foi ultilizado a tecnica de interpolação:
//Console.WriteLine($"{nomes} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

////No exemplo abaixo, foi ultilizado a tecnica de concatenação: 
//Console.WriteLine(nomes + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais ");

//ENTRADA DE DADOS EM C#

// SPLIT : Uma função que recorta a string compondo oque esta em aspas simples. 
//VET: ESTRUTURA QUE CONTEM VARIOS DADOS. 

//string[] s = Console.ReadLine().Split(' ');
//string p1 = s[0];
//string p2 = s[1];
//string p3 = s[2];

//Console.WriteLine(p1);
//Console.WriteLine(p2);  
//Console.WriteLine(p3);

using System.Globalization;

//int n1 = int.Parse(Console.ReadLine());
//char ch = char.Parse(Console.ReadLine());
//float n2 = float.Parse(Console.ReadLine());
//Console.WriteLine(n1);
//Console.WriteLine(ch);
//Console.WriteLine(n2);

//string[] inf = Console.ReadLine().Split(' ');
//string nome = inf[0];
//char sexo = char.Parse(inf[1]);
//int idade = int.Parse(inf[2]);
//double altura = double.Parse(inf[3], CultureInfo.InvariantCulture);
//Console.WriteLine(nome);
//Console.WriteLine(sexo);
//Console.WriteLine(altura);
//Console.WriteLine(idade);

//---------------------------------------------------------------------------------------------------------------------------

//Console.WriteLine("Digite três numeros: ");
//int n1 = int.Parse(Console.ReadLine());
//int n2 = int.Parse(Console.ReadLine());
//int n3 = int.Parse(Console.ReadLine());

//if (n1 > n2 && n1 > n3)
//{
//    Console.WriteLine("Maior = " + n1);
//}
//else if (n2 > n3)
//{
//    Console.WriteLine("Maior = " + n2);
//}
//else
//{
//    Console.WriteLine("Maior = " + n3);
//}

//----------------------------------------------------------------------------------------------------------------------

//Console.Write("Digite um numero:");
//double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//while (n1 >= 0.0)
//{
//double raiz = Math.Sqrt(n1);
//Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
//    Console.Write("Digite outro numero:");
//    n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//}
//Console.WriteLine("NUMERO NEGATIVO");

//-----------------------------------------------------------------------------------------------------------------------

//Console.Write("Quantos numeros inteiros voce vai somar? ");
//int r = int
//    .Parse(Console.ReadLine());

//int soma = 0;
//for (int i = 1; i <= r; i++)
//{
//    Console.Write("Valor #{0}: ", i);
//    int valor = int
//        .Parse(Console
//        .ReadLine());
//    soma = soma + valor; // ou soma += valor
//}
//Console.WriteLine("Soma = " + soma );

//Nesta atividade foi criada um exemplo de estrutura FOR

//------------------------------------------------------------------------------------------------------------------------

