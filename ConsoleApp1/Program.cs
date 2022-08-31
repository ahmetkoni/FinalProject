using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EFProductDal());
    foreach (var product in productManager.GetProductDetails().Data)
    {
        Console.WriteLine(product.ProductName + "/" + product.CategoryName);
    }
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }
}

ProductTest();