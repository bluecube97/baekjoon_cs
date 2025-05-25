internal class Program
{
    static string ToBinary(int value, int bits)
    {
        return Convert.ToString(value, 2).PadLeft(bits, '0');
    }

    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        var opcodeDict = new Dictionary<string, (string dicOpcode, string bit4)>
        {
            {"ADD",   ("0000", "0")},
            {"ADDC",  ("0000", "1")},
            {"SUB",   ("0001", "0")},
            {"SUBC",  ("0001", "1")},
            {"MOV",   ("0010", "0")},
            {"MOVC",  ("0010", "1")},
            {"AND",   ("0011", "0")},
            {"ANDC",  ("0011", "1")},
            {"OR",    ("0100", "0")},
            {"ORC",   ("0100", "1")},
            {"NOT",   ("0101", "0")},
            {"MULT",  ("0110", "0")},
            {"MULTC", ("0110", "1")},
            {"LSFTL", ("0111", "0")},
            {"LSFTLC",("0111", "1")},
            {"LSFTR", ("1000", "0")},
            {"LSFTRC",("1000", "1")},
            {"ASFTR", ("1001", "0")},
            {"ASFTRC",("1001", "1")},
            {"RL",    ("1010", "0")},
            {"RLC",   ("1010", "1")},
            {"RR",    ("1011", "0")},
            {"RRC",   ("1011", "1")}
        };

        int n = int.Parse(isr.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] command = isr.ReadLine().Split();
            string opcode = command[0];
            int rD = int.Parse(command[1]);
            int rA = int.Parse(command[2]);
            string rB = command[3];

            var (dicOpcode, bit4) = opcodeDict[opcode];
            string rD_bin = ToBinary(rD, 3);
            string rA_bin = ToBinary(rA, 3);
            const string unused = "0";

            string result = dicOpcode + bit4 + unused + rD_bin + rA_bin;

            if (bit4 == "0")
            {
                string rB_bin = ToBinary(int.Parse(rB), 3);
                result += rB_bin + "0";
            }
            else
            {
                string const_bin = ToBinary(int.Parse(rB), 4);
                result += const_bin;
            }

            Console.WriteLine(result);
        }
    }
}