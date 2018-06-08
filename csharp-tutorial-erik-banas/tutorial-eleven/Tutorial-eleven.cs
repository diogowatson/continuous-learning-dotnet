using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace csharp_tutorial
{
    //Tutorial Eleven - Colections

    class Tutorial_eleven
    {
        public static void Main()
        {
            #region ArrayList code
            ArrayList aList = new ArrayList();
            //cleary the main difference between Java'a array lis is taht you 
            //dont need to declare the type, and you can have mixed types as weel

            aList.Add("bob");
            aList.Add(40);

            Console.WriteLine("count: {0}",
                aList.Capacity);

            ArrayList aList2 = new ArrayList();

            //how to put different object at once
            aList2.AddRange(new object[] { "Mike", "Sully", "sushi" });

            //mixed two list (can be tricky whith different data type)
            aList.AddRange(aList2);

            aList2.Sort();
            aList2.Reverse();
          //insert iten on position
            aList2.Insert(1, "turkey");

            //print an array list
            ArrayList range = aList2.GetRange(0, 2);

            foreach(object o in range)
            {
                Console.WriteLine(o);
            }

            //remove from index

            //aList2.RemoveAt(0);
            ////remove first 2 items
            //aList2.RemoveRange(0, 2);

            //serch from index

            Console.WriteLine("Turkey Index : {0}", aList2.IndexOf("Turkey", 0));

            //conver an Arrat to an array (in taht case an string array)
            string[] myArray = (string[])aList2.ToArray(typeof(string));

            //string aray to ArrayList
            string[] customers = { "Diogo", "Stella", "Denise" };
            ArrayList custArrayList = new ArrayList();
            custArrayList.AddRange(customers);

            #endregion

            #region Dictionary code
            //Dictionaries

            //In a dictionary define the kind of data for the pair
            //and the key

            Dictionary<string, string> superheroes = new Dictionary<string, string>();

            superheroes.Add("Clark Kent", "Superman");
            superheroes.Add("Billy Batson", "Captain Marvel");
            superheroes.Add("Steve Rogers", "Captain America");
            superheroes.Add("Bruce Wayne", "Batman");

            //remove a key or value
            superheroes.Remove("Billy Batson");

            //show number of keys
            Console.WriteLine("Number of lines ; {0}", superheroes.Count());

            //check if a key exist
            Console.WriteLine("Cheking if Clark Ken exists: {0}", superheroes.ContainsKey("Clark Kent"));

            //get the value from the key and store it in a variable

            superheroes.TryGetValue("Bruce Wayne", out string supername);

            Console.WriteLine($"Bruce Wayne : {supername}");

            //cycle throught

            foreach(KeyValuePair<string, string> item in superheroes)
            {
                Console.WriteLine("{0}: {1}",
                item.Key,
                item.Value);
            }

            //clear the dictionary
            superheroes.Clear();

            #endregion
            #region Queue

            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            foreach (object o in queue)
            {
                //they are put out in the same ordr they were put in
                Console.WriteLine(o);

            }

            //check if itemis in queue
            Console.WriteLine("1 in queue :{0}",queue.Contains(1));

            //remove first tiem from th equeu
            Console.WriteLine("remove 1: {0}",queue.Dequeue());

            foreach (object o in queue)
            {
               Console.WriteLine(o);
            }

            //check 1 item 
            Console.WriteLine("Peek 1 : {0}", queue.Peek());

            //copy the quee to an array
            object[] numArray = queue.ToArray();
            Console.WriteLine(string.Join(",",numArray));
            Console.WriteLine("print array:");
            Console.WriteLine(string.Join(",",numArray));

            //clear the queue
            queue.Clear();
            #endregion
            #region Stack
            //stack -> firat in first out collection

            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            //get the item whithout remove
            Console.WriteLine("Peek 1 : {0}", stack.Peek());

            //show and  remove the item from stack
            Console.WriteLine("Pop 1: {0}",stack.Pop() );

            //check if item exist

            Console.WriteLine("Contais 1 : {0}", stack.Contains(1));

            //copy stack to Array
            object[] numArray2 = stack.ToArray();
            Console.WriteLine(string.Join(",",numArray2));

            foreach (object o in stack)
            {
                Console.WriteLine($"Stack : {o}");
            }
            //clear stack
            stack.Clear();
            
            #endregion
            Console.ReadLine();
        }

    }//end of class

}//end of namespace
