namespace Assignment04
{
    internal class Program
    {
        public static (double, double) CalcSumAndSubtract(double a, double b, double c, double d)
        {           
            double sum = a + b + c + d;
            double sub = d - c;
            return (sum, sub);
        }

        public static bool CheckIfPrimeOrNot(int n)
        {
            bool result = false;
            if (n < 2)
            {
                result = false;
            }

            for (int i = 2 ; i <= n/2; i++)
            {
                if (n % i == 0) 
                { 
                     result = false;
                    break;
                }
                else if (n % i == 1)
                {
                     result = true;
                }
            }
            return result;

        }

        public static (int,int) MinMaxArray(ref int[] cArray)
        {
            //int[] mArr = { 66, 11, 22, 44, 77, 88, 33 };
            int mmax = 0;
            int mmin = 0;
            mmax = cArray[0];
            mmin = cArray[0];
            for (int i = 0; i < cArray.Length; i++)
            {
                if (cArray[i] > mmax)
                    mmax = cArray[i];

                if (cArray[i] < mmin)
                    mmin = cArray[i];
            }
            return (mmin,mmax);
            
        }

        public static int Factorial(int n)
        {
            int fact ;
            if (n == 0) { return fact = 1; }
            else return n * Factorial(n - 1);
           
        }

        public static void Swap1(int x, int y)//5 3
        {
            int Temp = x;
            x = y;
            y = Temp;
        }

        public static void Swap2(ref int x, ref int y)//5 3
        {
            int Temp = x;
            x = y;
            y = Temp;
        }

        static int SumArray(ref int[] Arr)
        {
            int sum = 0;
            if (Arr is not null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    Arr = new int[3] { 4, 5, 6 };
                    Arr[i] = +2;
                    sum += Arr[i];
                }
            }
            return sum;
        }


