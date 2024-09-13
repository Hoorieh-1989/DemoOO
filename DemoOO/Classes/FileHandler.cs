using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOO.Classes
{
 //Tanken med denna klass är att samla allt som har att göra 
 // med Textfiler på ett ställe i applikationen
    public class FileHandler

    {
        //this is called the instantsvariable and the nameset with
        //sign _ in the begining. Inkapslad i klassen
        private string _filePath;

        public FileHandler(string filePath)
        {
            _filePath = filePath;
        }
        public void WriteToFile(string text)
        {
            using (StreamWriter writer = new StreamWriter(_filePath,true))
            {
                writer.WriteLine(text);
            }
        }
    }
}
