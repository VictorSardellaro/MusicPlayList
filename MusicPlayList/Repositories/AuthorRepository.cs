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
    public class AuthorRepository
    {
        public static void ListAuthor()
        {
            List();
        }

        private static void List()
        {
            var repository = new Repository<Author>(Database.Connection);
            //var tags = repository.Get();
            //foreach (var item in tags)
                //Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");
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
