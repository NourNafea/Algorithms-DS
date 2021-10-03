using System;
using System.Collections;

namespace Variables
{
    class Program{
        static void Main(string[] args)
        {
            Hashtable NoteBook = new Hashtable();
            NoteBook.Add(1,"Nour"); //add Key and Value
            NoteBook.Add(2,"Ali");
            NoteBook.Add(3, "Nader");


            //creating a Hashtable using collection-initializer syntax
            var cities = new Hashtable(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"Egypt", "Cairo, Alexandria, Luxor"}
            };

            foreach (DictionaryEntry item in NoteBook)
                Console.WriteLine("key:{0}, value:{1}",item.Key, item.Value);

            foreach (DictionaryEntry item in cities)
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);

        }

    }


}

