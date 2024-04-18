using Otb.Domain;

namespace Otb.Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext dataContext)
        {
            if (dataContext.Institutions.Any()) return;
            var institutions = new List<Institution>
            {
                new Institution
                {
                    Address = "Quillacollo",
                    Name = "Palabra Miel Quillacollo",
                    Phone = "70782597"
                },
                new Institution
                {
                    Address = " Cochabamba",
                    Name = "Palabra Miel Cochabamba",
                    Phone = "70782597"
                }
            };
            await dataContext.Institutions.AddRangeAsync(institutions);
            await dataContext.SaveChangesAsync();
        }

    }
}