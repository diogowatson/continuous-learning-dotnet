using System;
using System.Runtime.Serialization;

namespace csharp_tutorial_18
{
    [Serializable()]//define that you want to serialize the class
    public class Animal : ISerializable
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int AnimalID { get; set; }

        public Animal() { }

        public Animal(string name = "No Name", double weight = 0,
            double height = 0)
        {
            Name = name;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return string.Format("{0} weighs {1} lbs and is {2} inches tall",
                Name, Weight, Height);
        }

        //serialization function
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            //assign key value pair
            info.AddValue("Name", Name);
            info.AddValue("Weight", Weight);
            info.AddValue("Height", Height);
            info.AddValue("AnimalID", AnimalID);
        }

        //desererilize constructor (extract object data from the file)
        public Animal(SerializationInfo info, StreamingContext context)
        {
            //get values from data and asign them to this object properties
            Name = (string)info.GetValue("Name", typeof(String));
            Weight = (double)info.GetValue("Weight", typeof(double));
            Height = (double)info.GetValue("Height", typeof(double));
            AnimalID = (int)info.GetValue("AnimalID", typeof(int));
        }

    }//end of class

}//end of namespace

