using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HepsiBuradaApi.Domain.Common;

namespace HepsiBuradaApi.Domain.Entities
{
    public class Brand : EntityBase
    {
        public required string Name { get; set; }

        public Brand()
        {

        }
        public Brand(string name)
        {
            Name = name;
        }
    }
}