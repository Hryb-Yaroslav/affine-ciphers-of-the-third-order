using System;
     
class Program
{
    static public int[,] K1 = {{2,2,3},{2,3,4},{5,3,6}};
    static public int[] K2 = {12,13,14};
    public static char[] test(string str)
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
    public static string Code(string text, bool decode = false)
    {
        int[,] C = new int[(int)text.Length / 3,3];
        string result = "";
        char[] res;
        for (int i = 0, j = 0; i < C.GetLength(0); i++, j += 3)
        {
            if (!decode) res = test(text[j] + "" + text[j+1] + "" + text[j+2]);
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
        string codeText = Code(text);
        System.Console.WriteLine(codeText);
        System.Console.WriteLine(Code(codeText, true));
    }
}
// using System;
     
// class Program
// {

//     // static public int[,] K1 = {{17,5,2},{6,7,13},{8,1,18}};
//     static public int[,] K1 = {{2,2,3},{2,3,4},{5,3,6}};
//     static public int[] K2 = {12,13,14};
//     public static char[] test(string str)
//     {
//         // System.Console.WriteLine(        );
//         // System.Console.WriteLine((int)str[0] + ":" + str[0] + "    " + (int)str[1] + ":" + str[1] + "    " + (int)str[2] + str[2]);
//         // System.Console.WriteLine(((int)str[0]- 65) + ":" + str[0] + "    " + ((int)str[1] - 65)+ ":" + str[1] + "    " + ((int)str[2]- 65) + ":" + str[2]);


//         int[] ascc = {(int)str[0] - 65, (int)str[1] - 65, (int)str[2] - 65};
//         int[] res1 = new int[3];

//         // System.Console.WriteLine("asc1: " + ascc[0] + "  asc2: " + ascc[1] + "  asc3: " +  ascc[2]);

//         // for (int i = 0; i < 3; i++)
//         //     res1[i] = K1[i,0] * ascc[0] + K1[i,1] * ascc[1] + K1[i,2] * ascc[2];

//         for (int i = 0; i < 3; i++)
//         {
//             for (int j = 0; j < 3; j++)
//             {
//                 res1[i] += K1[i,j] * ascc[j];
//             }
//         }

//         // System.Console.WriteLine("res1: " + res1[0] + "  res2: " + res1[1] + "  res3: " +  res1[2]);
        
//         int[] res2 = new int[3];
//         char[] res = new char[3];
//         for(int i = 0; i < 3; i++)
//             // res2[i] = (K2[i] + res1[i]) % 26;
//             res[i] = (char)(((K2[i] + res1[i]) % 26) + 65);
        
//         // System.Console.WriteLine("res1: " + res2[0] + "  res2: " + res2[1] + "  res3: " +  res2[2]);

//         // foreach (var item in res2)
//         //     System.Console.Write((char)(item + 65));
//         //     // System.Console.WriteLine(item);

//         return res; 
//     }
//     public static string Code(string text, bool decode = false)
//     {
//         int[,] C = new int[(int)text.Length / 3,3];
//         // int[] newInt;
//         string result = "";
//         char[] res;
//         for (int i = 0, j = 0; i < C.GetLength(0); i++, j += 3)
//         {
//             if (!decode)
//                 res = test(text[j] + "" + text[j+1] + "" + text[j+2]);
//             else
//                 res = Decode(text[j] + "" + text[j+1] + "" + text[j+2]);
//             result += "" + res[0] + res[1] + res[2];
//             // C[i, 0] = newInt[0];
//             // C[i, 1] = newInt[1];
//             // C[i, 2] = newInt[2];
//         }
//         // new int[]{(int)text[0] - 65, (int)text[1] - 65, (int)text[2] - 65}
//         return result;
//     }
//     static public char[] Decode(string str)
//     { 
//         // int[] Sstr = {24, 8, 11};
//         // int[,] AInverse = {{15, 18, 17},{2, 24, 7},{12, 21, 1}};
        
//         int[] Sstr = {7, 23, 2};
//         int[,] AInverse = {{6, 23, 25},{8, 23, 24},{17, 4, 2}};


//         int[]X = {(int)str[0] - 65, (int)str[1] - 65, (int)str[2] - 65};
       
//         // System.Console.WriteLine();
//         // System.Console.WriteLine((int)str[0] + ":" + str[0] + "    " + (int)str[1] + ":" + str[1] + "    " + (int)str[2] + str[2]);
//         // System.Console.WriteLine(((int)str[0]- 65) + ":" + str[0] + "    " + ((int)str[1] - 65)+ ":" + str[1] + "    " + ((int)str[2]- 65) + ":" + str[2]);



//         // Console.WriteLine(AInverse);
//         // for (int i = 0; i < 3; i++)
//         //     Sstr[i] = AInverse[i,0] * (double)K2[0] + AInverse[i,1] * (double)K2[1] + AInverse[i,2] * (double)K2[2];
//         // for (int i = 0; i < 3; i++)
//         // {
//         //     System.Console.WriteLine(Math.Round(Sstr[i], 2));            
//         // }
//         int[] S_1 = new int[3];
//         int[] S_2 = new int[3];
//         char[] res = new char[3];

//         for (int i = 0; i < 3; i++)
//             S_1[i] = AInverse[i,0] * X[0] + AInverse[i,1] * X[1] + AInverse[i,2] * X[2];

//         // System.Console.WriteLine("res1: " + S_1[0] + "  res2: " + S_1[1] + "  res3: " +  S_1[2]);

//         for(int i = 0; i < 3; i++)
//             // S_2[i] = (S_1[i] + Sstr[i]) % 26;
//             res[i] = (char)(((S_1[i] + Sstr[i]) % 26) + 65);


//         // System.Console.WriteLine("res1: " + S_2[0] + "  res2: " + S_2[1] + "  res3: " +  S_2[2]);

//         // foreach (var item in S_2)
//         //     System.Console.Write((char)(item + 65));


//         return res;
//     }


//     public static void Main(String[] args)
//     {
//         String msg = "SHIZZA";
//         // String msg = "QWETYUIOPASDFGHJKLZXCVBNMNN";
//         string codeText = Code(msg);
//         System.Console.WriteLine(codeText);
//         System.Console.WriteLine(Code(codeText, true));
//     }


// //  9 -10 25
// // -4  4  -1
// //  2  -3 11


// //       15 18 17
// // A` =   2 24  7
// //       12 21  1

// //        24
// // S` =    8
// //        11

//     // public static void decode(string text)
//     // {
//     //     int determinant = (K1[0,0] * K1[1,1] * K1[2,2]) + (K1[0,1] * K1[1,2] * K1[2,0]) + (K1[0,2] * K1[1,0] * K1[2,1]) - (K1[0,2] * K1[1,1] * K1[2,0]) - (K1[0,0] * K1[1,2] * K1[2,1]) - (K1[0,1] * K1[1,0] * K1[2,2]);  
//     //     System.Console.WriteLine(determinant);
//     //     int[,] algDop = new int[3,3];
//     //     for (int i = 0; i < 3; i++)
//     //     {
//     //         for (int j = 0; j < 3; j++)
//     //         {
//     //             try
//     //             {
//     //                 algDop[i,j] = K1[1-i,1-j] * K1[2-i,2-j] - K1[1 - i,2 - j] * K1[2 - i,1 - j];
//     //                 System.Console.Write(algDop[i,j] + "   ");
//     //             }
//     //             catch (Exception)
//     //             {
//     //                 System.Console.Write(" i:" + i + " j:" + j);
//     //             }
//     //         }
//     //         System.Console.WriteLine();
            
//     //     }

//     // }
// }