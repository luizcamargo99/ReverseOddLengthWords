namespace ReverseOddLengthWords;

public static class StringExtension
{
    private static string _space { get { return " "; } }

    public static string ReverseOdd(this string str)
    {
        var newStr = string.Empty;
        var strArray = str.Split();
        for (int i = 0; i < strArray.Length; i++) newStr += strArray[i].Length % 2 == 0 ? strArray[i] + _space : string.Join(string.Empty, strArray[i].Reverse()) + _space;
        return newStr.TrimEnd();
    }
}