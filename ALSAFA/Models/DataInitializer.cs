namespace ALSAFA.Models
{
    public static class  DataInitializer
    {
        public static WebApplication Seed(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                using var context = scope.ServiceProvider.GetRequiredService<MyStoreDB>();
                try
                {
                    context.Database.EnsureCreated();
                    var category =context.Categories.FirstOrDefault();
                    if (category == null)
                    {
                        context.Categories.AddRange(
                            new Category { Id=1 ,CName="Soup"}
                            );
                        context.SubCategories.AddRange(
                            new SubCategory { Id=1 , CatID =1 ,Name ="Face Soup",Description="Soup used for face" },
                            new SubCategory { Id=2 , CatID =1 ,Name ="Dish Soup",Description="Soup used for clean dishes" }
                           
                            );
                        context.items.AddRange(
                            new item { Id =1 , Name ="Dove " ,Count =25 ,Price=13 ,SubID=1},
                            new item { Id =2 , Name ="Savana " ,Count =30 ,Price=15 ,SubID=1},
                            new item { Id =3 , Name ="Brill" ,Count =15 ,Price=35 ,SubID=2},
                            new item { Id =4 , Name ="Feba" ,Count =102 ,Price=50 ,SubID=2}
                            );
                        context.SaveChanges();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                return app;
            }
        }

    }
}
