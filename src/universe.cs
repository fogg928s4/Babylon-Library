using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Babylon.src {
    //This class does all the creation of stuff and random lettes
    public abstract class Universe {
        //thse are the chars that the library can contain 
        //members  musut be static so all static methods can acces em
        public static char[] acceptedChars = {
            'a', 'b', 'c', 'd', 'e',
            'f', 'g', 'h', 'i', 'j',
            'k', 'l', 'm', 'n', 'o',
            'p', 'q', 'r', 's', 't',
            'u', 'v', 'w', 'x', 'y',
            'z', '.', ',', ' '
        };
        
        //method that gets a random string 
        public static string createWisdom(int length) {
            //gets a random number
            
            String wisdom = ""; //the randomized string
            Random rnd = new Random();

            for (int i = 0; i<= length; i++) {
                
                wisdom+=acceptedChars[rnd.Next(0, acceptedChars.Length - 1)];
            }

            return wisdom;

        }
    }
}
