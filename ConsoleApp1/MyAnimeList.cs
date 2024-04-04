using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeList
{
    public class MyAnimeList
    {
        public string MyAnime;
        List<Myalbum> animes = new List<Myalbum>();

        public void Addtolist(Myalbum anime_anime)
        {
            animes.Add(anime_anime);
        }
        public void SearchAnime(string AnimeName)
        {
            foreach (var Album in animes)
            {
                if (Album.AnimeName.Contains(AnimeName))
                {
                    Console.WriteLine("List of Anime:");
                    DisplayMyalbumInfo(Album);
                }
            }
        }
        public void DisplayMyalbumInfo(Myalbum anime_anime)
        {
            Console.WriteLine("๑(◕‿◕)๑๑(◕‿◕)๑๑(◕‿◕)๑");
            Console.WriteLine("ANIME TITLES: ");
            Console.WriteLine(anime_anime.AnimeName);
            Console.WriteLine(anime_anime.Title);
            Console.WriteLine(anime_anime.Type);
            Console.WriteLine(anime_anime.Premiered);
            Console.WriteLine(anime_anime.Status);
            Console.WriteLine(anime_anime.Duration);
            Console.WriteLine(anime_anime.Episodes);
            Console.WriteLine("٩(＾◡＾)۶٩(＾◡＾)۶٩(＾◡＾)۶");
        }
    

        }

            


    }