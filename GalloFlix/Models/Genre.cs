namespace GalloFlix.Models;
using System.ComponentModel.DataAnnotations;
{
    public class Genre
    {
        [Key]
        public byte Id {get; set;}
        public string Name {get; set;}
            
    }
}