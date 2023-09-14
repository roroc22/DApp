using API.Entities;
//Q上面是我新加的對嗎？？
using Microsoft.EntityFrameworkCore;

namespace API.Data;

// 創建class訪問資料庫
// constructor is something that's run when a new class is created
// 接著會看我們提供的options
// 建立物件時，建構子的程式碼就會馬上被執行

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options){

    }
    public DbSet<AppUser> Users { get;set;}
}