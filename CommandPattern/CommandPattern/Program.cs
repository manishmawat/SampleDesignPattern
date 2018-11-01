using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount(0);
            var commands = new List<BankAccountCommand>();

            commands.Add(new BankAccountCommand(bankAccount, ActionType.Deposit, 100));
            commands.Add(new BankAccountCommand(bankAccount, ActionType.Withdraw, 50));

            foreach (var command in commands)
                command.Call();
            WriteLine(bankAccount);

            foreach (var undoCommand in Enumerable.Reverse(commands))
                undoCommand.Undo();
            WriteLine(bankAccount);
        }
    }

    public class BankAccount
    {
        public BankAccount(int amount)
        {
            Balance = amount;
        }
        //private int _balance;

        //private int _overDraftLimit;
        public int Balance { get; private set; }
        public int OverDraftLimit { get; private set; } = -100;

        public bool Withdraw(int amount)
        {
            if (amount < 0) return false;
            if (Balance - amount > OverDraftLimit)
            {
                Balance -= amount;
                WriteLine($"${amount} has been withdrawn from the account");
                return true;
            }
            WriteLine($"Do not have sufficient balance");
            return false;
        }

        public bool Deposit(int amount)
        {
            if (amount < 0) return false;
            Balance += amount;
            WriteLine($"${amount} deposited to the account");
            return true;
        }

        public override string ToString()
        {
            return $"Balance is ${Balance}";
        }
    }
    public enum ActionType
    {
        Deposit,
        Withdraw,
        BalanceCheck
    }
    interface ICommand
    {
        void Call();
        void Undo();
    }

    public class BankAccountCommand : ICommand
    {
        BankAccount bankAccount;
        ActionType action;
        int amount;
        bool success = true;

        public BankAccountCommand(BankAccount bankAccount, ActionType action, int amount)
        {
            this.bankAccount = bankAccount;
            this.action = action;
            this.amount = amount;
        }

        public void Call()
        {
            if (!success) return;
            switch (action)
            {
                case ActionType.Deposit:
                    bankAccount.Deposit(amount);
                    success = true;
                    break;
                case ActionType.Withdraw:
                    success = bankAccount.Withdraw(amount);
                    break;
                default:
                    break;
            }
        }

        public void Undo()
        {
            if (!success) return;
            switch (action)
            {
                case ActionType.Deposit:
                    bankAccount.Withdraw(amount);
                    break;
                case ActionType.Withdraw:
                    bankAccount.Deposit(amount);
                    break;
                default:
                    break;
            }
        }
    }
}
