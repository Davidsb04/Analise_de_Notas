Console.Write("Digite a quantidade de alunos: ");
int quant = int.Parse(Console.ReadLine());

int[] notas = new int[quant];
int opcao = 0, menorNota = int.MaxValue, maiorNota = int.MinValue, totalNotas = 0, contMedia = 0;


for (int i = 0; i < notas.Length; i++)
{
    Console.Write("Insira a {0}ª nota: ", i + 1);
    notas[i] = int.Parse(Console.ReadLine());

    while (notas[i] < 0 || notas[i] > 100)
    {
        Console.Write("Nota inválida! Digite uma nota válida: ");
        notas[i] = int.Parse(Console.ReadLine());
    }
}

for (int i = 0; i < notas.Length; i++)
{
    if (menorNota > notas[i])
    {
        menorNota = notas[i];
    }
    if (maiorNota < notas[i])
    {
        maiorNota = notas[i];
    }
    if (notas[i] > 60)
    {
        contMedia++;
    }
    totalNotas += notas[i];
}

double media = totalNotas / quant;

do
{
    Console.WriteLine("\n[1] Mostrar menor nota\n[2] Mostrar maior nota\n[3] Pesquisar nota\n[4]Mostrar média das notas e qauntidade de notas acima da média\n[5] Sair");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("A menor nota registrada foi: {0}", menorNota);
            break;
        case 2:
            Console.WriteLine("A maior nota registrada foi: {0}", maiorNota);
            break;
        case 3:
            Console.WriteLine("Qual nota você deseja pesquisar: ");
            int nota = int.Parse(Console.ReadLine());
            for (int i = 0; i < notas.Length; i++)
            {
                if (nota == notas[i])
                {
                    int posicao = i;
                    Console.WriteLine("A nota {0} está na {1}ª posição.", nota, posicao + 1);
                }
            }
            break;
        case 4:
            Console.WriteLine("A média das notas foi {0}.\nO número de notas acima da média foi: {1}", media, contMedia);
            break;
        case 5:
            break;
        default:
            Console.WriteLine("A opção informada é inválida! Digite uma nova opção.");
            break;
    }
} while (opcao != 5);
