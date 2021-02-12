using Linq_Sorguları.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_Sorguları
{
    public class Kitap : IEntities
    {
        public int Id { get; set; }
        public string KitapAdi { get; set; }
        public int YazarId { get; set; }
        public int TurNo { get; set; }
        public int SayfaSayisi { get; set; }
    }
}
