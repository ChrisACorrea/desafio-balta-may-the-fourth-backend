namespace MayTheFourth.API.Helpers
{
    public static class Urls
    {
        public static string GetMoviesList => "/Movies/All";
        public static string GetMovieById => "/Movies/{Id}";
        public static string PostMovie => "/Movies";
        public static string PutMovieById => "/Movies/{Id}";
        public static string DeleteMovieById => "/Movies/{Id}";
        public static string GetCharactersList => "/Characters/All";
        public static string GetCharacterById => "/Characters/{Id}";
        public static string PostCharacter => "/Characters";
        public static string PutCharacterById => "/Characters/{Id}";
        public static string DeleteCharacterById => "/Characters/{Id}";
    }
}