        static void Main(string[] args)
        {

            #region 1-Mergy 2 arrays

            int[] arr1 = { 1, 3, 5, 7, 9 };
            int[] arr2 = { 2, 4, 6, 8, 10 };
            int[] arr3 = new int[arr1.Length + arr2.Length];

            int indexarr1 = 0;
            int indexarr2 = 0;

            for (int i = 0; i < arr3.Length; i++)
            {
                if (indexarr1 < arr1.Length && arr1[indexarr1] <= arr2[indexarr2])
                {
                    arr3[i] = arr1[indexarr1];
                    indexarr1++;
                }
                else if (indexarr2 < arr2.Length)
                {
                    arr3[i] = arr2[indexarr2];
                    indexarr2++;
                }
            }


            foreach (int ii in arr3)
            {
                Console.WriteLine(ii);
            }


            #endregion

            #region 2-frequency array's elements 

            int[] cArr1 = { 1, 2, 3, 4, 3, 2, 3 };
            int[] cArr2 = { -1, -1, -1, -1, -1, -1, -1 };
            int ctr;

            for (int i = 0; i < cArr1.Length; i++)
            {
                ctr = 1;
                for (int j = i + 1; j < cArr1.Length; j++)
                {
                    if (cArr1[i] == cArr1[j])
                    {
                        ctr++;
                        cArr2[j] = 0;

                    }
                }
                if (cArr2[i] != 0)
                {
                    cArr2[i] = ctr;
                }
            }
            for (int i = 0; i < cArr1.Length; i++)
            {

                if (cArr2[i] != 0)
                {
                    Console.WriteLine($"The frequency of elemnt {cArr1[i]} is {cArr2[i]}");
                }
            }

            #endregion

            #region 3-Max & Min element

            int[] mArr = { 66, 11, 22, 44, 77, 88, 33 };
            int max = 0;
            int min = 0;
            max = mArr[0];
            min = mArr[0];
            for (int i = 0; i < mArr.Length; i++)
            {
                if (mArr[i] > max)
                    max = mArr[i];

                if (mArr[i] < min)
                    min = mArr[i];
            }
            Console.WriteLine($"min element is {min}");
            Console.WriteLine($"Max element is {max}");


            #endregion

            #region 4-Second Largest element

            int[] slArr = { 7, 5, 1, 6, 9, 8, 4, 3, 0 };
            Array.Sort(slArr);
            Console.WriteLine($"Second largest elemnt is {slArr[slArr.Length - 2]}");

            #endregion

            #region 6-Reverse a text

            Console.Write("Enter text : ");
            string text = Console.ReadLine();
            string reversdtext = string.Join(" ", text.Split(' ').Reverse());
            Console.WriteLine(reversdtext);

            #endregion

            #region 7-Copy 2D array

            int[,] dArr1 = new int[3, 3];
            int[,] dArr2 = new int[3, 3];
            Console.WriteLine("Enter array elements : ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter element ({i},{j}) : ");

                    dArr1[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Array.Copy(dArr1, dArr2, dArr1.Length);

            Console.WriteLine("The Matrix is : ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($" {dArr2[i, j]}");
                }
                Console.WriteLine();
            }

            #endregion

            #region 8-Reverse 1D Array

            int[] rArr = new int[5];

            Console.WriteLine("Enter array elements");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter element {i + 1} : ");
                rArr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Reversed array is ");
            for (int i = rArr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(rArr[i]);
            }

            #endregion

            #region 9-Passing By Value & Reference [Value Type]

            int x = 5;
            int y = 3;
            Swap1(x, y);// x = 3 and y = 5 and temp = 5

            Swap2(ref x, ref y); //temp = 5



            #endregion

            #region 10-Passing By Value & Reference [Reference Type]

            int [] ssArr = new int [3] { 1, 2, 3};
            Console.WriteLine( SumArray(ref ssArr)); //sum = 6

            #endregion

            #region 11-Sum & Sub function 

            double num1;
            double num2;
            double num3;
            double num4;
            bool flag1;

            do
            {
                Console.Write("Enter num1 :");
                flag1 = double.TryParse(Console.ReadLine(), out num1);

            } while (!flag1);
            bool flag2;
            do
            {
                Console.Write("Enter num2 :");
                flag2 = double.TryParse(Console.ReadLine(), out num2);

            } while (!flag2);
            bool flag3;
            do
            {
                Console.Write("Enter num3 :");
                flag3 = double.TryParse(Console.ReadLine(), out num3);

            } while (!flag3);
            bool flag4;
            do
            {
                Console.Write("Enter num4 :");
                flag4 = double.TryParse(Console.ReadLine(), out num4);

            } while (!flag4);

            (double sum, double sub) = CalcSumAndSubtract(num1, num2, num3, num4);

            Console.WriteLine($"Sum is {sum}");
            Console.WriteLine($"Sub is {sub}");

            #endregion

            #region 12-Sum of 1num

            Console.Write("Enter num : ");
            int.TryParse(Console.ReadLine(), out int num);
            int rem = num % 10;
            int isum = 0;
            num /= 10;
            isum += rem;
            rem = num % 10;
            num /= 10;
            isum += rem;

            Console.WriteLine("Sum is " + isum);

            #endregion

            #region 13-CheckPrimeOrNot

            bool nflag;
            int prnum;
            do
            {
                Console.Write("Enter number :");
                nflag = int.TryParse(Console.ReadLine(), out prnum);

            } while (!nflag);

            bool result = CheckIfPrimeOrNot(prnum);
            Console.WriteLine(result);


            #endregion

            #region 14-MinMaxArray funcrion

            int[] myArr = { 66, 11, 22, 44, 77, 88, 33 };

            (int mmin, int mmax) = MinMaxArray(ref myArr);
            Console.WriteLine(mmin);
            Console.WriteLine(mmax);


            #endregion


            #region 15-factorial

            bool fflag;
            int fnum;
            do
            {
                Console.Write("Enter num :");
                fflag = int.TryParse(Console.ReadLine(), out fnum);

            } while (!fflag);


            Console.WriteLine(Factorial(fnum));



            #endregion

        }
    }
}
