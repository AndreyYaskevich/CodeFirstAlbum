namespace CodeFirstAlbum
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        
        public int? AlbumId { get; set; }
        public Album Album { get; set; }
    }
}