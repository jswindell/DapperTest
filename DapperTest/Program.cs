using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var conn = new SqlConnection("Data Source=c360devdb01;Initial Catalog=LAL;Integrated Security=SSPI"))
            {
                conn.Open();
                var x = conn.Query<Blog>("select * from dbo.Blogs where id = @id", param: new { id = 1 });
                if (x.Any())
                {
                }
            }
        }
    }

    class Blog
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

    }

    class Post
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime PostDate { get; set; }
    }
}
