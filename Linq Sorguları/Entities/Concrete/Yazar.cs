using Linq_Sorguları.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_Sorguları
{
    public class Yazar : IEntities
    {
        public int Id { get; set; }
        public string YazarAdi { get; set; }
    }
}
