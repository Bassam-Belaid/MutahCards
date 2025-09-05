using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    public class clsCode
    {

        private enum enKeyTypes { eNumber = 1, eCapitalLetter = 2 }

        private static Random Rand = new Random();

        private static char GetRandomNumber()
        {

            return (char)clsCode.Rand.Next(48, 58);

        }

        private static char GetRandomCapitalLetter()
        {

            return (char)clsCode.Rand.Next(65, 91);

        }

        private static char GenerateKey()
        {

            switch ((enKeyTypes)Rand.Next(1, 3))
            {

                case enKeyTypes.eNumber:
                    return GetRandomNumber();

                default:
                    return GetRandomCapitalLetter();

            }

        }

        private static string GenerateBlock(int BlockLength)
        {

            string Block = "";

            for (int i = 0; i < BlockLength; i++)
            {

                Block += GenerateKey();

            }

            return Block;

        }

        public static string GenerateCode(int CodeLength = 4, int BlockLength = 4)
        {

            string Code = "";

            for (int i = 0; i < CodeLength; i++)
            {

                Code += GenerateBlock(BlockLength);

            }

            return Code;

        }

        public static string FormatCode(string Code, int BlockLength = 4)
        {

            string NewCode = "";
            int Counter = 0;

            for (int i = 0; i < Code.Length; i++)
            {

                NewCode += Code[i];
                Counter++;

                if (Counter == BlockLength && i < Code.Length - 1)
                {

                    NewCode += '-';
                    Counter = 0;

                }

            }

            return NewCode;

        }

    }
}
