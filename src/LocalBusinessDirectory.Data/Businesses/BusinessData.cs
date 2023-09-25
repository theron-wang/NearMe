using LocalBusinessDirectory.Data.Models;

namespace LocalBusinessDirectory.Data.Businesses;
public class BusinessData : IBusinessData
{
    public async Task<List<Business>> GetBusinesses()
    {
        // Simulate delay from database
        await Task.Delay(Random.Shared.Next(100, 1000));

        // Sample content
        return new List<Business>()
        {
            new()
            {
                Address = new()
                {
                    City = "New York City",
                    Number = 100,
                    State = "NY",
                    Street = "W 53rd Street",
                    ZipCode = "10119"
                },
                CategoryName = "Store",
                Description = """
                Joey's Pet Store is your community's go-to for pets and supplies. We prioritize ethical 
                sourcing, expert guidance, and community involvement. Whether you're a new pet parent or a 
                seasoned enthusiast, Joey's is here to ensure your pets thrive.
                """,
                Id = "fe529c40-5532-488f-a0bf-7e606fbf2883",
                ImageUrl = "6e46dcd7-3d7c-41e1-9155-cade1ae82855.webp",
                IsPartnered = true,
                Name = "Joey's Pet Store",
                Rating = 3.5d,
                NumberOfRatings = 69
            },
            new()
            {
                Address = new()
                {
                    City = "New York City",
                    Number = 105,
                    State = "NY",
                    Street = "S 4th Avenue",
                    ZipCode = "10119"
                },
                CategoryName = "Restaurant",
                Description = """
                At John's Pizzeria, we're renowned for crafting authentic, mouthwatering pizzas using the
                freshest ingredients. Our family-friendly atmosphere and scrumptious slices have made us the
                go-to pizza destination in town. Come savor the flavors that have delighted taste buds for
                generations.
                """,
                Id = "96773fc1-805d-4e5b-9a90-8ce2da6b28d7",
                ImageUrl = "4ffbc4d4-63c0-4aff-8478-e7837dde25ee.jpg",
                IsPartnered = false,
                Name = "John's Pizzeria",
                Rating = 4d,
                NumberOfRatings = 102
            }
        };
    }
}
