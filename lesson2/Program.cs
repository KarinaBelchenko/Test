string Metod4(int count, string text);
{
    int i = 0;
   
    string result = string.Empty;

    while (i < count) 
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Metod4(1, "не выходной день");
Console.WriteLine(res);


