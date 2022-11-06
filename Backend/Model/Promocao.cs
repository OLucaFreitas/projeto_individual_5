using Microsoft.EntityFrameworkCore.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace GoodTravel.Model
{
    [Table("promocoes")]
    public class Promocao
    {
        private readonly ILazyLoader _lazyLoader;

        public Promocao()
        {

        }

        public Promocao(ILazyLoader lazyLoader)
        {
            _lazyLoader = lazyLoader;
        }


        [Column("id")]
        [Required]
        public int Id { get; set; }

        
        [Required]
        public string Nome { get; set; }

        [Required]
        public double valorPromo { get; set; }


        private Destino _Destino;
        
        [ForeignKey("destino_fk")]
        public Destino Destino
        {
            get => _lazyLoader.Load(this, ref _Destino);
            set => _Destino = value;
        }

    }
}
