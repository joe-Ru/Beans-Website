using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Database_Design.Models
{
    public static class Repository
    {
        private static List<AccountModel> responses = new List<AccountModel>();
        public static IEnumerable<AccountModel> Responses
        {
            get
            {
                return responses;
            }
        }
        public static void AddResponse(AccountModel input)
        {
            responses.Add(input);
        }
    }
}
