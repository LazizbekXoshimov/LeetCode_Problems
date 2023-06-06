// See https://aka.ms/new-console-template for more information
string s = Console.ReadLine();
var c = s.Split('|');
int res = 0;
for(int i = 0; i < c.Length; i++)
{
    res += c[i].Count(x => x == '*');
}
Console.WriteLine(res);
Console.ReadKey();