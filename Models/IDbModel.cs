using System.ComponentModel.DataAnnotations;

namespace PO.Infrastructure.Core.Models
{
    public interface IDbModel<T> : IDbModelBase
    {
        [Key]
         T Id { get; set; }
    }
}