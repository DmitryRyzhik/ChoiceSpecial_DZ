string[] array = { "hello", "2", "world", ":-)" };
var result = new string[array.Length];
var i = 0;
foreach (var value in array)
{
if(value.Length <=3)
{
result[i]=value;
i++;
}
}
System.Console.Write(string.Join(Environment.NewLine, result, 0, i));