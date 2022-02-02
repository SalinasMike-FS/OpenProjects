using System;
//Mike Salinas
//30 Jan 2021
//APA
//API project
namespace API
{
    public class ComicSeries
    {

        public string UID { get; }
        public string Title { get; }
        

        public ComicSeries(string id, string title)
        {
            UID = id;
            Title = title;
            
        }
    }
}
