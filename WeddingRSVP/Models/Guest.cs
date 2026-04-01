using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace WeddingRSVP.Models
{
    [Table("Guests")]
    public class Guest : BaseModel
    {
        [PrimaryKey("ID")]
        public Guid ID { get; set; }

        [Column("GroupID")]
        public int GroupID { get; set; }

        [Column("Name")]
        public string? Name { get; set; }

        [Column("Attending")]
        public bool? Attending { get; set; }

        [Column("PlusOneAllowed")]
        public bool PlusOneAllowed { get; set; }

        [Column("PlusOneName")]
        public string? PlusOneName { get; set; }
    }
}