using BussinessObject;
using DataAccessLayer;

namespace Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public AccountMember GetAccountById(string accountId)
        {
            return AccountDAO.GetAccountById(accountId);
        }
    }
}
