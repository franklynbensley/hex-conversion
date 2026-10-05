namespace hex_conversion
{
    internal class Program
    {
        static bool checkLength(string input)
        {
            if (input.Length == 7)
            {
                return true;
            }
            else return false;
        }
        static bool checkHash(string input)
        {
            if (input[0] == '#')
            {
                return true;
            }
            else return false;
        }
        static bool checkChars(string input)
        {
            char[] hexnums = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool valid = false;
            input = input.ToUpper();
            for (int i = 1; i < input.Length; i++)
            {
                valid = false;
                for (int j = 0; j < hexnums.Length; j++)
                {
                    if (input[i] == hexnums[j])
                    {
                        valid = true; break;
                    }
                }
            }
            return valid;
        }
        static int[] convert(string input)
        {
            char[] hexnums = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            int[] rgb = new int[3];
            string hex = "";
            int conversion = 0;
            int position = 0;
            for (int i = 1; i < 7; i += 2)
            {
                hex = input.Substring(0, 2);
                for (int j = 0; j < hexnums.Length; j++)
                {
                    if (input[i] == hexnums[j])
                    {
                        position = j; break;
                    }
                }
                conversion = position * 16 + hex[1];
                rgb[(i - 1) / 2] = conversion;
            }
            return rgb;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] conversion = convert(input);
            for (int i = 0; i < conversion.Length; i++)
            {
                Console.WriteLine(conversion[i]);
            }
        }
    }
}
