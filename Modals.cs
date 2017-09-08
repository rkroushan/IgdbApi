using System.Collections.Generic;

namespace IgdbAPI
{
    public class BasicEntity
    {
        public long id { get; set; }

        public string name { get; set; }
        public string slug { get; set; }
        public string url { get; set; }

        public long created_at { get; set; }
        public long updated_at { get; set; }

        public List<long> games { get; set; }

        public BasicEntity()
        {
            games = new List<long>();
        }
    }

    public class Rating
    {
        public int rating { get; set; }
        public string synopsis { get; set; }
    }

    public class Image_Base
    {
        public string url { get; set; }
        public string cloudinary_id { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Game : BasicEntity
    {
        public string summary { get; set; }
        public string storyline { get; set; }

        public int hypes { get; set; }
        public double rating { get; set; }
        public double popularity { get; set; }
        public double aggregated_rating { get; set; }
        public int aggregated_rating_count { get; set; }
        public double total_rating { get; set; }
        public int total_rating_count { get; set; }
        public int rating_count { get; set; }
        public int category { get; set; }
        public long collection { get; set; }
        public long first_release_date { get; set; }
        public int status { get; set; }



        public List<long> tags { get; set; }
        public List<long> themes { get; set; }
        public List<long> genres { get; set; }
        public List<long> keywords { get; set; }
        public List<long> developers { get; set; }
        public List<long> publishers { get; set; }
        public List<long> game_modes { get; set; }
        public List<long> game_engines { get; set; }

        public PEGI pegi { get; set; }
        public ESRB esrb { get; set; }
        public Cover cover { get; set; }

        public List<Website> websites { get; set; }
        public List<Image> screenshots { get; set; }
        public List<ReleaseDate> release_dates { get; set; }
        public List<Alternative_name> alternative_names { get; set; }

        public Game()
        {
            tags = new List<long>();
            themes = new List<long>();
            genres = new List<long>();
            keywords = new List<long>();
            developers = new List<long>();
            publishers = new List<long>();
            game_modes = new List<long>();
            game_engines = new List<long>();

            pegi = new PEGI();
            esrb = new ESRB();
            cover = new Cover();
            websites = new List<Website>();
            screenshots = new List<Image>();
            release_dates = new List<ReleaseDate>();
            alternative_names = new List<Alternative_name>();
        }
    }


    public class People : BasicEntity
    {

    }

    public class Franchise : BasicEntity
    {

    }

    public class Company : BasicEntity
    {
        public Image logo { get; set; }
        public string description { get; set; }
        public int country { get; set; }
        public string website { get; set; }

        public long start_date { get; set; }
        public int start_date_category { get; set; }
        public long changed_company_id { get; set; }
        public long change_date { get; set; }
        public int change_date_category { get; set; }

        public string twitter { get; set; }
        public string facebook { get; set; }

        public List<long> published { get; set; }
        public List<long> developed { get; set; }

        public Company()
        {
            logo = new Image();
            published = new List<long>();
            developed = new List<long>();
        }

    }

    public class Game_Engine : BasicEntity
    {
        public Image logo { get; set; }
        public List<long> platforms { get; set; }
        public List<long> companies { get; set; }

        public Game_Engine()
        {
            logo = new Image();
            platforms = new List<long>();
            companies = new List<long>();
        }
    }

    public class Website
    {
        public string url { get; set; }
        public int category { get; set; }
    }

    public class Cover : Image_Base
    {

    }

    public class ESRB : Rating
    {

    }

    public class PEGI : Rating
    {

    }

    public class Alternative_name
    {
        public string name { get; set; }
        public string comment { get; set; }
    }

    public class Image : Image_Base
    {

    }

    public class Collection : BasicEntity
    {

    }

    public class ReleaseDate
    {
        public long id { get; set; }
        public long game { get; set; }
        public int category { get; set; }
        public long platform { get; set; }
        public string human { get; set; }
        public long created_at { get; set; }
        public long updated_at { get; set; }
        public long date { get; set; }
        public int region { get; set; }
        public int y { get; set; }
        public int m { get; set; }
    }

    public class Genre : BasicEntity
    {

    }

    public class Keyword : BasicEntity
    {

    }

    public class Platform : BasicEntity
    {
        public string shortcut { get; set; }
        public string website { get; set; }
        public string summary { get; set; }
        public string alternative_name { get; set; }
        public Image logo { get; set; }

        public Platform()
        {
            logo = new Image();
        }
    }

    public class Theme : BasicEntity
    {

    }
}
