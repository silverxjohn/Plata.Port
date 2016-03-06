
namespace Plata.Port.Encoding
{
    public static class MorseCode
    {
        public static string Encrypt(string character)
        {
            string morse = "";

            switch (character.ToUpper())
            {
                case "A":
                    morse = ".-";
                    break;
                case "B":
                    morse = "-...";
                    break;
                case "C":
                    morse = "-.-.";
                    break;
                case "D":
                    morse = "-..";
                    break;
                case "E":
                    morse = ".";
                    break;
                case "F":
                    morse = "..-.";
                    break;
                case "G":
                    morse = "--.";
                    break;
                case "H":
                    morse = "....";
                    break;
                case "I":
                    morse = "..";
                    break;
                case "J":
                    morse = ".---";
                    break;
                case "K":
                    morse = "-.-";
                    break;
                case "L":
                    morse = ".-..";
                    break;
                case "M":
                    morse = "--";
                    break;
                case "N":
                    morse = "-.";
                    break;
                case "O":
                    morse = "---";
                    break;
                case "P":
                    morse = ".--.";
                    break;
                case "Q":
                    morse = "--.-";
                    break;
                case "R":
                    morse = ".-.";
                    break;
                case "S":
                    morse = "...";
                    break;
                case "T":
                    morse = "-";
                    break;
                case "U":
                    morse = "..-";
                    break;
                case "V":
                    morse = "...-";
                    break;
                case "W":
                    morse = ".--";
                    break;
                case "X":
                    morse = "-..-";
                    break;
                case "Y":
                    morse = "-.--";
                    break;
                case "Z":
                    morse = "--..";
                    break;
                case "0":
                    morse = "-----";
                    break;
                case "1":
                    morse = ".----";
                    break;
                case "2":
                    morse = "..---";
                    break;
                case "3":
                    morse = "...--";
                    break;
                case "4":
                    morse = "....-";
                    break;
                case "5":
                    morse = ".....";
                    break;
                case "6":
                    morse = "_....";
                    break;
                case "7":
                    morse = "__...";
                    break;
                case "8":
                    morse = "___..";
                    break;
                case "9":
                    morse = "----.";
                    break;
            }

            return morse;
        }

        public static string Decrypt(string morse)
        {
            string character = "";

            switch (morse)
            {
                case ".-":
                    character = "A";
                    break;
                case "-...":
                    character = "B";
                    break;
                case "-.-.":
                    character = "C";
                    break;
                case "-..":
                    character = "D";
                    break;
                case ".":
                    character = "E";
                    break;
                case "..-.":
                    character = "F";
                    break;
                case "--.":
                    character = "G";
                    break;
                case "....":
                    character = "H";
                    break;
                case "..":
                    character = "I";
                    break;
                case ".---":
                    character = "J";
                    break;
                case "-.-":
                    character = "K";
                    break;
                case ".-..":
                    character = "L";
                    break;
                case "--":
                    character = "M";
                    break;
                case "-.":
                    character = "N";
                    break;
                case "---":
                    character = "O";
                    break;
                case ".--.":
                    character = "P";
                    break;
                case "--.-":
                    character = "Q";
                    break;
                case ".-.":
                    character = "R";
                    break;
                case "...":
                    character = "S";
                    break;
                case "-":
                    character = "T";
                    break;
                case "..-":
                    character = "U";
                    break;
                case "...-":
                    character = "V";
                    break;
                case ".--":
                    character = "W";
                    break;
                case "-..-":
                    character = "X";
                    break;
                case "-.--":
                    character = "Y";
                    break;
                case "--..":
                    character = "Z";
                    break;
                case "-----":
                    character = "0";
                    break;
                case ".----":
                    character = "1";
                    break;
                case "..---":
                    character = "2";
                    break;
                case "...--":
                    character = "3";
                    break;
                case "....-":
                    character = "4";
                    break;
                case ".....":
                    character = "5";
                    break;
                case "_....":
                    character = "6";
                    break;
                case "__...":
                    character = "7";
                    break;
                case "___..":
                    character = "8";
                    break;
                case "----.":
                    character = "9";
                    break;
            }

            return character;
        }
    }
}
