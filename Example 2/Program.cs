Console.Clear();
Console.Write("Введите значение n=");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите значение m=");
int m = int.Parse(Console.ReadLine());
int max=0;
int min=0;
int result = 0;
if (n>m)
{
  max=n;
  min=m;
}
else
{
  max=m;
  min=n;
}
while (min < max + 1)
if (min > 0)
{
  result = result + min;
  min++;
}
else
{
  min++;
}
Console.Write(result);
