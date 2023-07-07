using System;
using System.Globalization;
using System.Numerics;

namespace RSA
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
    
    public static class RSAMethods
    {
        static char[] characters = new char[] { ' ', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                                                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                                                'à', 'á', 'â', 'ã', 'ä', 'å', '¸', 'æ', 'ç', 'è', 'é', 'ê', 'ë', 'ì', 'í', 'î', 'ï', 'ð', 'ñ', 'ò', 'ó', 'ô', 'õ', 'ö', '÷', 'ø', 'ù', 'ü', 'û', 'ú', 'ý', 'þ', 'ÿ',
                                                'À', 'Á', 'Â', 'Ã', 'Ä', 'Å', '¨', 'Æ', 'Ç', 'È', 'É', 'Ê', 'Ë', 'Ì', 'Í', 'Î', 'Ï', 'Ð', 'Ñ', 'Ò', 'Ó', 'Ô', 'Õ', 'Ö', '×', 'Ø', 'Ù', 'Ü', 'Û', 'Ú', 'Ý', 'Þ', 'ß',
                                                '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '!', ',', '.', '?', ';', ':', '/', '(', ')', '*', '^', '%' , '@', '#' , '$' , '"', '¹',
                                                '%', '~'};
        static Random random = new Random();

        public static bool CommonNumberCheck(BigInteger number)
        {
            if (number < 100)
            {
                for (int j = 2; j < number; j++)
                {
                    if (number % j == 0)
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                        return false;
                }
            }
            return true;
        }
        
        public static BigInteger CalculateN(BigInteger p, BigInteger q)
        {
           return p * q;           
        }

        public static BigInteger CalculateD(BigInteger p, BigInteger q, BigInteger e)
        {
            long[,] matrixE = new long[2, 2] {{1, 0}, {0, 1}};
            BigInteger eulerFunctionFromN = (p - 1) * (q - 1);
            BigInteger result = InvMod(matrixE, e, eulerFunctionFromN)[0, 1];
            while (result * e < eulerFunctionFromN)
                result += eulerFunctionFromN;
            return  result;
        }
            
        private static long[,] InvMod(long[,] E, BigInteger a, BigInteger b)
        {
            BigInteger remains = a % b;
            if (remains == 0)
                return E;
            BigInteger ratio = (a - remains) / b;


            
            long q = (long)ratio;

            E = MatrixProduction(E, new long[2, 2] {{0, 1}, {1, (- 1) * q}});
            return InvMod(E, b, remains);
        }   

        private static long[,] MatrixProduction(long[,] matrix1, long[,] matrix2)
        {
            long[,] resmatrix = new long[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        resmatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            return resmatrix;
        }

        public static void RandomKeys(out BigInteger q, out BigInteger p, out BigInteger e)
        {
            q = random.Next(1000000000);
            while (!CommonNumberCheck(q))
                q = random.Next(1000000000);
            p = random.Next(1000000000);
            while (!CommonNumberCheck(p))
                p = random.Next(1000000000);
            e = random.Next(3, 997);
            while (BigInteger.GreatestCommonDivisor((q - 1) * (p - 1), e) != 1)
                e = random.Next(3, 997);
        }

        public static string EnCrypt(List<char> message ,BigInteger n, BigInteger e) {
            string cryptedMessage = "";
            BigInteger indexEC;
            foreach (char m in message)
            {
                indexEC = Array.IndexOf(characters, m);
                indexEC = BigInteger.ModPow(indexEC, e, n);
                cryptedMessage += indexEC.ToString() + " ";
            }
            return cryptedMessage;
        }

        public static string DeCrypt(List<long> cryptedMessage, BigInteger n, BigInteger d)
        {
            BigInteger indexDC;
            string deCryptedMessage = "";
            int charindex;
            foreach (long c in cryptedMessage)
            {
                indexDC = BigInteger.ModPow(c, d, n);
                charindex = (int)indexDC;
                deCryptedMessage += characters[charindex];
            }
            return deCryptedMessage;
        }

        
    }

}