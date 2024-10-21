using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HepsiBuradaApi.Domain.Common;

namespace HepsiBuradaApi.Domain.Entities
{
    public class Detail : EntityBase
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required int CategoryId { get; set; }
        public Category Category { get; set; }

        public Detail()
        {

        }

        public Detail(string title, string desc, int categoryId)
        {
            Title = title;
            Description = desc;
            CategoryId = categoryId;
        }
    }
}