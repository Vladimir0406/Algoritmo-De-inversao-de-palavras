// Variaveis
String palavra, invertida = "";
int i;

// Entrada de dados
Console.WriteLine("informe uma palavra");
palavra = Console.ReadLine();

// estrutura de repetiçao
for (i = 0; i < palavra.Length;i++)
    invertida = palavra[i] + invertida ;

// Saida de dados
Console.WriteLine($"a palavra invertida é :{invertida}");
