﻿using ExemploFundamentos.Common.Models;

//Instancia da classe pessoa
Pessoa p = new Pessoa();

// Atribui o nome e idade para pessoa
// passando o nome Bruno
// e passando a idade 30

/*
    Atribui o nome e idade para pessoa
    passando o nome Bruno
    e passando a idade 30
*/
p.Nome = "Bruno";
p.Idade = 30;

// Faz a pessoa se apresentar
p.Apresentar();

Calculadora c = new Calculadora();
c.Somar(3, 5);
c.Subtrair(3, 5);


// List<string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("BA");
// listaString.Add("MG");
// listaString.Add("RG");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Add("SC");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Remove("MG");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// Console.WriteLine("Percorrendo a lista com o FOR");
// for(int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
// }

// Console.WriteLine("Percorrendo a lista com o FOREACH");
// int contadorForeach = 0;
// foreach(string item in listaString)
// {
//     Console.WriteLine($"Posição Nº {contadorForeach} - {item}");
//     contadorForeach++;
// }




































// int[] arrayInteiros = new int[4];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;

// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);


// //Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);



// Console.WriteLine("Percorrendo o Array com o FOR");

// for(int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
// }
















// Console.WriteLine("Percorrendo o Array com o FOREACH");
// int contadorForeach = 0;
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição Nº {contadorForeach} - {valor}");
//     contadorForeach++;
// }


























// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Bruno";
// pessoa1.Idade = 20;
// pessoa1.Apresentar();


























// string opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;

//         case "2":
//             Console.WriteLine("Busca de cliente");
//             break;

//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;

//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirMenu = false;
//             break;

//         default:
//             Console.WriteLine("Opção inválida");
//             break;

//     }
// }

























// int soma = 0, numero = 0;

// do
// {
//     Console.WriteLine("Digite um número (0 para parar)");

//     soma += numero;
// } while(numero != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");


























// int numero = 5;
// int contador = 0;


// while (contador <= 10)
// {
//     Console.WriteLine($"{contador + 1} Execução: {numero} x {contador} = {numero * contador}");
//     contador++;

//     if(contador == 6)
//     {
//         break;
//     }


// }


























// int numero = 5;

// for(int contador = 0; contador <= 10; contador++) 
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }


































// Calculadora calc = new Calculadora();

// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RazQuadrada(9);


// int numeroIncremento = 10;

// Console.WriteLine(numeroIncremento);

// Console.WriteLine("Incrementando o 10");
// //numero = numero + 1;
// numeroIncremento++;

// int numeroDecremento = 20;
// Console.WriteLine("Decrementando o 20");
// //numero = numero + 1;
// numeroDecremento--;

// Console.WriteLine(numeroDecremento);































// bool choveu = false;
// bool estaTarde = false;

// if(!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar um outro dia");
// }



// bool possuiPresencaMinima = false;
// double media = 6.5;

// if(possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado");
// }
// else
// {
//     Console.WriteLine("Reprovado");
// }




// bool ehMaiorDeIdade = true;
// bool possuiAutorizacaoDoResponsavel = false;

// if(ehMaiorDeIdade || possuiAutorizacaoDoResponsavel) 
// {
//     Console.WriteLine("Entrada liberada!");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada");
// }






// Console.WriteLine("Digita uma letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;
// }









// if(letra == "a" ||
//    letra == "e" ||
//    letra == "i" ||
//    letra == "o" ||
//    letra == "u" )
//    {
//     Console.WriteLine("Vogal");
//    }
//    else
//    {
//     Console.WriteLine("Não é uma Vogal");
//    }



// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if(quantidadeCompra == 0) 
// {
//     Console.WriteLine("Venda inválida.");
// }

// else if(possivelVenda) 
// {
//     Console.WriteLine("Venda realizada.");
// }
// else
// {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
// }

















// string a = "15-";
// //int b = 0;

// int.TryParse(a, out int b);

// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!");

// double a = 4 / (2 + 2);

// Console.WriteLine(a);



// int a = 5;
// double b = a;

//int a = 5;
//long b = a;

//long a = long.MaxValue;
//int b = Convert.ToInt32(a);

// int a = int.MaxValue;
// long b = a;

// Console.WriteLine(b);








// int inteiro = 5;

// string a = inteiro.ToString();

// Console.WriteLine(a);










// cast - casting
//int a = Convert.ToInt32(null);
// int a = int.Parse(null);
// Console.WriteLine(a);



// int a = 10;
// int b = 20;

// int c = a + b;

//c = c + 5; // 30 + 5

//c += 5;

// c = c - 5
//c -= 5;

//Console.WriteLine(c);


// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

// string apresentacao = "Olá, seja bem vindo";

// int quantidade = 1;
// Console.WriteLine("Valor da variável quantidade: " + quantidade);

// quantidade = 10;
// Console.WriteLine("Valor da variável quantidade: " + quantidade);



/* double altura = 1.80;

decimal preco = 1.80m;
bool condicao = true; */

/* Console.WriteLine(apresentacao);
Console.WriteLine("Valor da varíavel quantidade: " + quantidade);
Console.WriteLine("Valor da varíavel altura: " + altura.ToString("0.00"));
Console.WriteLine("Valor da varíavel preco: " + preco);
Console.WriteLine("Valor da varíavel condicao: " + condicao); */


//Pessoa pessoa1 = new Pessoa();

//pessoa1.Nome = "Bruno";
//pessoa1.Idade = 26;
//pessoa1.Apresentar();

//Pessoa pessoaFIsicaRepresentacao = new Pessoa();