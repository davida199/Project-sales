using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWeb.Models.ViewModels
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void addSeller(Seller seller)
        {
            Sellers.Add(seller);
        }
        public double totalSales(DateTime initial,DateTime final)
        {
            return Sellers.Sum(Seller=>Seller.totalSales(initial,final));
        }
    }
}
