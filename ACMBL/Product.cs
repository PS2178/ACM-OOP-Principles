using Acme.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACMBL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        private string _ProductName;

        public string ProductName
        {
            get {
                return _ProductName.InsertSpaces();
            }
            set { _ProductName = value; }
        }


        /// <summary>
        /// Validates the product data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            return ProductName;
        }

        public string Log()
        {
            var logString = $"{ProductId}: {ProductName} Detail: {ProductDescription} Status: {EntityState.ToString()}";
            return logString;
        }
    }
}
