using System.ComponentModel.DataAnnotations;

namespace Backend_sr1645.Models
{
    public class Product
    {
        // Klucz główny
        // I sposób: Id
        public int Id { get; set; }

        // II sposób: [nazwaKlasy]Id // ProductId
        //public int ProductId { get; set; }

        // III sposób: dowolna nazwa + artybut [Key]
        //[Key]
        //public int IdProd { get; set; }
        [Required]
        public string Name { get; set; }

        public float? Price { get; set; }
    }
}
