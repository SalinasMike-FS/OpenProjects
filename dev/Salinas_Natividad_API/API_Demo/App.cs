using System;
using System.Collections.Generic;
//Mike Salinas
//30 Jan 2021
//APA
//API project
namespace API
{
    public class App
    {
        public App()
        {

            APIConnect api = new APIConnect();
            
            List<Comic> comics = api.GetComics();
            Menu seasonMenu = new Menu();

            foreach(Comic c in comics)
            {
                seasonMenu.Init("Comics", c.Title);
            }

            seasonMenu.Display();

            Console.WriteLine("Which of these Comics would you like to learn more about?");
            string userSeasonChoice = Console.ReadLine();
            int input = Validation.Integer(userSeasonChoice);
            string uid = comics[input - 1].UID;
            Console.WriteLine(uid);

            List<ComicSeries> comicSeries = api.GetComicSeries(uid);

            foreach (ComicSeries cs in comicSeries)
            {
                Console.WriteLine(cs.Title);
            }
        }
    }
}
