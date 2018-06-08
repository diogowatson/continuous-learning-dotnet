
using System;
//serialization packages
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace tutorial18
{
    //Serialization, Serialie, Deserialize, BinaryFormatter
    //XMLSerializer
    class Tutorialeightteen
    {
        public static void Main()
        {
            Animal bowser = new Animal("Bowser", 45, 25);

            Stream stream = File.Open("AnimalData.dat",
                FileMode.Create);//if dont exist, create the file

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(stream, bowser);
            stream.Close();

            //to prove the data was saved let's erase bowser data and restore it

            bowser = null;

            stream = File.Open("AnimalData.dat", FileMode.Open);

            bf = new BinaryFormatter();

            bowser = (Animal)bf.Deserialize(stream);//downcast to Animal
            stream.Close();

            Console.WriteLine(bowser.ToString());

            //prevent the console to close
            Console.ReadLine();
        }
       
}