using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Кубик_рубика
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader Rd = new StreamReader(@"input_s1_20.txt");
            int b;
            string a = Rd.ReadLine();
            string[] A = a.Split(new char[] { ' ' });
            int[] B = new int[A.Length];
            string[] Move0; int[] Move;
            for (int i = 0; i < A.Length; i++) { B[i] = Convert.ToInt32(A[i]); }
            a = Rd.ReadLine();
            A = a.Split(new char[] { ' ' });
            int[] Cord = new int[A.Length];
            for (int i = 0; i < A.Length; i++) { Cord[i] = Convert.ToInt32(A[i])-1; }
            int n = B[0]-1;
            for (int i = 0; i < B[1]; i++)
            {
                a = Rd.ReadLine();
                Move0 = a.Split(new char[] { ' ' });
                Move = new int[Move0.Length-1];
                string w = Move0[0];
                for (int t = 1; t < 3; t++) { Move[t-1] = Convert.ToInt32(Move0[t]); }
                if (((w == "X") && (Move[0]-1 == Cord[0]))|| ((w == "Y") && (Move[0]-1 == Cord[1]))|| ((w == "Z") && (Move[0]-1 == Cord[2])))
                {
                    if ((w == "X") && (Move[1]==1)) 
                    {
                        b = Cord[1]; Cord[1] = Cord[2]; Cord[2] = n - b;
                    }
                    else if ((w == "X") && (Move[1] == -1))
                    {
                        b = Cord[2]; Cord[2] = Cord[1]; Cord[1] = n - b;
                    }
                    else if ((w == "Y") && (Move[1] == 1))
                    {
                        b = Cord[0]; Cord[0] = Cord[2]; Cord[2] = n - b;
                    }
                    else if ((w == "Y") && (Move[1] == -1))
                    {
                        b = Cord[2]; Cord[2] = Cord[0]; Cord[0] = n - b;
                    }
                    else if ((w == "Z") && (Move[1] == 1))
                    {
                        b = Cord[0]; Cord[0] = Cord[1]; Cord[1] = n - b;
                    }
                    else if ((w == "Z") && (Move[1] == -1))
                    {
                       b = Cord[1]; Cord[1] = Cord[0]; Cord[0] = n - b;
                    }
                    
                }
                
            }
            Console.WriteLine("{0} {1} {2}", Cord[0] + 1, Cord[1] + 1, Cord[2] + 1);
        }
    }
}
