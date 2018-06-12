using System;
class Program
{
    static void Main()
    {
        string[,] asciiTable = new string[16, 6];
        asciiTable = generateAsciiTable();
        for (int i = 0; i < 16; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Console.Write(asciiTable[i,j] + "\t");
            }
            Console.Write("\n");
        }
        
        Console.Read();
    }
    private static string[,] generateAsciiTable()
    {
        string[,] asciiMatrice = new string[16, 6];
        int min = 32;
        for (int i = 0; i < 16; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                char c = (char)(min + i);
                asciiMatrice[i, j] = min + i + " : " + c.ToString();
                min += 16;
            }
            min = 32;
        }
        return asciiMatrice;
    }
}