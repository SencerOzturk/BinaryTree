using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] BinaryTree = new int[6];
            BinaryTree[0] = 0;
            BinaryTree[1] = 1;
            BinaryTree[2] = 2;
            BinaryTree[3] = 3;
            BinaryTree[4] = 4;
            BinaryTree[5] = 5;
          
            TreeYaz(BinaryTree, 0);
            Console.ReadKey();
        }

        //0 1 3 7 /8 /4 9/ 10 2 5 11 12 6 





        static int[] BinaryTree = new int[5];



        static void TreeYaz(int[] tree,int indis) //her return yedıgınde bır alttakını calıstırıyor.
        {

            if (indis >= 5) return;

            TreeYaz(tree, indis * 2 + 2);
            TreeYaz(tree, indis * 2 + 1);
            Console.WriteLine(tree[indis]);


        }


    }
}
