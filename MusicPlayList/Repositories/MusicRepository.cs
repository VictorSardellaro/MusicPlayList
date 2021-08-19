using System;
using MusicPlayList.Models;


namespace MusicPlayList.Repositories
{
    public class MusicRepository
    {
        public static void ListMusic()
        {
            List();
        }

        private static void List()
        {

        }


        public static void CreateMusic(string nSong, DateTime duration, int genreId, int authorId)
        {
            ConnectionString.DBStartConnection();

            

            Create(new Music
            {
                MusicTitle = nSong,                
                MusicDuration = duration,
                GenreId = genreId,
                AuthorId = authorId

            });

            ConnectionString.DBCloseConnection();
        }

        private static void Create(Music Music)
        {

            try
            {
                var repository = new Repository<Music>(Database.Connection);
                repository.Create(Music);
            }
            catch (Exception ex)
            {
                Console.WriteLine("It was not possible to save into DataBase");
                Console.WriteLine(ex.Message);

                ConnectionString.DBCloseConnection();
            }

        }

        public static void UpdateMusic()
        {
            ConnectionString.DBStartConnection();

            int id = 1;
            string name = "Joao silva";

            Update(new Music
            {
                Id = id,
                MusicTitle = name
            });

            ConnectionString.DBCloseConnection();
        }


        private static void Update(Music Music)
        {

            try
            {
                var repository = new Repository<Music>(Database.Connection);
                repository.Update(Music);
            }
            catch (Exception ex)
            {
                Console.WriteLine("It was not possible to save into DataBase");
                Console.WriteLine(ex.Message);

                ConnectionString.DBCloseConnection();
            }

        }

        public static void DeleteMusic()
        {
            ConnectionString.DBStartConnection();

            int id = 1;

            Delete(id);            

            ConnectionString.DBCloseConnection();
        }


        private static void Delete(int id)
        {

            try
            {
                var repository = new Repository<Music>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Music Excluded successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("It was not possible exclude the Music");
                Console.WriteLine(ex.Message);

                ConnectionString.DBCloseConnection();
            }


        }

    }
}
