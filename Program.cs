using System;
using enumeracaoc.entities;

namespace enumeracaoc
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment(" bacana");
            Comment c2 = new Comment("melhor ainda");
            Post p1 = new Post ( DateTime.Parse("21/06/2018 13:05:22"),"aquilo mesmo","e agora ou nunca",12);
            p1.AddPost(c1);
            p1.AddPost(c2);

            Comment c3 = new Comment(" bacana");
            Comment c4 = new Comment("melhor ainda");
            Post p2 = new Post(DateTime.Parse("21/06/2018 13:05:22"), "aquilo mesmo", "e agora ou nunca", 12);
            p2.AddPost(c3);
            p2.AddPost(c4);

            System.Console.WriteLine(p1);
            System.Console.WriteLine(p2);




        }





            
        
    }
}
