using System;
using System.ComponentModel.DataAnnotations;

namespace SysPerson.Domain.Entities
{
    public class EntidadeBase
    {
        private Guid id = Guid.Empty;

        [Required]
        public Guid Id
        {
            get
            {
                return id.Equals(Guid.Empty) ? (id = Guid.NewGuid()) : id;
            }
            set { id = value; }
        }
    }
}
