using Linq_Sorguları.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_Sorguları
{
    public class KitapTur : IEntities
    {
        public int Id { get; set; }
        public string KitapTuru { get; set; }
    }
}
