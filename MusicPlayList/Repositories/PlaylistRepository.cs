using System;
using MusicPlayList.Models;


namespace MusicPlayList.Repositories
{
    public class PlaylistRepository
    {
        public static void ListPlaylist()
        {
            List();
        }

        private static void List()
        {

        }


        public static void CreatePlaylist(string playlistTitle)
        {
            ConnectionString.DBStartConnection();
            

            Create(new Playlist
            {
                PlaylistTitle = playlistTitle
            });

            ConnectionString.DBCloseConnection();
        }

        private static void Create(Playlist Playlist)
        {

            try
            {
                var repository = new Repository<Playlist>(Database.Connection);
                repository.Create(Playlist);
            }
            catch (Exception ex)
            {
                Console.WriteLine("It was not possible to save into DataBase");
                Console.WriteLine(ex.Message);

                ConnectionString.DBCloseConnection();
            }

        }

        public static void UpdatePlaylist()
        {
            ConnectionString.DBStartConnection();

            int id = 1;
            string name = "Joao silva";

            Update(new Playlist
            {
                Id = id,
                PlaylistTitle = name
            });

            ConnectionString.DBCloseConnection();
        }


        private static void Update(Playlist Playlist)
        {

            try
            {
                var repository = new Repository<Playlist>(Database.Connection);
                repository.Update(Playlist);
            }
            catch (Exception ex)
            {
                Console.WriteLine("It was not possible to save into DataBase");
                Console.WriteLine(ex.Message);

                ConnectionString.DBCloseConnection();
            }

        }

        public static void DeletePlaylist()
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
                var repository = new Repository<Playlist>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Playlist Excluded successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("It was not possible exclude the Playlist");
                Console.WriteLine(ex.Message);

                ConnectionString.DBCloseConnection();
            }


        }

    }
}
