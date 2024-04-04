using System.Runtime.Serialization;
using AnimeList;

namespace ConsoleApp2

{
    internal class Program
    {
            static void Main(string[] args)
        {
            MyAnimeList ListOfAnime = new MyAnimeList();
            MyAnimeList show = new MyAnimeList();

            Myalbum one = new Myalbum
            {
                AnimeName = "Andeddo Anrakku",
                Title = "Undead Unluck",
                Type = "TV",
                Premiered = "Fall 2023",
                Status = "Completed",
                Duration = "23 min",
                Episodes = "24 episodes",
            };
            Myalbum two = new Myalbum
            {
                AnimeName = "Kusoge Hunter, Kamige ni Idoman to su",
                Title = "Shangri-La Frontier",
                Type = "TV",
                Premiered = "Fall 2023",
                Status = "Completed",
                Duration = "25 min",
                Episodes = "24 episodes",
            };
            Myalbum three = new Myalbum
            {
                AnimeName = "Mahō Tsukai no Yome",
                Title = "The Ancient Magus' Bride",
                Type = "TV",
                Premiered = "Fall 2017",
                Status = "Completed",
                Duration = "24 min",
                Episodes = "24 episodes",
            };
            Myalbum four = new Myalbum
            {
                AnimeName = "ワンピース, Wan Pīsu?",
                Title = "One Piece",
                Type = "TV",
                Premiered = "Fall 1999",
                Status = "Ongoing",
                Duration = "24 min",
                Episodes = "1099 episodes",
            };
            Myalbum five = new Myalbum
            {
                AnimeName = "Saikyō Tank no Meikyū Kōryaku",
                Title = "Sengoku Youko",
                Type = "TV",
                Premiered = "Winter 2024",
                Status = "Completed",
                Duration = "23 min",
                Episodes = "13 episodes",
            };
            Myalbum Six = new Myalbum
            {
                AnimeName = " Bātendā: Kami no Gurasu",
                Title = "BARTENDER Glass of God",
                Type = "TV",
                Premiered = "Spring 2024",
                Status = "Releasing",
                Duration = "24-25 min",
                Episodes = "Ongoing",
            };
            ListOfAnime.Addtolist(one);
            ListOfAnime.Addtolist(two);
            ListOfAnime.Addtolist(three);
            ListOfAnime.Addtolist(four);
            ListOfAnime.Addtolist(five);
            ListOfAnime.Addtolist(Six);

            Console.WriteLine("(◐ω◑ )Anime Suge(◐ω◑ )");
            Console.WriteLine("Search Anime");
            Console.WriteLine("1. Undead Unluck");
            Console.WriteLine("2. Shangri-La Frontier");
            Console.WriteLine("3. The Ancient Magus' Bride");
            Console.WriteLine("4. One Piece");
            Console.WriteLine("5. Sengoku Youko");
            Console.WriteLine("6. BARTENDER Glass of God");
            Console.WriteLine("ლ(́◉◞౪◟◉‵ლ)ლ(́◉◞౪◟◉‵ლ)ლ(́◉◞౪◟◉‵ლ)");

            int Animecode = Convert.ToInt32(Console.ReadLine());
            switch (Animecode)
            {
                case 1:
                    show.DisplayMyalbumInfo(one);
                    break;
                case 2:
                    show.DisplayMyalbumInfo(two);
                    break;
                case 3:
                    show.DisplayMyalbumInfo(three);
                    break;
                case 4:
                    show.DisplayMyalbumInfo(four);
                    break;
                case 5:
                    show.DisplayMyalbumInfo(five);
                    break;
                case 6:
                    show.DisplayMyalbumInfo(Six);
                    break;
                default:
                    Console.WriteLine("Search another Anime");
                    break;

            }



        }
    }
  }

