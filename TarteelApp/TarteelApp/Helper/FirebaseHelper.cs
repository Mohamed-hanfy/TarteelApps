using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarteelApp.Model;

namespace TarteelApp.Helper
{
    public class FirebaseHelper
    {
        FirebaseClient firebase = new FirebaseClient("https://tarteel-9fb79-default-rtdb.firebaseio.com/");

        public async Task<List<Itemes>> GetAllPersons(string serchText=null)
        {
            
            return (await firebase
              .Child("Islam Sophy")
              .OnceAsync<Itemes>()).Select(item => new Itemes
              {
                  name = item.Object.name,
                  link = item.Object.link,
                  text = item.Object.text

              }).ToList();
        }
    }
}