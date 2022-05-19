namespace Prn.Se1623;

public class Product
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public string Desc { get; set; }
    public int CategorId { get; set; }
    public double UnitPrice { get; set; }


    public Product()
    {

    }

    public Product(int id, string productName, string desc, 
        int categorId, double unitPrice)
    {
        Id = id;
        ProductName = productName;
        Desc = desc;
        CategorId = categorId;
        UnitPrice = unitPrice;
    }

    public override string? ToString() => $"[Id = {Id}, Product name ={ProductName}, desc ={Desc}, " +
                                             $"categoryId ={CategorId}, unit price ={UnitPrice}";



}