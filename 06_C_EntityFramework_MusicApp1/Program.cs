namespace _06_C_EntityFramework_MusicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MusicAppDbContext db = new();

            //1. Відображення треків певного альбома, кількість прослуховувань яких більша середнього значення по всіх треках даного альбома
            string AlbName = "AlbName";
            var songs = db.Songs.Where(x => x.Album.Name == AlbName && x.Duration > (db.Songs.Average(y => y.Duration)));

            //2. Відображення ТОП 3 треків та альбомів певного артиста по рейтингу
            string Artist = "Artist";
            var top3songs = db.Songs.Where(x => x.Album.Artist.Name == Artist).OrderByDescending(x => x.Rating).Take(3);

            //3. Пошук трека по частині імені або уривку із текста/









        }
    }
}