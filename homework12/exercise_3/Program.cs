using System;

namespace exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HTML hTML = new HTML();
            hTML.Header();
            hTML.Body();
            hTML.Footer();
            Console.WriteLine();
            File file = new File();
            file.Header();
            file.Body();
            file.Footer();
        }
    }

  

    public interface Reporti 
    {
        public void Header() { }
        public void Body() { }
        public void Footer() { }
    }

    public class HTML : Reporti
    {
        public void Header()
        {
            Console.WriteLine("<header> My Header </header>");
        }
        public void Body()
        {
            Console.WriteLine("<body> \nVideo provides a powerful way to help you prove your point. When you click Online Video, you can paste in the embed code for the video you want to add. </body>");
        }
        public void Footer()
        {
            Console.WriteLine("<footer> My Footer </footer>");
        }
    }
    public class File : Reporti
    {
        public void Header()
        {
            Console.WriteLine("I’m using Facade Pattern");
        }
        public void Body()
        {
            Console.WriteLine("Video provides a powerful way to help you prove your point. When you click Online Video, you can paste in the embed code for the video you want to add. You can also type a keyword to search online for the video that best fits your document.To make your document look professionally produced, Word provides");
        }
        public void Footer()
        {
            Console.WriteLine("Page 1.");
        }
    }

}
