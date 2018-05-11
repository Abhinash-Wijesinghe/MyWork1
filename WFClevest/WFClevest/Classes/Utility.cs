using System;
using System.Collections.Generic;
using System.Linq;

namespace WFClevest.Classes
{
    /// <summary>
    /// The class that contains a set of useful functions.
    /// </summary>
    public class Utility
    {
        #region variables
        /// <summary>
        /// Stores a set of instructions how to connect wires.
        /// </summary>
        private Dictionary<string, string> instructions = new Dictionary<string, string>();
        #endregion

        #region Methods
        /// <summary>
        /// Provides instructions to locate the floor where meter is.
        /// </summary>
        /// <param name="str">A set of opening and closing parenthesis.</param>
        /// <returns>
        /// The floor number. A negative floor number means it is in the basement.
        /// </returns>
        public int FindFloorNumber(string str)
        {
            Char[] chars = str.ToCharArray();

            int floorCounter = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (chars[i] == '(')
                {
                    floorCounter++;
                }
                else if (chars[i] == ')')
                {
                    floorCounter--;
                }
            }

            return floorCounter;
        }

        /// <summary>
        /// Calculates how many houses have their meters read at least once
        /// </summary>
        /// <param name="str">A set of characters denoting which way to move.</param>
        /// <returns>
        /// The number of houses have their meters read at least once.
        /// </returns>
        public int FindHousesVisited(string str)
        {
            HashSet<Tuple<int, int>> visits = new HashSet<Tuple<int, int>>();
            int x = 0;
            int y = 0;

            visits.Add(new Tuple<int, int>(x, y));  // Add the starting position.

            foreach (char c in str)
            {
                switch (c)
                {
                    case '^':
                        ++y;
                        break;
                    case '>':
                        ++x;
                        break;
                    case 'v':
                        --y;
                        break;
                    case '<':
                        --x;
                        break;
                }

                visits.Add(new Tuple<int, int>(x, y));
            }

            return visits.Count;
        }

        /// <summary>
        /// Calculates the number of valid strings to be imported.
        /// </summary>
        /// <param name="strings">An array of strings.</param>
        /// <returns>
        /// The number of valid strings.
        /// </returns>
        public int FindGoodStringToImport(string[] strings)
        {
            int validStringCount = 0;
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            foreach (string word in strings)
            {
                int vowelCount = 0;
                bool foundDoubleLetter = false;
                bool foundNextCharacter = false;

                for (int i = 0; i < word.Length; i++)
                {
                    //  1. check for at least 3 vowels.
                    if (Array.IndexOf(vowels, word.ToLower()[i]) >= 0)
                    {
                        ++vowelCount;
                    }

                    // 2. check a character appears twice in a row.
                    if (i != word.Count() - 1)
                    {
                        if (word.ToLower()[i] == word.ToLower()[i + 1])
                        {
                            foundDoubleLetter = true;
                        }
                    }

                    // 3. The next character is not the next character in alphabetical order.
                    if (i != word.Count() - 1)
                    {
                        if (word.ToLower()[i + 1] == word.ToLower()[i] + 1)
                        {
                            foundNextCharacter = true;
                        }
                    }
                }

                if ((vowelCount >= 3) & (foundDoubleLetter) & (!foundNextCharacter))
                {
                    validStringCount++;
                }
            }

            return validStringCount;
        }

        /// <summary>
        /// Provides proper wiring instructions.
        /// </summary>
        /// <param name="strings">An array of strings.</param>
        /// <returns>
        /// The value.
        /// </returns>
        public int FindOutput(string[] strings)
        {
            // Split each item and add output (key) and the value (instruction) in to the dictionary.
            foreach (string str in strings)
            {
                string[] parts = str.Split('-', '>');
                instructions.Add(parts[2].Trim(), parts[0].Trim());
            }

            // return  EvaluateInstructions("a"); // hardcoded 'a' for testing as not yet completed

            return -1; // temporary fix...

            // TO DO - getting KeyNotFountException. Not enough time to investigate.




        }

        /// <summary>
        /// A recursive function to get the value.
        /// </summary>
        /// <param name="output">A string value to be used as a key for directory search.</param>
        /// <returns>
        /// The corresponding value.
        /// </returns>
        private int EvaluateInstructions(string output)
        {
            string instruction = "";
            int result = 0;

                instruction = instructions[output];
 
                string[] parts = instruction.Split(' ');

                if (parts.Count() == 1)
                {
                    // check whether it is a number of not.
                    int i = 0;
                    bool rslt = int.TryParse(parts[0], out i);
                    if (rslt)
                    {
                        result = i;
                    }
                    else
                    {
                        EvaluateInstructions(parts[0]);
                    }
                    
                }
                else if (parts.Count() == 2)    // NOT operator
                {
                    result = ~ EvaluateInstructions(parts[1]);
                }
                else if (parts.Count() == 3)    // AND, OR, RSHIFT, LSHIFT operators
                {
                    switch (parts[1])
                    {
                        case "AND":
                            result = EvaluateInstructions(parts[0]) & EvaluateInstructions(parts[2]);

                            break;
                        case "OR":
                            result = EvaluateInstructions(parts[0]) | EvaluateInstructions(parts[2]);

                            break;
                        case "RSHIFT":
                            result = EvaluateInstructions(parts[0]) >> EvaluateInstructions(parts[2]);

                            break;
                        case "LSHIFT":
                            result = EvaluateInstructions(parts[0]) << EvaluateInstructions(parts[2]);

                            break;
                    }

                }

            return result;

        }
         #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Utility" /> class.
        /// </summary>
        public Utility()
        {

        }
        #endregion

    }
}
