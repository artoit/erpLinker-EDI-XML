namespace erpLinker_EDI_XML
{
    public class AddressData
    {
        public string CompanyName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string TaxID { get; set; }

        public string Reference { get; set; }

        public string Street { get; set; }

        public string StreetNumber { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string PostCode { get; set; }

        public string Country { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public bool IsEmpty()
        {
            if (string.IsNullOrWhiteSpace(CompanyName) &&
               string.IsNullOrWhiteSpace(FirstName) &&
               string.IsNullOrWhiteSpace(LastName) &&
               string.IsNullOrWhiteSpace(TaxID) &&
               string.IsNullOrWhiteSpace(Email) &&
               string.IsNullOrWhiteSpace(Reference) &&
               string.IsNullOrWhiteSpace(Phone) &&
               string.IsNullOrWhiteSpace(Street) &&
               string.IsNullOrWhiteSpace(City))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ClearData()
        {
            CompanyName = CompanyName?.Trim();
            FirstName = FirstName?.Trim();
            LastName = LastName?.Trim();
            TaxID = TaxID?.Trim();
            Reference = Reference?.Trim();
            Street = Street?.Trim();
            StreetNumber = StreetNumber?.Trim();
            City = City?.Trim();
            Region = Region?.Trim();
            PostCode = PostCode?.Trim();
            Country = Country?.Trim();
            Email = Email?.Trim();
            Phone = Phone?.Trim();
        }
    }
}