using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace IndiduelltP_Banken_CS_MG
{
    public class BankFunctions
    {
        static public void populateAccounts(User user)
        {
            Random rnd = new Random();
            for (int i = 0; i < user.balances.Length; i++)
            {
                user.balances[i] = rnd.NextDouble() * 100000;
            }
        }
    }
}
