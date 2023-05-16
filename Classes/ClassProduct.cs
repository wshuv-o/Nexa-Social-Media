using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media.Classes
{
    public class ClassProduct
    {
        private int productId;
        private string productName;
        private string productDescription;
        private double productPrice;
        private Image[] productImages;
        private Image productImage;
        private double productRating;
        private int productSold;
        private int pageId;


        public int ProductSold
        {
            get { return productSold; }
            set { productSold = value; }
        }
        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        public int PageId
        {
            get { return pageId; }
            set { pageId = value; }
        }
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public string ProductDescription
        {
            get { return productDescription; }
            set
            {
                productDescription = value;
            }
        }
        public double ProductPrice
        {
            get { return productPrice; }
            set { productPrice = value; }
        }
        public Image[] ProductImages
        {
            get { return productImages; }
            set
            {
                productImages = value;
            }
        }        
        public Image ProductImage
        {
            get { return productImage; }
            set
            {
                productImage = value;
            }
        }
        public double ProductRating 
        {
            get { return this.productRating; }
            set { this.productRating=value; }

        }
        public ClassProduct(string productName, string productDescription, double productPrice, Image[] productImages)
        {
            this.ProductName= productName;
            this.ProductDescription= productDescription;
            this.ProductPrice= productPrice;
            this.ProductImages= productImages;
        }        
        public ClassProduct(int productId, string productName, string productDescription, double productPrice, Image productImage, double rating,int productSold, int pageId)
        {
            this.ProductId=productId;
            this.ProductName= productName;
            this.ProductDescription= productDescription;
            this.ProductPrice= productPrice;
            this.ProductImage= productImage;
            this.ProductRating= rating;
            this.ProductSold=productSold;
            this.PageId= pageId;
        }
    }
}
