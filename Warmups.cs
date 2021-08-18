using System;
using System.Collections.Generic;
using System.Text;


public class WarmUps {
    public bool LastDigit(int first, int last) 
    { 
        return (first % 10 == last %10);
    }

    /*
        We want to make a row of bricks that is goal inches long. 
        We have a number of small bricks (1 inch each) and big bricks (5 inches each). 
        Return true if it is possible to make the goal by choosing from the given bricks. 
        can be done without any loops.
        makeBricks(3, 1, 9) → false
        makeBricks(3, 2, 10) → true
        makeBricks(3, 2, 8) → true
        makeBricks(3, 2, 9) → false
        makeBricks(3, 1, 7) → true
        makeBricks(2, 1000000, 100003) → false
    */
    public bool MakeBrick(int small, int big, int goal) 
    {
         return (goal%5)<=small && (goal-(big*5))<=small;
    }

    public string DoubleChar(string str) 
    {
        if (string.IsNullOrEmpty(str)) return string.Empty;
        
        StringBuilder sb = new StringBuilder(str.Length*2);

        foreach(char c in str) 
        {
            sb.Append(c.ToString() + c.ToString());
        }

        return sb.ToString();
    }

    /*
    zipZap("zipXzap") → "zpXzp"
    zipZap("zopzop") → "zpzp"
    zipZap("zzzopzop") → "zzzpzp"
    */
    public string ZipZap(string value) 
    {
        var chars = value.ToCharArray();
        StringBuilder output = new StringBuilder();

        for (int i=0; i < chars.Length - 2; ++i) {
            if ((chars[i] == 'z' || chars[i] == 'Z') 
            && (chars[i+2] == 'p' || chars[i+2] == 'P')) 
            {
                output.Append(chars[i]);
                output.Append(chars[i+2]);
                i+=2;
                continue;
            }
            
            output.Append(chars[i]);
        }

        return output.ToString();
    }

    /*
        two loops
        the outer loop goes through the big
        the inner loop goes through the small

        zopzop
        zip

        i   j   Bi+j  Sj
        0   0   z   z
        0   1   o   i
        1   0   o   z
        2   0   p   z
        


    */
    public bool subString(string big, string small) 
    {
        if (String.IsNullOrEmpty(big) || String.IsNullOrEmpty(small)) return false;
        if (big.Length < small.Length) return false;

        for (int i=0; i <= big.Length - small.Length; ++i) 
            for (int j = 0; j < small.Length; ++j) {
                if (big[i+j] != small[j]) break; 
                if (j == small.Length - 1) return true;
            }
        return false;
    }   

    public Dictionary<char, int> LetterCount(String value) {
        if (String.IsNullOrEmpty(value)) return new Dictionary<char, int>(0);

        var output = new Dictionary<char, int>(value.Length);
        foreach(char ch in value) {
            if (output.ContainsKey(ch)) ++output[ch];
            else output.Add(ch, 0);
        }

        return output;
    }

}