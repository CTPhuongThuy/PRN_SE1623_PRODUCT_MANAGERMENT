namespace Prn.Se1623;

public class ProductManager : AbstractProduct, IProduct
{
    public ProductManager() { }
    public void Add(Product p)
    {
        if(Size >= Products.Length)
        {
            Product[] tmp = new Product[Size * 2];
            for (int i = 0; i < Size; i++)
            {
                tmp[i] = Products[i];
            }
            Products = tmp;
        }
        this.Products[Size++] = p;

    }
    
    public void Display()
    {
        for (int i= 0; i<this.Size; i++)
        {
            Console.WriteLine(Products[i]);

        }
    }

    public Product Get(int pos)
    {
        return null;
    }

    public void Remove(Product p)
    {
        throw new NotImplementedException();
    }
}