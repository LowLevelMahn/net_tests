using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_net_4._5
{
    internal class Program
    {
        static void do_test(List<String> lines)
        {
            Console.WriteLine("input");
            foreach (var l in lines)
            {
                Console.WriteLine("  " + l);
            }
            var sorted = lines.OrderBy(s => s, StringComparer.CurrentCulture);
            Console.WriteLine("sorted");
            foreach (var s in sorted)
            {
                Console.WriteLine("  " + s);
            }
            Console.WriteLine("-----");
        }

        static void Main(string[] args)
        {
            do_test(new List<String> { "bl_long.txt", "xy.txt", "bl.txt", "bl" });
            //Debug.Assert(sortedLines.SequenceEqual(new List<String> { "bl", "bl.txt", "bl_long.txt", "xy.txt" }));

            do_test(new List<String> { "bl_abc", "bl_a", "bl_long", "bl_cong", "xy", "blb", "bl", "bla" });
            //Debug.Assert(sortedLines.SequenceEqual(new List<String> { "bl", "bl_a", "bl_abc", "bl_cong", "bl_long", "bla", "blb", "xy" }));

            do_test(new List<String> { "test3.txt", "bbb", "aaa.txt", "bbb.txt", "xyz.txt", "bbb_longer.txt" });
            //Debug.Assert(sortedLines.SequenceEqual(new List<String> { "aaa.txt", "bbb", "bbb.txt", "bbb_longer.txt", "test3.txt", "xyz.txt" }));
        }
    }
}
