using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ListandoLazeres.Infra.Data.Scripts
{
    public static class LazerScript
    {
        public static string QueryAll()
        {
            return @"SELECT * FROM dbo.LAZER ";
        }
        public static string QueryById()
        {
            return @"SELECT * 
                     FROM dbo.LAZER
                     WHERE ID=@Id";
        }
        public static string Update()
        {
            return @"UPDATE dbo.LAZER
                     SET NOME = @Nome
                     WHERE ID=@Id";
        }
        public static string Insert()
        {
            return @"INSERT INTO dbo.LAZER(NOME,DATA_ATIVIDADE,CATEGORIA_ID)
                     VALUES(@Nome,@Data,@Categoria) ";
        }
        public static string Delete()
        {
            return @"DELETE FROM dbo.LAZER
                     WHERE ID = @Id";
        }
    }
}
