# erpLinker EDI XML
## Lbrary supporting import documents in XML to the Polish ERP system: InsERT Subiekt nexo PRO and Subiekt GT by [ARTOIT - IT Systems](https://www.artoit.pl/)

XML files created using this library can be imported by the plugins - [XML documents Importer for InsERT Subiekt nexo PRO](https://www.artoit.pl/moduly/nexo/import_faktur.html#nav) and [XML documents Importer for InsERT Subiekt GT](https://www.artoit.pl/moduly/gt/import_zamowien.html#nav).
This enables integration with Polish accounting and tax systems like InsERT Rewizor.

This allows the integration of external invoicing systems with the Polish system "National System of e-invoices" (KSeF), which requires sending invoices to the national system of invoices.

### Scheme of integration with Polish accounting system
**InsERT Rewizor nexo**

[XML file with documents data] => [XML Importer for InsERT Subiekt nexo PRO](https://www.artoit.pl/moduly/nexo/import_faktur.html#nav) => [InsERT Subiekt nexo PRO](https://www.insert.com.pl/programy_dla_firm/sprzedaz/subiekt_nexo_pro/opis.html) => InsERT Rewizor nexo

**InsERT Rewizor GT**

[XML file with documents data] => [XML Importer for InsERT Subiekt nexo PRO](https://www.artoit.pl/moduly/nexo/import_faktur.html#nav) => [InsERT Subiekt GT Sfera](https://www.insert.com.pl/programy_dla_firm/sprzedaz/subiekt_gt_sfera/opis.html) => InsERT Rewizor GT

## Technology
* .NET Standard 2.0 

## Example
```C#
XmlSerializer serializer = new XmlSerializer(typeof(ErpLinkerDocuments));
var list = new ErpLinkerDocuments();

var eDok1 = new EDocument
{
    CreationDate = DateTime.Now.ToString(),
    Currency = "PLN",
    DeliveryDate = DateTime.Now.ToString(),
    Description = "Message from the client...",
    Number = 312,
    NumberExternal = "ORD/512/XBVA/22",
    NumberFull = "312/W/9/22"
};
  
eDok1.Type = EDocumentType.SalesInvoice;
eDok1.PaymentDueDate = DateTime.Now.AddDays(14).ToString();
eDok1.PaymentTypeName = "COD";

eDok1.Buyer = new AddressData()
{
  City = "Wroclaw",
  CompanyName = "Super Company",
  Country = "Poland",
  Email = "info@supc.com.pl",
  Phone = "+48 987 789 123 0",
  FirstName = "Adam",
  LastName = "Kowalsky",
  PostCode = "30-456",
  Street = "Rynek"
  StreetNumber = "45/1",
  TaxID = "7774445550"
};

eDok1.Items = new List<DocumentItem>();
var item1 = new DocumentItem()
{
  Type = EDocumentItemType.Goods,
  SKU = "ASOR01",
  Name = "GOOD ASOR"
  Description = "This good asor is...",
  CodeGTU = "05",
  EAN = "5901239875551"
  UnitOfMeasure = "PCE",
  UnitPrice = 300,
  Quantity = 3
  Amount = 900,
  TaxCode = "23",
  TaxRate = 23,
  Producer = "ACME"
};

eDok1.Items.Add(item1);

var item2 = new DocumentItem()
{
  Type = EDocumentItemType.Services,
  SKU = "Sv_mont",
  Name = "Assembly SV"
  UnitPrice = 100,
  Quantity = 1
  Amount = 100,
  TaxCode = "np"
};

eDok1.Items.Add(item2);

eDok1.Summary.Subtotal = 1000;
eDok1.Summary.Tax = 207;
eDok1.Summary.TotalWithTax = 1207;

list.Documents.Add(eDok1);

using (FileStream xml = new FileStream(path + ".xml", FileMode.Create))
{
  serializer.Serialize(xml, list);
}
```

## Kontakt
__ARTOIT - IT SYSTEMS__

https://www.artoit.pl

email: dev@artoit.pl
