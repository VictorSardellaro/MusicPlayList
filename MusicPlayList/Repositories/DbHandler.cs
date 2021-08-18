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
    public class DbHandler
    {
        public static void DbInsert()
        {

            Repositories.ConnectionString.DBStartConnection();

            int id = 123;
            string name = "Victor";

            Create(new Author
            {
                AuthorId = id,
                AuthorName = name

            });
        }

        public static void Create(Author author)
        {

            try
            {
                var repository = new Repository<Author>(Database.Connection);
                repository.Create(author);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar a tag");
                Console.WriteLine(ex.Message);
            }

        }
    }
}
