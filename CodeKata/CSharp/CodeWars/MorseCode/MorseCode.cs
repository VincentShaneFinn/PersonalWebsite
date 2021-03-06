﻿using System.Collections.Generic;

namespace CodeWars.MorseCode
{
    public class MorseCode
    {
        private static readonly Dictionary<string, string> morse = new Dictionary<string, string>()
            {
                {".-"   , "A" },
                {"-..." , "B" },
                {"-.-." , "C" },
                {"-.."  , "D" },
                {"."    , "E" },
                {"..-." , "F" },
                {"--."  , "G" },
                {"...." , "H" },
                {".."   , "I" },
                {".---" , "J" },
                {"-.-"  , "K" },
                {".-.." , "L" },
                {"--"   , "M" },
                {"-."   , "N" },
                {"---"  , "O" },
                {".--." , "P" },
                {"--.-" , "Q" },
                {".-."  , "R" },
                {"..."  , "S" },
                {"-"    , "T" },
                {"..-"  , "U" },
                {"...-" , "V" },
                {".--"  , "W" },
                {"-..-" , "X" },
                {"-.--" , "Y" },
                {"--.." , "Z" },
                {"-----", "0" },
                {".----", "1" },
                {"..---", "2" },
                {"...--", "3" },
                {"....-", "4" },
                {".....", "5" },
                {"-....", "6" },
                {"--...", "7" },
                {"---..", "8" },
                {"----.", "9" },
                {"...---...", "SOS" },
            };

        public static string Get(string morseDigit)
        {
            return morse[morseDigit.ToUpper()];
        }
    }
}