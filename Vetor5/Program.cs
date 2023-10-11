using System.Globalization;

int N = int.Parse(Console.ReadLine());

int[] nums =  new int[N];

string[] vet = Console.ReadLine().Split(' ');

for (int i = 0; i < N; i++) {
    nums[i] = int.Parse(vet[i]);
}

double soma = 0.0;
int qtd = 0;
for (int i = 0; i < N; i++) {
    if (nums[i] % 2 == 0) {
        soma += nums[i];
        qtd++;
    }
}

if (qtd == 0) {
    Console.WriteLine("Não há nenhum número par");
} else {
    double media = soma / qtd;
    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
}