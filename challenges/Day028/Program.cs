﻿Console.WriteLine("Escolha um número de 1 a 2 para os vencedores:");
int vencedor = int.Parse(Console.ReadLine());

switch (vencedor)
{
    case 1:
        Console.WriteLine("Escolheu o número 1");
        break;

    case 2:
        Console.WriteLine("Escolheu o número 2");
        break;

    default:
        Console.WriteLine("Não contém esse número aqui");
        break;
}
