﻿using amem.models;




int numero = 5;

contador 3 blocos. no primeiro a declaração da variavel 
segundo: a condição de parada.
terceiro: e enquanto meu contador vai ser considerado, nesse caso foi incrementado em 1.
for(int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
}







// Calculadora calc = new Calculadora();

// calculo 01
// Math.Round arredondar
// int numero = 10;


// numero ++;
// Console.WriteLine("incrementando o 10");
// Console.WriteLine(numero);


// // numero = numero + 1; = 11 ambos iguais a numero ++; = 11

// int numerodecremento = 20;
// numerodecremento --;
// Console.WriteLine(numerodecremento);
// Console.WriteLine("decrementando");

// calc.Raiz(9);

// ------------------------------------------



// Calculos 00
// calc.Somar(10, 30);
// calc.Subtrair(10, 50); = -40
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);

// calc.Potencia(3, 3);


// calc.Seno(30);   = Seno de 30° = 0,49999999999999994 usando o comando {Math.Round(seno, 4)} em que seno = variável e 4 digitos 
// calc.Seno(30);
// calc.Coseno(30);    
// calc.Tangente(30);




// --------------------------------------------------------------------


// Operador NOT 0

// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar outro dia");
// }

// Obs: Se não choveu e nao esta tarde vou pedalar. 
// !inverte

// operador seguro tryparse aceita null

// --------------------------------------------------------------------

// Operador And &&
// No caso do && Se uma falhar as 2 falham
// validação

// bool possuiPresencaMinima = true;
// double media = 7.5;
// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado");
// }
// else
// {
//     Console.WriteLine("Reprovado");
// }

// Obs: No caso do && Se uma falhar as 2 falham

// https://drive.google.com/file/d/1ofWoOF1kjrWzNSSJZkohvGkx66ENiFbI/view

// ----------------------------------------------------------------

// OPERADOR OR- PIPE 0

// bool ehMaiorDeIdade = false;
// bool possuiAutorizacaoDoResponsavel = false;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada!");
// }
// else
// {
//     Console.WriteLine("entrada não liberada!");
// }

// Obs: false / false = entrada não liberada
// true/false liberada.

// || = Pipe ou/OR 

// ---------------------------------------------------------------



// switch 3 REAL 
// Alternativa para muitos ifs 


// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();



// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("vogal");
//         break; -> parar sua execução. sai do switch
//         default:
//         Console.WriteLine("não é uma vogal");
//         break;
// }





// switch CASO 2

// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();


// if (letra == "a" ||

// letra == "e" ||

// letra == "i" ||

// letra == "o" ||

// letra == "u")
// {
//     Console.WriteLine("é uma vogal");
// }
// else
// {
//     Console.WriteLine("não é uma vogal");
// }


// || PIPE SINAL DE VERIFICAÇÃO



// EXEMPLOS SWITCH CASE1

// Console.WriteLine("Digite uma letra.");
// string letra = Console.ReadLine();

// if (letra == "a")
// {
//     Console.WriteLine("vogal");
// }
// else if (letra == "e")
// {
//     Console.WriteLine("vogal");
// }
// else if (letra == "i")
// {
//     Console.WriteLine("vogal");
// }
// else if (letra == "o")
// {
//     Console.WriteLine("vogal");
// }
// else if (letra == "u")
// {
//    Console.WriteLine("vogal"); 
// }
// else
// {
//     Console.WriteLine("não é uma vogal");
// }

// R = "Digite uma letra" -> a = vogal.
// -------------------------------------------------------------------


// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"é possivel realizar a venda? : {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda invalida");
// }
// else if (possivelVenda)
// {
// Console.WriteLine("Venda realizada");
// }
// else
// {
    
// }

// DEPURAÇÃO -> Clica na bola ao lado esquerdo da linha. f5, e depois f5.  f10 avan~ça

// if (quantidadeCompra == 0); = comprar se o valor da direita '0' é = ao valor da esqueda 'quantidadeCompra'










// int a = 10;
// int b = 20;
// int c = a + b;
// c += 5;
// // c += 5; === c = c + 5;
// Console.WriteLine(c);

// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));
// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Denis";
// pessoa1.Idade = 26;
// pessoa1.Apresentar();
 
