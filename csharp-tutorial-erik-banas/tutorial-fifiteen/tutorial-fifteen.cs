using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_tutorial_15
{
    class TutorialFifteen
    {
        static void Main()
        {
            QueryStringArray();
            int[] intArray = QueryIntArray();

            foreach(int i in intArray)
                Console.WriteLine(i);

            Console.WriteLine();

            QueryArrayList();

            QueryCollection();

            QueryAnimalData();

            Console.ReadLine();
        }

        //creating an querry string to manipulate
        static void QueryStringArray()
        {
            string[] dogs = {"k 9", "Brian Griffin",
            "Scooby Doo", "Old Yeller", "Rin Tin Tin",
            "Benji", "Charlie Barkin", "Lassie", "Snoopy"};

            //want strings with spaces
            //looks a lot like SQL...
            var dogSpaces = from dog in dogs
                            where dog.Contains(" ")
                            orderby dog ascending
                            select dog;
            foreach (var i in dogSpaces)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
        }//end of string Query

        ///creating an int querry
        static int[] QueryIntArray()
        {
            int[] nums = { 5, 10, 15, 20, 25, 30, 35 };
            //getting numbers bigger than 20
            var get20 = from num in nums
                        where num > 20
                        orderby num
                        select num;
            foreach(var i in get20)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            Console.WriteLine($"Get Type ; {get20.GetType()}");
            //converting into a list
            var listget20 = get20.ToList<int>();
            //converting to an array
            var arrayGet20 = get20.ToArray<int>();

            //if tha data changes the quwry updates
            nums[0] = 40;

            foreach(ValueType i in get20)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            return arrayGet20;
        }

        //creating Query ArayyList

        static void QueryArrayList()
        {
            ArrayList famAnimals = new ArrayList()
            {
                new Animal
                {
                  Name = "Heidi",
                  Height = .8,
                  Weight = 18
                },

                 new Animal
                {
                  Name = "Shrek",
                  Height = 4,
                  Weight = 130
                },

                  new Animal
                {
                  Name = "Godzilla",
                  Height = 25,
                  Weight = 1000000
                }
            };

            //convert ArrayList to Ienumerable
            var famAnimalEnum = famAnimals.OfType<Animal>();

            var smAnimals = from animal in famAnimalEnum
                            where animal.Weight <= 90
                            orderby animal.Name
                            select animal;
            foreach(var animal in smAnimals)
                Console.WriteLine("{0} wighs {1}lbs",
                    animal.Name, animal.Weight);
            Console.WriteLine();
        }//end of querry ArrayList

        static void QueryCollection()
        {
            var animalList = new List<Animal>()
            {
                new Animal
                {
                    Name = "Germam Shepper",
                    Height = 25,
                    Weight = 77
                },
                new Animal
                {
                    Name = "Chihuahua",
                    Height = 7,
                    Weight = 4.4
                },
                new Animal
                {
                    Name = "Saint bernard",
                    Height = 30,
                    Weight = 200
                }

            };

            var bigDogs = from dog in animalList
                          where (dog.Weight > 70) &&
                          (dog.Height > 25)
                          orderby dog.Name
                          select dog;

            foreach(var dog in bigDogs)
            {
                Console.WriteLine(" A {0} wighs {1}lbs",
                    dog.Name, dog.Weight);
            }
            Console.WriteLine();
        }//end of querry collection

        static void QueryAnimalData()
        {
            Animal[] animals = new[]
            {
                new Animal
                {
                    Name = "Germam Shepper",
                    Height = 25,
                    Weight = 77,
                    AnimalId = 1
                },

                 new Animal
                {
                    Name = "Chihuahua",
                    Height = 7,
                    Weight = 4.4,
                    AnimalId = 2
                },

                  new Animal
                {
                    Name = "Saint Bernard",
                    Height = 30,
                    Weight =200,
                    AnimalId = 3
                },

                   new Animal
                {
                    Name = "Pug",
                    Height = 12,
                    Weight = 16,
                    AnimalId = 1
                },
                    new Animal
                {
                    Name = "Beagle",
                    Height = 15,
                    Weight = 23,
                    AnimalId = 2
                },

            };

            //join dogs and owners by id
            Owner[] owners = new[]
            {
                new Owner
                {
                    Name = "Doug Parks",
                    OwnerID = 1
                },

                 new Owner
                {
                    Name = "Sally Smith",
                    OwnerID = 2
                },

                  new Owner
                {
                    Name = "Paul Brooks",
                    OwnerID = 3
                }
            };

            //remove name and height
            var nameHeight = from a in animals
                             select new
                             {
                                 a.Name,
                                 a.Height
                             };
            //conver to an object array
            Array arrNameheight = nameHeight.ToArray();

            foreach (var i in arrNameheight)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine();

            var innerJoin = from animal in animals
                            join owner in owners on animal.AnimalId
                            equals owner.OwnerID
                            select new
                            {
                                OwnerName = owner.Name,
                                AnimalName = animal.Name
                            };

            foreach (var i in innerJoin)
            {
                Console.WriteLine("{0} owns {1}", i.OwnerName, i.AnimalName);

            }
                Console.WriteLine();

            //group inner join
            var groupJoin = from owner in owners
                            orderby owner.OwnerID
                            join animal in animals on owner.OwnerID
                            equals animal.AnimalId into ownerGroup
                            select new
                            {
                                Owner = owner.Name,
                                Animals = from owner2 in ownerGroup
                                          orderby owner2.Name
                                          select owner2
                            };

            int totalAnimals = 0;

            foreach(var ownerGroup in groupJoin)
            {
                Console.WriteLine(ownerGroup.Owner);
                foreach( var animal in ownerGroup.Animals)
                {
                    totalAnimals++;
                    Console.WriteLine("* {0}", animal.Name);
                }
            }

        }
    }//end of tutorail class
    
}//end of namespace
