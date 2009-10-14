using System.Collections.Generic;
using Fohjin.DDD.BankApplication.Presenters;
using Fohjin.DDD.Reporting.Dto;

namespace Fohjin.DDD.BankApplication.Views
{
    public interface IAccountDetailsView : IView<IAccountDetailsPresenter>
    {
        string AccountName { get; set; }
        string AccountNumber { get; set; }
        IEnumerable<Ledger> Ledgers { get; set; }
        decimal Amount { get; set; }
        decimal TransferAmount { get; set; }
        decimal Balance { get; set; }
        IEnumerable<Account> TransferAccounts { get; set; }
    }
}