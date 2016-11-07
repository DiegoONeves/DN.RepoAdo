using DN.RepoAdo.Domain.ValueObjects;
using System;

namespace DN.RepoAdo.Domain.Entities
{
    public class Product
    {
        #region Constructors

        public Product() {}
        public Product(string name, decimal price, Store store, ProductCategory productCategory)
        {
            ProductId = 0;
            Name = name;
            Price = price;
            Store = store;
            ProductCategory = productCategory;
            IsActive = true;
            CreateDate = DateTime.Now;
        }
        #endregion

        #region Properties

        public int ProductId { get; private set; } = 0;
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public Store Store { get; private set; }
        public ProductCategory ProductCategory { get; private set; }
        public bool IsActive { get; private set; }
        public DateTime CreateDate { get; private set; }

        #endregion

        #region Methods

        public void Load(int id, string name, decimal price, bool isActive, Store store, ProductCategory productCategory, DateTime createDate)
        {
            ProductId = id;
            Name = name;
            Price = price;
            ProductCategory = productCategory;
            IsActive = isActive;
            CreateDate = createDate;
        }

        public override string ToString()
        {
            return Name;
        }

        #endregion
    }
}
