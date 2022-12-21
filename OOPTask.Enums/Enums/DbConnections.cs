using System.ComponentModel.DataAnnotations;

namespace OOPTask.Enums.Enums
{
    public enum DbConnections : byte
    {
        [Display(Name = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;")]
        Sql = 1,

        [Display(Name = "Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;")]
        MySql = 2,

        [Display(Name = "Data Source=MyOracleDB;User Id=myUsername;Password=myPassword;Integrated Security=no;")]
        Oracle = 3
    }
}
