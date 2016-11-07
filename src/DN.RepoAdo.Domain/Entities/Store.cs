using System.Collections.Generic;

namespace DN.RepoAdo.Domain.Entities
{
    public class Store
    {
        #region Constructors

        public Store() { }
        public Store(string districtName, bool isActive)
        {
            DistrictName = districtName;
            IsActive = isActive;
            Products = new List<Product>();
        }

        #endregion

        #region Properties

        public int StoreId { get; private set; } = 0;
        public string DistrictName { get; private set; }
        public bool IsActive { get; private set; }
        public IEnumerable<Product> Products { get; private set; }

        #endregion

        #region Methods
        public void Load(int id, string districtName, bool isActive)
        {
            StoreId = id;
            DistrictName = districtName;
            IsActive = isActive;
        }

        public void LoadProducts(IList<Product> products)
        {
            Products = products;
        }

        public override string ToString()
        {
            return DistrictName;
        }
        #endregion
    }
}
