using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //IEntity implemente eden class veritabani nesnesidir
    public class Category: IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
