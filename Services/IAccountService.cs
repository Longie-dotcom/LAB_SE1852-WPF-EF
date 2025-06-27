using BussinessObject;

namespace Services
{
    public interface IAccountService
    {
        AccountMember GetAccountById(string accountId);
    }
}
