//Distância euclidiana entre dois pontos em um espaço 2D by Matheus Regis em C#
// Calcula a distância euclidiana entre dois pontos em um espaço 2D.
//ASSEMBLED: Microsoft Windows 11 with .NET 8.0 SDK installed on 17/10/2025 in Visual Studio 2022.
//Declarar Variáveis antes,lembrando que o usuario informara os dados
int number1x = 0;
int number1y = 0;
int number2x = 0;
int number2y = 0;
double distance = 0.0;
//Introdução do programa de console
Console.WriteLine("Bem vindo a calculadora de distância euclidiana entre dois pontos no plano cartesiano 2D em C#!\r");
Console.WriteLine("-----------------------------------------------------------------------------------------------\n");
//Solicitar ao usuário para informar as coordenadas do primeiro ponto
Console.WriteLine("Informe a coordenada X do primeiro ponto:");
number1x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe a coordenada Y do primeiro ponto:");
number1y = Convert.ToInt32(Console.ReadLine());
//Solicitar ao usuário para informar as coordenadas do segundo ponto
Console.WriteLine("Informe a coordenada X do segundo ponto:");
number2x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe a coordenada Y do segundo ponto:");
number2y = Convert.ToInt32(Console.ReadLine());
//Calcular a distância euclidiana entre os dois pontos
distance = Math.Sqrt(Math.Pow((number2x - number1x), 2) + Math.Pow((number2y - number1y), 2));
//Exibir o resultado ao usuário
Console.WriteLine("A distância euclidiana entre os pontos (" + number1y + "," + number1y + ") e (" + number2x + "," + number2y + ") é: " + distance);
//Finalizar o programa
Console.WriteLine("\nPressione qualquer tecla para sair.");
Console.ReadKey(true);