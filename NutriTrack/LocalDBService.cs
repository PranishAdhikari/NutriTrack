using SQLite;
using NutriTrack.Models;


namespace NutriTrack
{
    public class LocalDBService
    {
        private const string DB_NAME = "NutriTrack_db.db3";
        private readonly SQLiteAsyncConnection _connection;

     public LocalDBService()
        {
            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_NAME));
            _connection.CreateTableAsync<User>();
          
      
        }
        public async Task<User> GetUserById(int id)
        {
            return await _connection.Table<User>().Where(u => u.UserId == id).FirstOrDefaultAsync();
        }
        public async Task<User> GetUserByUserName(string username, string password)
        {
            return await _connection.Table<User>().Where(u => u.UserName == username && u.PasswordHash == password).FirstOrDefaultAsync();
        }
        public async Task<User> GetUserByEmail(string email)
        {
            return await _connection.Table<User>().Where(u => u.Email == email).FirstOrDefaultAsync();
        }
        public async Task CreateUser(User user)
        {
            await _connection.InsertAsync(user);
        }
        public async Task DeleteUser(User user)
        {
            await _connection.DeleteAsync(user);
        }
    }
}
