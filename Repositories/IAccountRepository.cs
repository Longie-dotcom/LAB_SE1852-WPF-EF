using BussinessObject;

namespace Repositories
{
    public interface IAccountRepository
    {
        AccountMember GetAccountById(string accountId);
    }
}
