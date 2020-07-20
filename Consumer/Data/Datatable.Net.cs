﻿using System.Collections;
using System.Collections.Generic;

namespace Gkdr.Consumer.Data
{
    public class Datatable
    {
        public int draw { get; set; }
        public int start { get; set; }
        public int length { get; set; }
        public List<Column> columns { get; set; }
        public Search search { get; set; }
        public List<Order> order { get; set; }
    }
    
    public class Column
    {
        public string data { get; set; }
        public string name { get; set; }
        public bool searchable { get; set; }
        public bool orderable { get; set; }
        public Search search { get; set; }
    }
    
    public class Search
    {
        public string value { get; set; }
        public string regex { get; set; }
    }
 
    public class Order
    {
        public int column { get; set; }
        public string dir { get; set; }
    }
    
    public class DataTableResponce
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public IList data { get; set; }
        public List<string> filter { get; set; }
        public string order { get; set; }
    }
}