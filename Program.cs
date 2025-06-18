Console.WriteLine("--Aplicação: sorteando valores em uma lista");
string[] nomes = ["O Zumbi", "O Assassino", "O Psicopata", "O Alienígena", "O Carniceiro", "O Matador",
 "O Vampiro", "O Maluco", "O Vingador", "O Monstro", "O Bruxo", "O Demônio"];
string[] sobrenomes = ["Endiabrado", "Radioativo", "Endemoniado", "Vermelho", "Possuído", "Macabro", "Sombrio", "Sem Cabeça",
"Desconhecido", "Inconsciente", "Oculto", "Esquecido", "Lúgubre", "Invocado", "Caído", "Costurado", "Amaldiçoado", "Anormal",
"Perturbado", "Sanguinário", "Tenebroso", "Imortal", "Ressuscitado", "do Pântano", "da Encruzilhada", "do Porão",
"do Velho Poço", "sem Perdão", "do Cemitério", "da Meia-Noite", "da Lua Cheia"];


while (true)
{
    Console.Write("Qual é o dia de nascimento da vítima (1 a 31) ");
    int dia = Convert.ToInt32(Console.ReadLine());

    Console.Write("Qual é o mês de nascimento da vítima (1 a 12) ");
    int mes = Convert.ToInt32(Console.ReadLine());

    if (dia >= 1 && dia <= 31 && mes >= 1 && mes <= 12)
    {
        string nomeCompleto = $"{nomes[mes - 1]} {sobrenomes[dia - 1]}";
        Console.WriteLine($"Fuja! Lá vem {nomeCompleto}!");
        break;
    }
    else
    {
        Console.WriteLine("Digite uma data válida por gentileza: ");
    }



}
