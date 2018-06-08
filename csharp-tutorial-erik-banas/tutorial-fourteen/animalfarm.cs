using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_tutorial_14
{
    class AnimalFarm : IEnumerable
    {
        private List<Animal> animalList = new List<Animal>();

        public AnimalFarm(List<Animal> animalList)
        {
            this.animalList = animalList;
        }

        public AnimalFarm()
        {

        }

        public Animal this[int index]//indexer
        {
            //this set how to get/set from the collection
            get { return (Animal)animalList[index]; }
            set { animalList.Insert(index, value); }
        }

        public int Count { get { return animalList.Count; } }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return animalList.GetEnumerator();
        }

    }//end of AnimalFarm 
}
