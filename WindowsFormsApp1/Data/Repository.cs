using Dapper;
using Moneymattersbank.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneymattersbank.Data
{
    public class Repository
    {
        private String ConnectionString =  @"Data Source=DESKTOP-36KIGT0\SQLEXPRESS;Initial Catalog=MONEYMATTERSBANK;Integrated Security=True";
        private SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
        public List<KeyValueModel> GetBranchCode()
        {
            List<KeyValueModel> account = new List<KeyValueModel>();
            account.Add(new KeyValueModel
            {
                Id = "",
                Value = ""
            });
       
            account.Add(new KeyValueModel
            {
                Id = "001",
               Value = "001 KUALA LUMPUR"
            });

            account.Add(new KeyValueModel
            {
                Id = "002",
                Value = "002 NEGERI SEMBILAN"
            });

            account.Add(new KeyValueModel
            {
                Id = "003",
                Value = "003 MELAKA"
            });

            return account;
        }
        public List<KeyValueModel> GetAccountTypes()
        {
            List<KeyValueModel> account = new List<KeyValueModel>();
            account.Add(new KeyValueModel
            {
                Id = "",
                Value = ""
            });
            account.Add(new KeyValueModel
            {
                Id = "01",
                Value = "Normal Savings"
            });
            account.Add(new KeyValueModel
            {
                Id = "02",
                Value = "Premium Savings"
            });
            account.Add(new KeyValueModel
            {
                Id = "03",
                Value = "Current Account"
            });
            return account;
        }
        public bool CreateAccountDetail(AccountDetailModel model)
        {
            using (var conn = GetConnection())
            {
                conn.Open(); 
                bool result = true;
                try
                { 
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@Id", model.Id);
                    param.Add("@AccountNumber", model.AccountNumber);
                    param.Add("@AccountType", model.AccountType);
                    param.Add("@Name", model.Name);
                    param.Add("@IcNumber", model.IcNumber);
                    param.Add("@PhoneNumber", model.PhoneNumber);
                    param.Add("@Address", model.Address);
                    param.Add("@Gender", model.Gender);
                    param.Add("@District", model.District);
                    param.Add("@State", model.State);
                    param.Add("@BranchCode", model.BranchCode);
                    param.Add("@CounterNumber", model.CounterNumber);
                    long Id = conn.ExecuteScalar<long>("sp_CreateAccount", param,  commandType: CommandType.StoredProcedure);
                   
                }
                catch (Exception)
                {
                    result = false;
                }

                return result;
            }
        }
        public bool RemoveAccountDetail(Int64 AccountNumber)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                var transaction = conn.BeginTransaction();
                bool result = true;
                try
                {
                    DynamicParameters param = new DynamicParameters();
                    
                    param.Add("@AccountNumber",AccountNumber);
                    long Id = conn.ExecuteScalar<long>("sp_RemoveAccount", param, transaction, commandType: CommandType.StoredProcedure);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    result = false;
                }

                return result;
            }
        }
        public bool CreateTransaction(CreateTransactionModel transactionModel)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                var transaction = conn.BeginTransaction();
                bool result = true;
                try
                {
                    DynamicParameters param = new DynamicParameters();

                    param.Add("@AccountNumber", transactionModel.AccountNumber);
                    param.Add("@TransactionType", transactionModel.TransactionType);
                    param.Add("@Amount", transactionModel.Amount);
                    param.Add("@CollectionDate", transactionModel.CollectionDate);
                    param.Add("@StaffName", transactionModel.StaffName);
                    long Id = conn.ExecuteScalar<long>("sp_CreateTransaction", param, transaction, commandType: CommandType.StoredProcedure);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    result = false;
                }

                return result;
            }
        }
        public long GetLastCounter()
        {
            using (var conn = GetConnection())
            {
                conn.Open(); 
                try
                {
                    DynamicParameters param = new DynamicParameters();
                    string query = "select top 1 Isnull(CounterNumber,0)CounterNumber from AccountDetail order by CounterNumber desc ";
                    long amount = conn.ExecuteScalar<long>(query, param,  commandType: CommandType.Text);
                    return amount;
                }
                catch (Exception)
                { 
                    return -1;
                }

            }
        }
        public double GetAccountBalance(Int64 AccountNumber)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                try
                {
                    DynamicParameters param = new DynamicParameters();
                    string query = "select dbo.fn_Balance(" + AccountNumber + ") ";
                    double amount = conn.ExecuteScalar<double>(query, param,  commandType: CommandType.Text);
                    return amount;
                }
                catch (Exception)
                {
                    return 0;
                }
                 
            }
        }
        public int GetNoOfWithdraw(Int64 AccountNumber)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                try
                {
                    DynamicParameters param = new DynamicParameters();
                    string query = "select dbo.fn_CountWithdrawinMonth(" + AccountNumber + ") ";
                    int amount = conn.ExecuteScalar<int>(query, param,  commandType: CommandType.Text);
                    return amount;
                }
                catch (Exception)
                {
                    return 0;
                }

            }
        }
        public List<TransactionModel> GetTransaction(Int64 AccountNumber)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                List<TransactionModel> transactions = new List<TransactionModel>();
                try
                {
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@AccountNumber", AccountNumber);
                    var transactionslst = conn.Query<TransactionModel>("sp_GetTransaction", param, commandType: CommandType.StoredProcedure);
                    transactions= transactionslst.ToList();
                }
                catch (Exception )
                {  
                }
                return transactions;
            }
        }
        public AccountDetailModel GetAccountDetail(Int64 AccountNumber)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                AccountDetailModel account = new AccountDetailModel();
                try
                {
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@AccountNumber", AccountNumber);
                    account = conn.QueryFirstOrDefault<AccountDetailModel>("sp_GetAccountDetail", param, commandType: CommandType.StoredProcedure);
                     
                }
                catch (Exception )
                {
                }
                return account;
            }
        }
    }
}
