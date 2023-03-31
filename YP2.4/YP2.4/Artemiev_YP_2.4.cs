//УП 2.4

using System;
using System.Collections.Generic;

class MainClass {
    public static void Main (string[] args) {
        Console.WriteLine("Введите римское число:");
        string roman = Console.ReadLine();

        int result = RomanToInt(roman);

        Console.WriteLine("Результат: " + result);
    }

    public static int RomanToInt(string s) {
        Dictionary<char, int> values = new Dictionary<char, int>() {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int result = 0;
        for (int i = 0; i < s.Length; i++) {
            if (i > 0 && values[s[i]] > values[s[i - 1]]) {
                result += values[s[i]] - 2 * values[s[i - 1]];
            } else {
                result += values[s[i]];
            }
        }
        return result;
    }
}
