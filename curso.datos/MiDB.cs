using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using curso.datos.AWDSTableAdapters;
namespace curso.datos {
    public class MiDB {
        private AWDS db = new AWDS();

        public void dsCategorias() {
            ProductCategoryTableAdapter dt = new ProductCategoryTableAdapter();

            dt.Fill(db.ProductCategory);

            db.ProductCategory.Rows[0]["Name"] = "kk";

            dt.Update(db.ProductCategory);
        }

        public void aMano() {
            var conn = new SqlConnection("Data Source=.;Initial Catalog=AdventureWorksLT2017;Integrated Security=True");
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ProductCategoryID, ParentProductCategoryID, Name, rowguid, ModifiedDate FROM SalesLT.ProductCategory";
            cmd.Connection.Open();
            var cur = cmd.ExecuteReader();
            while(cur.Read()) {
                Console.WriteLine(cur.GetString(2));
            }
            cur.Close();
            cmd.Connection.Close();
        }
    }
}
