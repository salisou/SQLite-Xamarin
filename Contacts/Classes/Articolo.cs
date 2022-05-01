using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts.Classes
{
    public class Articolo
    {
        [PrimaryKey, MaxLength(75)]
        public string Cod_articolo { get; set; }
        [MaxLength(25)]
        public string cod_parte { get; set; }
        [MaxLength(100)]
        public string Descrizione { get; set; }
        [MaxLength(8)]
        public string Raggr1 { get; set; }
        [MaxLength(8)]
        public string Raggr2 { get; set; }
        [MaxLength(8)]
        public string Raggr3 { get; set; }
        [MaxLength(8)]
        public string Raggr4 { get; set; }
        [MaxLength(8)]
        public string Raggr5 { get; set; }
        public byte Annullato { get; set; }
        [MaxLength(3)]
        public string Cod_classe { get; set; }
        public decimal  ARPeso { get; set; }
        [MaxLength(5)]
        public string UM { get; set; }
        public decimal ARPrezzo { get; set; }
        [MaxLength(1)]
        public string ARTipo { get; set; }
        public decimal ARCSTD { get; set; }
        public DateTime ARDtUltMod { get; set; }
    }
}
