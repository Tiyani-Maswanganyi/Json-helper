        /// <summary>
        /// Removes white space from string
        /// https://stackoverflow.com/questions/6219454/efficient-way-to-remove-all-whitespace-from-string
        /// </summary>
        /// <param name="input">String to remove whitespace from</param>
        /// <returns></returns>
        public static string RemoveWhitespace(this string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }
        
        
        
        
        /// <summary>
        /// Removes letters from string 
        /// https://stackoverflow.com/questions/3624332/how-do-you-remove-all-the-alphabetic-characters-from-a-string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string RemoveLetters(this string input)
        {
            string numberOnly = Regex.Replace(input, "[^0-9]", "");
            return numberOnly;
        }

        /// <summary>
        /// Removes the first character in string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string RemoveFirst(this string input)
        {
            input = input.Substring(1);
            return input;
        }
