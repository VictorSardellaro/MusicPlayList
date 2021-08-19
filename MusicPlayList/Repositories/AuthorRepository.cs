using System;
using MusicPlayList.Models;


namespace MusicPlayList.Repositories
{
    public class AuthorRepository
    {
        public static void ListAuthor()
        {
            List();
        }

        private static void List()
        {
            
        }


        public static void CreateAuthor(string author)
        {
            ConnectionString.DBStartConnection();            

            Create(new Author
            {
                Name = author
            });

            ConnectionString.DBCloseConnection();
        }

        private static void Create(Author author)
        {

            try
            {
                var repository = new Repository<Author>(Database.Connection);
                repository.Create(author);
            }
            catch (Exception ex)
            {
                Console.WriteLine("It was not possible to save into DataBase");
                Console.WriteLine(ex.Message);

                ConnectionString.DBCloseConnection();
            }

        }

        public static void UpdateAuthor()
        {
            ConnectionString.DBStartConnection();

            int id = 1;
            string name = "Joao silva";

            Update(new Author
            {
                Id = id,
                Name = name
            });

            ConnectionString.DBCloseConnection();
        }


        private static void Update(Author author)
        {

            try
            {
                var repository = new Repository<Author>(Database.Connection);
                repository.Update(author);
            }
            catch (Exception ex)
            {
                Console.WriteLine("It was not possible to save into DataBase");
                Console.WriteLine(ex.Message);

                ConnectionString.DBCloseConnection();
            }

        }

        public static void DeleteAuthor()
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
                var repository = new Repository<Author>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Author Excluded successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("It was not possible exclude the author");
                Console.WriteLine(ex.Message);

                ConnectionString.DBCloseConnection();
            }


        }

    }
}
