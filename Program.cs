// Lista de Compras: Crie um programa que permita ao usuário digitar uma lista de itens.
// Ao final o programa deve mostrar a lista de itens completa.
// Não deve ser permitido adicionar o mesmo item duas vezes.

int quantidadeItens = 0;

Console.BackgroundColor = ConsoleColor.Green;
Console.ForegroundColor = ConsoleColor.Blue;

Console.WriteLine("Qual a quantidade de itens da sua lista?");
quantidadeItens = int.Parse(Console.ReadLine());

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Red;

string[] itens = new string[quantidadeItens];

// Solicita os itens ao usuário
for (int i = 0; i < quantidadeItens; i++)
{
    Console.Write($"Item {i + 1}: ");
    string item = Console.ReadLine();

    // Pesquisar se já existe algum item com mesmo nome
    bool encontrouItem = false;

    for (int j = 0; j < quantidadeItens; j++)
    {
        if (itens[j] != null)
        {
            if (item.ToUpper() == itens[j].ToUpper())
            {
                encontrouItem = true;
            }
        }
    }

    if (!encontrouItem)
        itens[i] = item;
    else
    {
        Console.WriteLine("Não é possivel adicionar o mesmo item!");
        i--;
    }
}

// Mostra a lista de itens armazenados
Console.Clear();
Console.WriteLine("Lista de itens");
Console.WriteLine("==============");

for (int i = 0; i < quantidadeItens; i++)
{
    Console.WriteLine($"{i + 1} - {itens[i]}");
}