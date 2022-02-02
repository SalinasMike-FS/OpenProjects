using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Net;
//Mike Salinas
//30 Jan 2021
//APA
//API project

namespace API
{
    public class APIConnect
    {
        public APIConnect()
        {
        }

        public dynamic Connect(string url)
        {
            dynamic jo;
            using (WebClient wc = new WebClient())
            {
                string results = wc.DownloadString(url);

                 jo = JObject.Parse(results);
                
            }

            return jo;
        }

        public List<Comic>GetComics()
        {
            List<Comic> comics = new List<Comic>();
            string url = "http://stapi.co/api/v1/rest/comics/search";

            dynamic jo = Connect(url);

            foreach(dynamic s in jo.comics)
            {
                string id = s.uid;
                string title = s.title;
                string pY = s.pY;
                
                Comic comic = new Comic(id, title, pY);
                comics.Add(comic);
            }

            return comics;
        }

        public List<ComicSeries> GetComicSeries(string uid)
        {
            List<ComicSeries> comicsSeries = new List<ComicSeries>();
            string url = "http://stapi.co/api/v1/rest/comics?uid=" + uid;
            dynamic jo = Connect(url);



            foreach (dynamic cs in jo.comics.comicSeries)
            {
                string id = cs.uid;
                string title = cs.title;
                
                ComicSeries comS = new ComicSeries(id, title);
                comicsSeries.Add(comS);
            }

            return comicsSeries;
        }
    }
}
