using System;
using System.Collections.Generic;

namespace WordCounterApp.Objects

{
    public class RepeatCounter
    {
        public string _userString;
        public string _findWord;
        public string _result;

        //Constructor
        public RepeatCounter(string userString, string findWord)
        {
            _userString = userString;
            _findWord = findWord;
        }

        //Getter
        public string GetUserString()
        {
            return _userString;
        }

        public string GetFindWord()
        {
            return _findWord;
        }

        //Main Method
        public int CountRepeats()
        {
            string[] array = GetUserString().ToLower().Split(' ', '.', ',', '!', '?');

            string searchWord = GetFindWord().ToLower();
            int result = 0;
            foreach(string word in array)
            {
                if (word == searchWord)
                {
                    result += 1;
                }
            }
            return result;
        }
    }
}
