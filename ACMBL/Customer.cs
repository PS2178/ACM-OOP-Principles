using Acme.Common;
using System;
using System.Collections.Generic;

namespace ACMBL
{
    public class Customer : EntityBase, ILoggable
    {
        public Customer()
            : this(0)
        {
            // default constructor
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public List<Address> AddressList { get; set; }
        public int CustomerType { get; set; }
        public static int InstanceCount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        // propg auto-implemented property
        public int CustomerId { get; private set; }

        public string FullName
        {
            get
            {
                // Check to see if either name is missing
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        /// <summary>
        /// Validates the customer data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            return FullName;
        }

        public string Log()
        {
            var logString = $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";
            return logString;
        }
    }
}
