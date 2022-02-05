using DesktopCore.Classes;
using System;

namespace DesktopDataAccess.Classes
{
    public class BaseObject
    {
        public int Id { get; set; }

        public string Notes { get; set; }

        public DateTime CreateDate { get; set; }

        public int CreateUser { get; set; }

    }
}