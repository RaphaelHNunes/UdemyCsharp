//// TIPOS DE DADOS VALOR
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

//string[] s = Console.ReadLine().Split(' ');
//string p1 = s[0];
//string p2 = s[1];
//string p3 = s[2];

//Console.WriteLine(p1);
//Console.WriteLine(p2);  
//Console.WriteLine(p3);

int n1 = int.Parse(Console.ReadLine());
char ch = char.Parse(Console.ReadLine());
float n2 = float.Parse(Console.ReadLine());

Console.WriteLine(n1);
Console.WriteLine(ch);  
Console.WriteLine(n2);

//string nome = Console.ReadLine();
//char sexo = char.Parse(Console.ReadLine());
//int idade = int.Parse(Console.ReadLine());
//double altura = double.Parse(Console.ReadLine());
//Console.Write(nome);
//Console.Write(sexo);
//Console.Write(idade);
//Console.Write(altura); 