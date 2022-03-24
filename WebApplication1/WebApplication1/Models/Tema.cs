using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{

    public class Tema
    {
        [Column ("tem_id")]
        public int ID{ get; set; }
        public string Tem_descricao { get; set; }
        public DateTime Tem_momento { get; set; }
        public string Usu_login { get; set; }
    }


}