namespace Store.DI
{
    public interface IProduct
    {
        string Name { get; set; } 
        decimal Price { get; set; }
        string Description { get; set; }
        int Quantity { get; set; }

        void DisplayInfo();
    }
}
