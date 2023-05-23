using System;
     
class Program
{
    static public int[,] K1 = {{2,2,3},{2,3,4},{5,3,6}};
    static public int[] K2 = {12,13,14};
    public static char[] Code(string str)
    {
        int[] ascc = {(int)str[0] - 65, (int)str[1] - 65, (int)str[2] - 65};
        int[] res1 = new int[3];
        char[] res2 = new char[3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++) res1[i] += K1[i,j] * ascc[j];
            res2[i] = (char)(((K2[i] + res1[i]) % 26) + 65);
        }
        return res2; 
    }
    public static string CodeDecode(string text, bool decode = false)
    {
        int[,] C = new int[(int)text.Length / 3,3];
        string result = "";
        char[] res;
        for (int i = 0, j = 0; i < C.GetLength(0); i++, j += 3)
        {
            if (!decode) res = Code(text[j] + "" + text[j+1] + "" + text[j+2]);
            else res = Decode(text[j] + "" + text[j+1] + "" + text[j+2]);
            result += "" + res[0] + res[1] + res[2];
        }
        return result;
    }
    static public char[] Decode(string str)
    {
        int[] Sstr = {7, 23, 2};
        int[,] AInverse = {{6, 23, 25},{8, 23, 24},{17, 4, 2}};
        int[]X = {(int)str[0] - 65, (int)str[1] - 65, (int)str[2] - 65};
        int[] S_1 = new int[3];
        char[] res = new char[3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++) S_1[i] += AInverse[i,j] * X[j];
            res[i] = (char)(((S_1[i] + Sstr[i]) % 26) + 65);
        }
        return res;
    }
    public static void Main(String[] args)
    {
        String text = "SHIZZA";
        string codeText = CodeDecode(text);
        System.Console.WriteLine(codeText);
        System.Console.WriteLine(CodeDecode(codeText, true));
    }
}
