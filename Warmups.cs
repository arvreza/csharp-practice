using System;
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

    
}