namespace Demos.Patterns.Asynchronous.Abstractions.Entities.Sales;
public class OrderLine
{
    public int OrderLineID { get; set; }
    public int OrderID { get; set; }
    public int StockItemID { get; set; }
    public string Description { get; set; }
    public int PackageTypeID { get; set; }
    public int Quantity { get; set; }
    public decimal? UnitPrice { get; set; }
    public decimal TaxRate { get; set; }
    public int PickedQuantity { get; set; }
    public DateTime? PickingCompletedWhen { get; set; }
    public int LastEditedBy { get; set; }
    public DateTime LastEditedWhen { get; set; }


    public Order OrderItem { get; set; }
}