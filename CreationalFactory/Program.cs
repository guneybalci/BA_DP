using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalFactory
{
    // Factory Kullanım Alanı: 1'den çok DataBase kullanıldığında anda en çok tercih edilir.
    // MSSQL ve Oracle (Connection=İlgili SQL'i bulur & Command = İlgili SQL Sorgusunu Çalıştırır)
    /* MSSQL = SQLConnectionString Command & Oracle = OracleConecctionString ve Command
     * Factory Design Pattern: DbConnectionString ve DbCommand Provider
     */
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            //MSSQL ve ORacle
            //Connection 
            //Command


            /*
            SqlConnection  Oracle Connection 
            SqlCommand      Oracle Command 
            
            DbConnection
            DbCommand 
            Provider  
             */
            #endregion


            Creator cr = new Creator();
            MobilApplication android = cr.FactoryMethod(OSType.Android);
            MobilApplication ios = cr.FactoryMethod(OSType.IOS);
            MobilApplication win = cr.FactoryMethod(OSType.Windows);


            android.Platform();
            win.Platform();
            ios.Platform();

            Console.ReadKey();


            #region Sizin Hazırlayacağınız Örnek soru 
            //Ado.Net ile MSSQL 
            //EF ile Postgre Sql E bağlanan sınıflr inşaa edelim .Factory Pattern i uygulayarak Program.cs içinde hem Ado hemde Mssql Classları çalışabilecek hale gelsin . 


            //Farklı ConnectionString üreten bir factoryPattern yapısı..
            //Oracle,Postgre, MSSQL ,MYSQL,IBMDB2
            #endregion


        }
    }
}
