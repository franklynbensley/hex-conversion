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
            input = input.ToUpper();
            Console.WriteLine(input);
            int[] rgb = new int[3];
            int conversion = 0;
            int[] positions = new int [6];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < hexnums.Length; j++)
                {
                    if (input[i+1] == hexnums[j])
                    {
                        positions[i] = j; break;
                    }
                }
            }
            for (int i = 0; i < positions.Length; i+=2)
            {
                conversion = positions[i] * 16 + positions[i + 1];
                rgb[(i) / 2] = conversion;
            }
            for (int i = 0; i < positions.Length; i++)
            {
                Console.WriteLine(positions[i]);
            }
            return rgb;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] conversion = convert(input);
            Console.WriteLine($"red value: {conversion[0]}");
            Console.WriteLine($"gren value: {conversion[1]}");
            Console.WriteLine($"blue value: {conversion[2]}");
        }
    }
}
