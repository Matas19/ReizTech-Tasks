using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating structure
            //level 1
            Branch branch = new Branch();
            //level 2
            branch.branches = new List<Branch> { new Branch(), new Branch() };
            //level 3
            branch.branches[0].branches = new List<Branch> { new Branch() };
            branch.branches[1].branches = new List<Branch> { new Branch(), new Branch(), new Branch() };
            //level 4
            branch.branches[1].branches[0].branches = new List<Branch> { new Branch() };
            branch.branches[1].branches[1].branches = new List<Branch> { new Branch(), new Branch() };
            //level 5
            branch.branches[1].branches[1].branches[0].branches = new List<Branch> { new Branch() };

            Console.WriteLine($"Given structure has {StructureDepth(branch)} level(-s)");
            Console.ReadKey();
        }
        public static int StructureDepth(Branch branch)
        {
            //list, to track each obejct's depth in given list of objects
            List<int> MaxDepth = new List<int>();
            //checks, if given Branch object's list is not empty
            if (branch.branches.Any())
            {
                //if list isn't empty, finds depth for each object in list and put it in MaxDepth list
                foreach(Branch item in branch.branches)
                {
                    MaxDepth.Add(StructureDepth(item)+1);
                }
                //returns biggest number, that was found
                return MaxDepth.Max();
            }
            // returns one to indicate last object in this branch and closes recursion loop
            else
            {
                return 1;
            }
            
        }
    }
}
