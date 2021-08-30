using System;
using System.Collections.Generic;
using System.Text;

namespace Sigendenavn
{
    class HelloWorld
    {
        // Property to show on console
        private string textToShow;

        public string TextToShow
        {
            get
            {
                return textToShow;
            }
            set
            {
                textToShow = value;
            }
        }

        public void Print()
        {
            Console.WriteLine(textToShow);
            
        }


    }
}
