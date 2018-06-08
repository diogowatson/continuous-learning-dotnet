using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp_tutorial13
{
    //Manipulating Lists : lambda, Where, ToList, Slect, Zip, Aggregate,
    //Averange, All, Any, Distinct, Except, Intersect

    class Program
    {
        delegate double doubleIt(double val);//to be referenced as lambda

        static void Main()
        {
            doubleIt dlIt = x => x * 2;
            Console.WriteLine($"5  * 2 = {dlIt(5)}");

            List<int> numList = new List<int>
            { 1,2,3,5,6,78,87};

            var evenList = numList.Where(a => a % 2 == 0).ToList();//show elements in the List that are even numbers

            foreach( var j in evenList)
                Console.WriteLine(j);

            //add values on a range in a LIst

            var rangeList = numList.Where(x => (x > 2) || (x < 9)).ToList();
            foreach (var j in rangeList)
                Console.WriteLine(j);

            //find the numbers of heads and tails that are fliped randonly
            //one =head 2= tail
            List<int> flipList = new List<int>();
            int i = 0;
            Random rnd = new Random();
            while (i< 100)
            {
                flipList.Add(rnd.Next(1, 3));
                i++;
            }

            //print it
            Console.WriteLine("Heads : {0}",
                flipList.Where(a=>a==1).ToList().Count());
            Console.WriteLine("Tail : {0}",
                flipList.Where(a => a == 2).ToList().Count());

            //find all names that start with a specif  letter

            List<string> nameList = new List<string>
            { "Diogo", "Ronaldo", "Felipe", "Juliano","Robert"};

            var sNameList = nameList.Where(x => x.StartsWith("R"));

            foreach (var m in sNameList)
                Console.WriteLine(m);

            //Select -> can execute a function for each item in the list
            var oneto10 = new List<int>();
            oneto10.AddRange(Enumerable.Range(1, 10));

            var squares = oneto10.Select(x => x * x);

            foreach (var m in squares)
                Console.WriteLine(m);

            //Zip -> Applies a function to two lists
            var listOne = new List<int>(new int[] { 1, 2, 3 });
            var listTwo = new List<int>(new int[] { 4, 6, 8 });

            //sum the lists
            var sumList = listOne.Zip(listTwo, (x, y) => x + y).ToList();

            foreach (var m in sumList)
                Console.WriteLine(m);

            //Aggregate -> do an operation in each item of the list
            //and carries the result foward
            var numList2 = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine("Sum : {0}",
                numList2.Aggregate((a,b)=> a+ b));

            //Averenge (the name say's it all)
            var NumList3 = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("Averange : {0}",
                NumList3.AsQueryable().Average());

            //ALL -> if all itens in a list meet a specific condition
            //(if all for example are bigger than 3)
            //the result is a boolean
            var numList4 = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("All > 3 : {0}",
                numList4.All(x => x>10));

            //Any -> checks if ANY of the itens meet the condition
            //the result is a boolean
            var numList5 = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("Any > 3 : {0}",
                numList4.Any(x => x > 3));

            //Distinct -> eliminates duplicates
            var numList6 = new List<int> { 1, 2, 2, 4, 2, 6, 6 };
            Console.WriteLine("Distinct : {0}",
                string.Join(", ", numList6.Distinct()));

            //Except -> receives 2 lists and return the values not found in the secons list
            var numList7 = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            var numList8 = new List<int> { 1 };
            Console.WriteLine("Except : {0}",
                string.Join(", ", numList7.Except(numList8)));

            //Intersect -> return values that both lists have
            var numList9 = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            var numList10 = new List<int> { 1,7 };
            Console.WriteLine("Intersect : {0}",
                string.Join(", ", numList7.Intersect(numList10)));



            //function to stop to close terminal
            Console.ReadLine( );
        }
    }

}
