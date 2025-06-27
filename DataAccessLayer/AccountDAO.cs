using BussinessObject;

namespace DataAccessLayer
{
    public class AccountDAO
    {
        public static AccountMember GetAccountById(string accountId)
        {
            using var db = new MyStoreContext();
            return db.AccountMembers.FirstOrDefault(a => a.MemberId.Equals(accountId));
        }
    }
}
