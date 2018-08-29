using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp4
{   
    [Serializable]//To make class Serializable,use serializableAtrribute
    public class Animal : ISerializable
    { //to store these value in a file, and wants to re-use then make serialisation
        public String name { get; set; }
        public String color { get; set; }
        public int age { get; set; }
        public double weight { get; set; }

       

        public Animal(String name, String color, int age, double weight) //initialising the value to the global attribute
        {
           this.name = name;
           this.color = color;
           this.age = age;
           this.weight = weight;
        }
        public void value()
        {
            Console.WriteLine(age);
        }
        public Animal()
        {

        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)//Serialization
        {
            info.AddValue("name", name); //storing all value to be Serialized
            info.AddValue("color", color);
            info.AddValue("age", age);
            info.AddValue("weight", weight);

        }

        public Animal(SerializationInfo info, StreamingContext context)//Deserialization
        {
            name = (String)info.GetValue("name", typeof(String));//retrieveing store value from the SerializationInfo
            color = (String)info.GetValue("color", typeof(String));
            age = (int)info.GetValue("age", typeof(int));
            weight = (double)info.GetValue("weight", typeof(double));
        }
    }

    class XmlSerialization
    {
        static void Main(string[] args)
        {
             Animal animal = new Animal("cow", "white", 10, 150.4); //invoke arg constructor
            animal.value();

            FileStream file = new FileStream("J:\\C#Exception\\Animal.txt", FileMode.Create, FileAccess.Write);//serialize data and it stores in a file
            BinaryFormatter bf = new BinaryFormatter();//it will convert the data into binary format
            bf.Serialize(file, animal);//call the serialize function and passed in which stream and on which object serializalization is performed.
            file.Close();

            FileStream file1 = new FileStream("J:\\C#Exception\\Animal.txt", FileMode.Open, FileAccess.Read);//create fileStream object to read
            bf = new BinaryFormatter();
            animal = (Animal)bf.Deserialize(file1);//deserilaizing the serialized data present in file1 to object type(Animal)
            file1.Close();


            Console.WriteLine("=========================");


            FileStream file2 = new FileStream("J:\\C#Exception\\Animal1.xml", FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer xml = new XmlSerializer(typeof(Animal));//type of object
            xml.Serialize(file2, animal);//serialize the specified object and write xml docs to file
            file2.Close();

            FileStream file3 = new FileStream("J:\\C#Exception\\Animal1.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xml1 = new XmlSerializer(typeof(Animal));
            Object obj = xml1.Deserialize(file3);
            animal = (Animal)obj;
            file3.Close();

            Console.Read();
        }
    } 
    }

