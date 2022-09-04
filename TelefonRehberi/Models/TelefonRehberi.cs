using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TelefonRehberi.Models
{
    public class TelefonRehberi
    {

        [Key]
        public int RehberId { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        [Required(ErrorMessage ="Bu Alanı Doldurmak Zorunludur.")]
        public string Ad { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required(ErrorMessage = "Bu Alanı Doldurmak Zorunludur.")]
        public string Soyad { get; set; }

        [Column(TypeName = "varchar(20)")]
        [DisplayName("Telefon Numarası")]
        [Required(ErrorMessage = "Bu Alanı Doldurmak Zorunludur.")]
        public string Telefon_Numarasi { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Fax Numarası")]
        [Required(ErrorMessage = "Bu Alanı Doldurmak Zorunludur.")]
        public string Fax_Numarasi { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("E-Mail")]
        [Required(ErrorMessage = "Bu Alanı Doldurmak Zorunludur.")]
        public string E_Mail { get; set; }


    }
}
