using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{

    [Table("Artist")]
    public class Artist
    {
        public int ArtistId { get; set; }

        public string Name { get; set; }
    }
}
