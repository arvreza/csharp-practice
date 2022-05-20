using System;

public class Recursion {

    public int Factorial(int n) {
        if (n == 0) return 1;

        return n * Factorial(n - 1);
    }

    /*
    
        We have bunnies standing in a line, numbered 1, 2, ... 
        The odd bunnies (1, 3, ..) have the normal 2 ears. 
        The even bunnies (2, 4, ..) we'll say have 3 ears, because they each have a raised foot. 
        Recursively return the number of "ears" in the bunny line 1, 2, ... n (without loops or multiplication).


    bunnyEars2(0) → 0
    bunnyEars2(1) → 2
    bunnyEars2(2) → 5
    */

    public int BunnyEars(int n) {
        if (n ==0) return 0;

        if (n%2 == 0) return 3 + BunnyEars(n-1);
        return 2 + BunnyEars(n-1);
    }

    public int Fib(int n) {
        if (n == 0) return 0;
        if (n == 1 || n == 2) return 1;

        return Fib(n - 1) + Fib(n-2);
    }

    /*
    
    We have triangle made of blocks. 
    The topmost row has 1 block, the next row down has 2 blocks, 
    the next row has 3 blocks, and so on. Compute recursively (no loops or multiplication) 
    the total number of blocks in such a triangle with the given number of rows.


    triangle(0) → 0
    triangle(1) → 1
    triangle(2) → 3
    */
    public int triangle(int n) {
        if (n == 0) return 0;
        if (n == 1) return 1;

        return n + triangle(n-1);
    }

    /*
    Given a non-negative int n, return the sum of its digits recursively (no loops). 
    Note that mod (%) by 10 yields the rightmost digit (126 % 10 is 6), 
    while divide (/) by 10 removes the rightmost digit (126 / 10 is 12).


    sumDigits(126) → 9
    sumDigits(49) → 13
    sumDigits(12) → 3
    */
    public int SumDigits (int n) {
        if (n < 10) return n;

        return (n%10) + SumDigits(n/10);
    }

    public int PowerN(int b, int n) {
        if (n == 0) return 1;

        return b * PowerN(b, n-1);
    }

    public bool GroupSum(int index, int[] nums, int target) {
        if (index >= nums.Length) return target == 0;

        if (GroupSum(index + 1, nums, target - nums[index])) return true;

        if (GroupSum(index + 1, nums, target)) return true;

        return false;
    } 
}