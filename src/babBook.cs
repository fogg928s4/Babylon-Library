using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Babylon.src {
    
    //Class that holds the Pages that are contained in a book
    //Each page has a defined amount of lines with a lenght of 85
    public class Page {
        //Each page contains 8 lines
        private static String[] lines = new String[8]; 
        //Length per line in characters
        private const int Length = 80;

        //list of accepted characters;
        //it includes the alphabet, the . , and space
        public char[] acceptedChars = {
            'a', 'b', 'c', 'd', 'e', 
            'f', 'g', 'h', 'i', 'j', 
            'k', 'l', 'm', 'n', 'o', 
            'p', 'q', 'r', 's', 't', 
            'u', 'v', 'w', 'x', 'y', 
            'z', '.', ',', ' '
        };
        private Random rnd;
        //method that fills a line
        public void fillLine() {
            //gets a random number
            rnd = new Random();
            rnd.
        }
    }

    class babBook {
        //properties
        private string title; //for the book's spine
        //number of pages per book
        private const int pagesN = 410;
        //Each book contains 
        private Page[] bookPages = new Page[410];

        //constructor
        public babBook(string titulo) {
            title = titulo;
        }

        
        
        //Method to show the contents of each page
    }
}
