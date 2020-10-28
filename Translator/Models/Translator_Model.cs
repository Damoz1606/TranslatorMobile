using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Translator.Models
{
    public class Translator_Model
    {
        [PrimaryKey, AutoIncrement]
        public int _id { get; set; }
        public string _spanish { get; set; }
        public string _english { get; set; }
        public string _to_string()
        {
            return _spanish + " / " + _english;
        }
    }
}
