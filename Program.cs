// Faça um programa que implemente o meme Fluxograma da Engenharia.
Console.WriteLine("--- Fluxograma Da Engenharia ---");

Console.Write("O objetivo está se movendo (S/N)? ");
string movendo = Console.ReadLine()!;

if (movendo == "S") {
    Console.Write("Deveria? (S/N) ");
    String deveria = Console.ReadLine()!;

    if (deveria == "S") {
        Console.WriteLine("ÓTIMO ");
    } else if (deveria == "N") {
        Console.WriteLine("Use Silver Tape. ");
    } else {
        Console.WriteLine("Opção Inválida!");
    }
}
else if (movendo == "N") {
    Console.Write("Deveria? (S/N) ");
    string deveria = Console.ReadLine()!;

    if (deveria == "S") {
        Console.WriteLine("Use WD-40. ");
    } else if (deveria == "N") {
        Console.WriteLine("Ótimo! ");
    }else {
        Console.WriteLine("opção inválida! ");
    }
} else {
    Console.WriteLine("Opção inválida! ");
}




