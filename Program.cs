Console.Clear();
Console.WriteLine("Введите  число");
int N = int.Parse(Console.ReadLine());
string Value = Convert.ToString(N);
if (Value.Length < 3){
    Console.WriteLine("Такого числа нет");
}
else{
    Console.WriteLine(Value[2]);
}