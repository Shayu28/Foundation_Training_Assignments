using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingSystem.entity;
using BankingSystem.util;
using BankingSystem.exception;

namespace BankingSystem.dao
{
    public class BankingRepositoryImpl : IBankingRepository
    {
        private readonly SqlConnection conn;

        public BankingRepositoryImpl()
        {
            conn = DBConnUtil.GetConnection(DBPropertyUtil.GetConnectionString("db.properties"));
        }

        public void CreateCustomer(Customer customer)
        {
            // SQL insert for customer
        }

        public void CreateAccount(Account account)
        {
            // SQL insert for account
        }

        public void Deposit(int accountId, decimal amount)
        {
            // Logic to deposit
        }

        public void Withdraw(int accountId, decimal amount)
        {
            // Logic to withdraw, throw InsufficientBalanceException if needed
        }

        public decimal GetBalance(int accountId)
        {
            // Logic to get balance
            return 0;
        }
    }
}
