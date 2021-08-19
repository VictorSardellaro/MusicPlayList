using System;
using MusicPlayList.Models;



namespace MusicPlayList.Repositories
{
    public class GenreRepository
    {
        public static void ListGenre()
        {
            List();
        }

        private static void List()
        {
            
        }

        public static void CreateGenre()
        {
            ConnectionString.DBStartConnection();

            string name = "Henryk Teste";

            Create(new Genre
            {
                Name = name
            });

            ConnectionString.DBCloseConnection();
        }

        private static void Create(Genre Genre)
        {

            try
            {
                var repository = new Repository<Genre>(Database.Connection);
                repository.Create(Genre);
            }
            catch (Exception ex)
            {
                Console.WriteLine("It was not possible to save into DataBase");
                Console.WriteLine(ex.Message);

                ConnectionString.DBCloseConnection();
            }

        }

        public static void UpdateGenre()
        {
            ConnectionString.DBStartConnection();

            int id = 1;
            string name = "Joao silva";

            Update(new Genre
            {
                Id = id,
                Name = name
            });

            ConnectionString.DBCloseConnection();
        }


        private static void Update(Genre Genre)
        {

            try
            {
                var repository = new Repository<Genre>(Database.Connection);
                repository.Update(Genre);
            }
            catch (Exception ex)
            {
                Console.WriteLine("It was not possible to save into DataBase");
                Console.WriteLine(ex.Message);

                ConnectionString.DBCloseConnection();
            }

        }

        public static void DeleteGenre()
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
                var repository = new Repository<Genre>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Genre Excluded successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("It was not possible exclude the Genre");
                Console.WriteLine(ex.Message);

                ConnectionString.DBCloseConnection();
            }


        }

    }
}
