namespace ReverseOddLengthWords;

public static class StringExtension
{
    public static string ReverseOdd(this string str)
    {
        var newStr = string.Empty;
        var strArray = str.Split();
        for (int i = 0; i < strArray.Length; i++) newStr += strArray[i].Length % 2 == 0 ? strArray[i] + Space() : string.Join(string.Empty, strArray[i].Reverse()) + Space();
        return newStr.TrimEnd();
    }

    private static string Space() => " ";
}