
using System;
using System.Collections.Generic;
using enumeracaoc.entities;
using System.Text;



namespace enumeracaoc.entities
{
    public class Post
    {
        DateTime Moment { get; set; }
        
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        List<Comment> comments { get; set; } = new List<Comment>();

        public Post()
        {

        }
        public Post(DateTime moment,string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;

        }

        public void AddPost(Comment comment){

            comments.Add(comment);




        }

        public void RemovePost(Comment comment){

            comments.Remove(comment);

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach(Comment c in comments ){

                sb.AppendLine(c.Text);
            }
            return sb.ToString();



        }

    }
}
