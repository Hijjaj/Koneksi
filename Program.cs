using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Koneksi
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Connecting();
        }

        public void Connecting()
        {
            using (
                SqlConnection con = new SqlConnection("data source=LAPTOP-OG8P1VHL\\HIJJAJ;database=ProdiTI;Integrated Security=true")
                )
            {
                con.Open();
                Console.WriteLine("Berhasil terhubung ke database!");
            }
        }
    }
}
