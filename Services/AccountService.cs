using BussinessObject;
using Repositories;

namespace Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository accountRepository;

        public AccountService()
        {
            accountRepository = new AccountRepository();
        }

        public AccountMember GetAccountById(string accountId)
        {
            return accountRepository.GetAccountById(accountId);
        }
    }
}
