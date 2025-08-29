namespace Songs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // Read number of songs
            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++) // Read song data
            {
                string[] songData = Console.ReadLine().Split('_'); 
                Song song = new Song
                {
                    TypeList = songData[0],
                    Name = songData[1],
                    Time = songData[2]
                };
                songs.Add(song);
            }

            string typeList = Console.ReadLine(); // Read the type list to filter by

            if (typeList == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songs.Where(s => s.TypeList == typeList)) // Using LINQ to filter songs by TypeList
                {
                    Console.WriteLine(song.Name);
                }
            }
        }

        public class Song // Song class definition
        {
            public required string TypeList { get; set; }
            public required string Name { get; set; }
            public required string Time { get; set; }
        }    
    }
}
