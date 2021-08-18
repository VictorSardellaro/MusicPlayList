using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicPlayList.Repositories;
using MusicPlayList.Models;
using Microsoft.Data.SqlClient;


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
            var repository = new Repository<Playlist>(Database.Connection);
            //var tags = repository.Get();
            //foreach (var item in tags)
                //Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");
        }


        public static void CreatePlaylist()
        {
            ConnectionString.DBStartConnection();

            string name = "Henryk Teste";

            Create(new Playlist
            {
                PlaylistTitle = name
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
