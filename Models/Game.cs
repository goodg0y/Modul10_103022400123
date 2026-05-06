    namespace Modul10_103022400123.Models
{
    public class Game
    {
        public int id { get; set; }
        public string nama { get; set; }
        public string developer { get; set; }
        public int tahunRilis { get; set; }
        public string genre { get; set; }
        public double rating { get; set; }
        public string[] platform { get; set; }
        public string[] mode { get; set; }
        public Boolean isOnline { get; set; }
        public int harga { get; set; }

        public Game() { }

        

    }
}
