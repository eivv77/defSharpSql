using DesktopCore;
using DesktopCore.Classes;
using System;

namespace DesktopDataAccess.Classes
{
    public class Student : BaseObject
    {
        private const string table = "DIA";

        public string FirstName { get; set; }


        public static void Insert(Student student, out Message msg)
        {
            string sql = @$"INSERT INTO [{table}]
                            VALUES ('{student.FirstName}')";

            msg = new Message();
            DBContext.Execute(sql, out msg);
        }

        public static void Update(Student student, out Message msg)
        {
            string sql = @$"INSERT INTO [{table}]
                            VALUES ('{student.FirstName}')";

            msg = new Message();
            DBContext.Execute(sql, out msg);
        }
        
        public static void Delete(int Id, out Message msg)
        {
            string sql = @$"INSERT INTO [{table}]
                            VALUES ('{Id}')";

            msg = new Message();
            DBContext.Execute(sql, out msg);
        }
    }
}
