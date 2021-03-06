using System;
using System.Text.Json;
using System.Threading.Tasks;
using MyAppBack.Models;
using StackExchange.Redis;

namespace MyAppBack.Data.Repos.BasketRepository
{
  public class BasketRepository : IBasketRepository
  {
    private readonly IDatabase _database;
    public BasketRepository(IConnectionMultiplexer redis)
    {
      _database = redis.GetDatabase();
    }

    public async Task<Basket> GetBasketAsync(string basketId)
    {
      var data = await _database.StringGetAsync(basketId);
      return data.IsNullOrEmpty ? null : JsonSerializer.Deserialize<Basket>(data);
    }

    public async Task<bool> DeleteBasketAsync(string basketId)
    {
      return await _database.KeyDeleteAsync(basketId);
    }

    public async Task<Basket> UpdateBasketAsync(Basket basket)
    {
      var created = await _database.StringSetAsync(basket.Id, JsonSerializer.Serialize(basket), TimeSpan.FromDays(30));
      if (!created)
      {
        return null;
      };
      return await GetBasketAsync(basket.Id);
    }
  }
}