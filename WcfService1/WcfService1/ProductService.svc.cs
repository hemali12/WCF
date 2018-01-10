using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductService.svc or ProductService.svc.cs at the Solution Explorer and start debugging.
    public class ProductService : IProductService
    {
        public bool Create(productDetail Product)
        {

            using (ProductEntities pre = new ProductEntities())
            {
                try
                {
                    productDetail pd = new productDetail();
                    pd.productName = Product.productName;
                    pd.productPrice = Product.productPrice;
                    pd.productQuantity = Product.productQuantity;
                    pd.productExpDate = Product.productExpDate;
                    pd.Category = Product.Category;
                    pre.productDetails.Add(pd);
                    pre.SaveChanges();
                    return true;

                }
                catch
                {
                    return false;
                }
            };
        }

        public bool Delete(productDetail Product)
        {
            using (ProductEntities pre = new ProductEntities())
            {
                try
                {
                    int id = Convert.ToInt32(Product.Id);
                    productDetail pd = pre.productDetails.Single(p => p.Id == id);
                    pre.productDetails.Remove(pd);
                    pre.SaveChanges();
                    return true;

                }
                catch
                {
                    return false;
                }
            };
        }

        public bool Edit(productDetail Product)
        {
            using (ProductEntities pre = new ProductEntities())
            {
                try
                {
                    int id = Convert.ToInt32(Product.Id);
                    productDetail pd = pre.productDetails.Single(p => p.Id == id );
                    pd.productName = Product.productName;
                    pd.productPrice = Product.productPrice;
                    pd.productQuantity = Product.productQuantity;
                    pd.productExpDate = Product.productExpDate;
                    pd.Category = Product.Category;
                    pre.SaveChanges();
                    return true;

                }
                catch
                {
                    return false;
                }
            };
        }

        public productDetail Find(int id)
        {

            using (ProductEntities pre = new ProductEntities())
            {
                return pre.productDetails.Where(pe => pe.Id == id).Select(pe => new productDetail
                {
                    Id = pe.Id,
                    productName = pe.productName,
                    productPrice = pe.productPrice,
                    productQuantity = pe.productQuantity,
                    productExpDate = pe.productExpDate,
                    Category = pe.Category
                }).First();
            };
        }

        public List<productDetail> FindAll()
        {
            using(ProductEntities pre = new ProductEntities()) {
                return pre.productDetails.Select(pe => new productDetail
                {
                    Id = pe.Id,
                    productName=pe.productName,
                    productPrice=pe.productPrice,
                    productQuantity=pe.productQuantity,
                    productExpDate=pe.productExpDate,
                    Category=pe.Category
                }).ToList();
            };
        }
    }
}
