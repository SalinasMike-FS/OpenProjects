using System;
//Mike Salinas
//30 Jan 2021
//APA
//API project
namespace API
{
    public class Comic
    {
        public string UID { get; set; }
        public string Title { get; set; }
        public string PublishYear  {get; set;}
        

        public Comic(string id, string name, string pY)
        {

            UID = id;
            Title = name;
            PublishYear = pY;
            
        }
    }
}
