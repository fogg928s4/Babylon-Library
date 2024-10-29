using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Babylon;

namespace Babylon.src {
    
    //Class that holds the Pages that are contained in a book
    //Each page has a defined amount of lines with a lenght of 85
    public class Page :  System.Windows.Forms.TextBox {

        //Properties inherited
        
        //the lines of each page
        public String[] renglones = new String[8];


        //Constructor
        public Page(string s) {
            //this.ReadOnly = true;
            this.Name = s;
            this.Multiline = true;
            this.Width = 920;
            this.Height = 360;
            this.Lines = new string[8];
            fillPage();
        }
        public Page() {
            //this.ReadOnly = true;

            this.Multiline = true;
            this.Width = 920;
            this.Height = 360;
            this.Lines = new string[8];
            fillPage();
        }

        //This will fill each lne of the page with random stuff
        public void fillPage() {

            for (int i = 0; i < 8; i++) {
                this.Lines[i] = Universe.createWisdom(80);
                this.Text += this.Lines[i];
                this.Text += "\r\n";

            }
        }
    }

    class babBook {
        //properties
        private string title; //for the book's spine
        
        //number of pages per book
        private const int pagesN = 410;
        
        //Each book contains 410 pages
        private Page[] bookPages = new Page[410];



        //constructors
        public babBook() {
            title = Universe.createWisdom(10);
        }
        //constructor w args
        public babBook(string titulo) {
            title = titulo;
        }       


        //Method to show the contents of each 
    }

}
