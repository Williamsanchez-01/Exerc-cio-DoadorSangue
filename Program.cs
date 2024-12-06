Console.Clear();

Console.WriteLine("Doador de sangue");

Console.WriteLine("Digite sua idade");
int idade = Convert.ToInt32(Console.ReadLine());

if (idade >= 18 && idade  <= 67)
{
Console.WriteLine("Pode doar sangue");
}
 else {
Console.WriteLine("Não pode doar sangue");
 }