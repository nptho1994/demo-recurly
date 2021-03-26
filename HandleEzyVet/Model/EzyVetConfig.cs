using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandleEzyVet.Model
{
    [Table(Name = "EzyVetConfig")]
    public class EzyVetConfig
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID { get; set; }
        [Column]
        public string Name { get; set; }
        [Column]
        public string Value { get; set; }
    }
}
