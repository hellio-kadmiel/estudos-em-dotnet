//concatenacao de strings
 string numero1 = "10";
 string numero2 = "20";
 string resultado = numero1 + numero2;
 Console.WriteLine(resultado);




// // opcoes de formatacao
double porcentagem = .3232;

Console.WriteLine(porcentagem.ToString("P"));

 int numero = 1231234;
 Console.WriteLine(numero.ToString("##-##-##"));



// // representando moeda em texto
 decimal valorMonetario = 1282.40M;
 // o C com o numero diz quais casas decimais mostrará
Console.WriteLine(valorMonetario.ToString("C1"));