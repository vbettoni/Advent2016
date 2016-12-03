using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        public static int Countvertical = 0;
        public static int CountHorizontal = 0;
        public static Direction CurrentDirection = Direction.North;


        static void Main(string[] args)
        {
            Calculate("R2, L3");
            Console.WriteLine("Test 1");
            Console.WriteLine($"Count = {Math.Abs(CountHorizontal) + Math.Abs(Countvertical)}");
            Reset();

            Calculate("R2, R2, R2");
            Console.WriteLine("Test 2");
            Console.WriteLine($"Count = {Math.Abs(CountHorizontal) + Math.Abs(Countvertical)}");
            Reset();

            Calculate("R5, L5, R5, R3");
            Console.WriteLine("Test 3");
            Console.WriteLine($"Count = {Math.Abs(CountHorizontal) + Math.Abs(Countvertical)}");
            Reset();

            Calculate("R1, L2, R2, R1, R2, R2, L1, L2");
            Console.WriteLine("Test 4");
            Console.WriteLine($"Count = {Math.Abs(CountHorizontal) + Math.Abs(Countvertical)}");
            Reset();

            Calculate("R3, L5, R1, R2, L5, R2, R3, L2, L5, R5, L4, L3, R5, L1, R3, R4, R1, L3, R3, L2, L5, L2, R4, R5, R5, L4, L3, L3, R4, R4, R5, L5, L3, R2, R2, L3, L4, L5, R1, R3, L3, R2, L3, R5, L194, L2, L5, R2, R1, R1, L1, L5, L4, R4, R2, R2, L4, L1, R2, R53, R3, L5, R72, R2, L5, R3, L4, R187, L4, L5, L2, R1, R3, R5, L4, L4, R2, R5, L5, L4, L3, R5, L2, R1, R1, R4, L1, R2, L3, R5, L4, R2, L3, R1, L4, R4, L1, L2, R3, L1, L1, R4, R3, L4, R2, R5, L2, L3, L3, L1, R3, R5, R2, R3, R1, R2, L1, L4, L5, L2, R4, R5, L2, R4, R4, L3, R2, R1, L4, R3, L3, L4, L3, L1, R3, L2, R2, L4, L4, L5, R3, R5, R3, L2, R5, L2, L1, L5, L1, R2, R4, L5, R2, L4, L5, L4, L5, L2, L5, L4, R5, R3, R2, R2, L3, R3, L2, L5");
            Console.WriteLine("HQ ");
            Console.WriteLine($"Count = {Math.Abs(CountHorizontal) + Math.Abs(Countvertical)}");


            Console.ReadLine();
        }


        static private void Calculate(string input)
        {
            List<string> split = input.Split(',').ToList();


            foreach (string s in split)
            {
                Move(s.Trim().Substring(0, 1), int.Parse(s.Trim().Substring(1)));
            }
        }

        static private void Reset()
        {
            Countvertical = 0;
            CountHorizontal = 0;
            CurrentDirection=Direction.North;
        }

        static private void Move(string direction, int blocks)
        {
            if (direction == "R")
                CurrentDirection++;
            if (direction == "L")
                CurrentDirection--;

            if (CurrentDirection == (Direction) (-1))
            {
                CurrentDirection = Direction.West;
            }
            if (CurrentDirection == (Direction) 4)
            {
                CurrentDirection = Direction.North;
            }

            if (CurrentDirection == Direction.North)
                Countvertical += blocks;
            if (CurrentDirection == Direction.East)
                CountHorizontal += blocks;
            if (CurrentDirection == Direction.West)
                CountHorizontal -= blocks;
            if (CurrentDirection == Direction.South)
                Countvertical -= blocks;
        }
    }

    public enum Direction
    {
        North = 0,
        East = 1,
        South = 2,
        West = 3
    }
}
