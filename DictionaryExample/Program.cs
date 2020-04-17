using System;
using System.Collections.Generic;                                                               //nameclass for using Dictionary

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalsDictionary = new Dictionary<string, string>();                           //key & value both string type
            animalsDictionary.Add("cage", "sparrow");                                           //Add method of dictionary
            animalsDictionary.Add("den", "lion");
            animalsDictionary.Add("aquarium", "fish");

            Console.WriteLine("Number of entries in dictionary: " + animalsDictionary.Count);   //Count property of dictionary
            foreach(var animal in animalsDictionary)                                            //var can be replaced by KeyValuePair<string, string>
            {
                Console.WriteLine(animal.Value + " is inside " + animal.Key);
            }
        }
    }
}
