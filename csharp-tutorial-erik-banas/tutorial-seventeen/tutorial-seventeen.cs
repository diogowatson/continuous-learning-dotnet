using System;
using System.Text;
//libaries to work with files
using System.IO;
using System.Text;

namespace csharp_tutorial_17
{
    //File Systme, File, DirectoryInfo, FileInfo, FileStream
    //StreamWriter, StreamReader, BinaryWriter, BinaryReader

    class Tutorial_seventeen
    {
        static void Main()
        {
            //I'm using a directory structure of my own computer
            //In another computer this code (or most of it) wont work whithout
            //some changes

            //find my current directory
            DirectoryInfo currDir = new DirectoryInfo(".");
            Console.WriteLine($"Current dire ctory : {currDir}");

            DirectoryInfo diogoDir = new DirectoryInfo(@"C:\Users\Diogo\Documents\diogo");
            Console.WriteLine($"diogo dir : {diogoDir}");
            //deleting a directory (I will leave thos commented for obvius reasons)
           // Directory.Delete(@"C:\Users\diogo\data");

            string[] customers =
            {
                "Bob Smith",
                "Sally Smith",
                "Robert Smith"
            };

            string textFilePath = @"C:\Users\Diogo\Documents\diogo\data\testfile1.txt";

            File.WriteAllLines(textFilePath, customers);

            foreach(string cust in File.ReadAllLines(textFilePath))
            {
                Console.WriteLine($"Customer : {cust} ");
            }

            DirectoryInfo mydataDir = new DirectoryInfo(@"C:\Users\Diogo\Documents\diogo\data");

            FileInfo[] txtFiles = mydataDir.GetFiles("*.txt",
                SearchOption.AllDirectories);

            Console.WriteLine("Matches : {0}",
                txtFiles.Length);

            foreach(FileInfo file in txtFiles)
            {
                Console.WriteLine(file.Name);
                //nnumber of bythes in file
                Console.WriteLine(file.Length);

            };

            //path of file to be created
            string textFilePath2 = @"C:\Users\Diogo\Documents\diogo\data\testfile1.txt2";

            //streams

            //creating file
            FileStream fs = File.Open(textFilePath2,
                FileMode.Create);
            //now save a string on it
            string randString = "This is a random string";

            //to store need to convert in a byte array

            byte[] rsByteArray = Encoding.Default.GetBytes(randString);

            fs.Write(rsByteArray, 0, rsByteArray.Length);//array to be write, position, lenght

            fs.Position = 0;

            byte[] fileByteArray = new byte[rsByteArray.Length];

            //put the bytes inside the array
            for (int i = 0; i< rsByteArray.Length; i++)
            {
                fileByteArray[i] = (byte)fs.ReadByte();
            }

            Console.WriteLine(Encoding.Default.GetString(fileByteArray));

            //close the 


            fs.Close();
            //stream readers
            //best for reading strings
            //defining path and creating new file
            string textFilePath3 = @"C:\Users\Diogo\Documents\diogo\data\testfile1.txt2";
            StreamWriter sw = File.CreateText(textFilePath3);

            //writing in the file
            sw.Write("This is random text");
            sw.WriteLine("sentence");
            sw.WriteLine("This is another sentence");
            sw.Close();

            //open the file for reading

            StreamReader sr = File.OpenText(textFilePath3);
            //peek -> return as unicode
            Console.WriteLine("peek : {0}", Convert.ToChar(sr.Peek()));

            Console.WriteLine("1st String : {0}",
                sr.ReadLine());
            //grab everything that's left
            Console.WriteLine("Everything : {0}",
                sr.ReadToEnd());
            sr.Close();

            //binary writers and readers
            //is a tutorial so it's not using any safeguards
            //in a normal situation I would use try/catch reading/writing a file
            string textFilePath4 = @"C:\Users\Diogo\Documents\diogo\data\testfile4.txt";

            FileInfo datFile = new FileInfo(textFilePath4);

            BinaryWriter bw = new BinaryWriter(datFile.OpenWrite());

            //create data
            string randText = "Random text";
            int Age = 30;
            double height = 6.25;

            bw.Write(randText);
            bw.Write(Age);
            bw.Write(height);

            bw.Close();

            //now reading the file

            BinaryReader br = new BinaryReader(datFile.OpenRead());

            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadDouble());

            br.Close();

            Console.ReadLine();
        }//end of Main
    }
}
