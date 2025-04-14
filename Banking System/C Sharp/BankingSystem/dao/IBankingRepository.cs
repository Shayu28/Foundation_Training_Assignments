using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingSystem.entity;

namespace BankingSystem.dao
{
    public interface IBankingRepository
    {
        void CreateCustomer(Customer customer);
        void CreateAccount(Account account);
        void Deposit(int accountId, decimal amount);
        void Withdraw(int accountId, decimal amount);
        decimal GetBalance(int accountId);
    }
}
