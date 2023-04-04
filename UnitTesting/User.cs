﻿using System.Text.RegularExpressions;

namespace UnitTesting
{
    public class User
    {
        public static string USER_NAME = "^[A-Z]{1}[a-z]{2,}";
        public string UserFirst(string name)
        {
            if (Regex.IsMatch(name, USER_NAME))
                return "Valid";
            return "InValid";
        }
    }
}