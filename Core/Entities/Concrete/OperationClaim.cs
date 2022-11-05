using Core.DataAccess.Repository;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entitites.Concrete
{
    public class OperationClaim : Entity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
