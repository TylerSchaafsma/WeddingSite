using Supabase;
using WeddingRSVP.Models;

namespace WeddingRSVP.Services
{
    public class GuestService
    {
        private readonly Client client;

        public GuestService(Client client)
        {
            this.client = client;
        }

        public async Task<List<Guest>> GetAllGuests()
        {
            var response = await client.From<Guest>().Get();

            return response.Models.ToList();
        }

        public async Task<Guest> GetGuest(Guid ID)
        {
            var guest = await client.From<Guest>().Where(g => g.ID == ID).Single();

            return guest;
        }

        public async Task UpdateGuest(Guest guest)
        {
            await client.From<Guest>().Update(guest);
        }
    }
}
