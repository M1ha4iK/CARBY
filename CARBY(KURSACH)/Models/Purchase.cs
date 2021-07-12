using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CARBY_KURSACH_.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public int CarId { get; set; }
        public int Id_Model { get; set; }
        public string Person { get; set; }
        public string Adress { get; set; }
        public string Number { get; set; }
        public DateTime Date { get; set; }
    }
}