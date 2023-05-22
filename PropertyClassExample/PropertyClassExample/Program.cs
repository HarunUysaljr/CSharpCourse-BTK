// product -> ıd , productName, unitPrice, category(CategoryName, Description)

// örnek olarak 1 tane product nesnesi tanımlayınız

// ıd - 1
// prdoductName - nokia 3310
// unitprice - 750
//category

using PropertyClassExample;
Category category = new Category()
{
    CategoryName = "telefon",
    Description = "alo"
};

Product product = new Product()
{
    Id = 1,
    ProductName = "Test",
    ProductPrice = 2,
     Category =category,
     
};

//Console.WriteLine(product.ProductName + product.Category.CategoryName + product.ProductPrice);

Console.WriteLine("Bu ürün {0}\n {1} kategorisindendir\n fiyatı {2}", product.ProductName, product.Category.CategoryName, product.ProductPrice);

