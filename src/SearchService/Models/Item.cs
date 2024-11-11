using MongoDB.Entities;

namespace SearchService;

public class Item : Entity
{
    public int ReservePrice { get; set; }
    public String Seller { get; set; }
    public String Winner { get; set; }
    public int SoldAmount { get; set; }
    public int CurrentHighBid { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime AuctionEnd { get; set; }
    public string Status { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public String Color { get; set; }
    public int Mileage { get; set; }
    public string ImageUrl { get; set; }
}
