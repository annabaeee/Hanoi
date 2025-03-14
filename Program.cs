namespace Hanoi;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 2 || !int.TryParse(args[1], out int n) || n <= 0)
        {
            Console.WriteLine("Usage: hanoi -Recursive <numDisks> or hanoi -Iterative <numDisks>");
            return;
        }

        // run either recursive approach or iterative approach, whichever argument was given
        if (args[0] == "-Recursive")
            HanoiUsingRecursion(n, 1, 3);
        else if (args[0] == "-Iterative")
            HanoiUsingIteration(n);
        // handle "invalid" arguments
        else
            Console.WriteLine("Invalid option. Use -Recursive or -Iterative.");
    }

    /*
    n = number of disks
    start = starting rod
    end = end/target rod
    */
    static void HanoiUsingRecursion(int n, int start, int end)
    {
        if (n == 0) return;
        int other = 6 - (start + end); // calculate auxiliary rod
        HanoiUsingRecursion(n - 1, start, other); // move n-1 disks from start to aux rod
        Console.WriteLine($"Move disk {n} from rod {start} to rod {end}"); // print out the move in the console
        HanoiUsingRecursion(n - 1, other, end); // move n-1 disks from aux rod to end rod
    }

    // n = number of disks
    static void HanoiUsingIteration(int n)
    {
        const int start = 0; // the starting rod; this value does not change
        var (other, end) = n % 2 == 0 ? (2, 1) : (1, 2); // calculate aux rod (other) and end rod
        var rods = new[] { new Stack<int>(), new Stack<int>(), new Stack<int>() }; // create new stack for each rod
        for (int i = n; i > 0; i--)
        {
            rods[0].Push(i); // push n disks into starting rod stack
        }

        var moves = new[]
        {
            // Move one disk from start rod to end rod or vice versa, whichever move is legal.
            (start, end),(end, start),
            // Move one disk from start rod to aux rod or vice versa, whichever move is legal.
            (start, other),(other, start),
            // Move one disk from end rod to aux rod or vice versa, whichever move is legal.
            (end, other),(other, end)
        };

        while (rods[2].Count < n) // iterate while not all disks are on the 3rd rod
        {
            // test moves in order
            for (int i = 0; i < moves.Length; i++)
            {
                var (from, to) = moves[i];
                // skip illegal moves (no disk on source rod, or smaller disk on target rod)
                if (rods[from].Count == 0 || (rods[to].Count > 0 && rods[from].Peek() > rods[to].Peek())) continue;
                var disk = rods[from].Pop(); // remove disk from top (in stack)
                Console.WriteLine($"Move disk {disk} from rod {from + 1} to rod {to + 1}"); // print out the move in the console
                rods[to].Push(disk); // push disk into stack
                if (i % 2 == 0) i++; // do not move the disk back
                if (rods[2].Count == n) break; // all disks on 3rd rod
            }
        }

    }
}
