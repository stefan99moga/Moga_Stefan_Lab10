using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using Moga_Stefan_Lab10.Models;


namespace Moga_Stefan_Lab10.Data
{
    public class ShoppingListDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public ShoppingListDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<ShopList>().Wait();
        }
        public Task<List<ShopList>> GetShopListsAsync()
        {
            return _database.Table<ShopList>().ToListAsync();
        }
        public Task<int> SaveShopListAsync(ShopList shopList)
        {
            if(shopList.ID != 0)
            {
                return _database.UpdateAsync(shopList);
            }
            else
            {
                return _database.InsertAsync(shopList);
            }
        }
        public Task<int> DeleteShopListAsync(ShopList shopList)
        {
            return _database.DeleteAsync(shopList);
        }
    }
}
