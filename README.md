# Code Contract

Code contracts provide a way to specify preconditions, postconditions, and object invariants in your code. Preconditions are requirements that must be met when entering a method or property. Postconditions describe expectations at the time the method or property code exits. Object invariants describe the expected state for a class that is in a good state.

- preconditions
- postconditions
- invariants

In this program using C#, is there account class as we have deposit and withdraw contract methods that use Code contract. Program.cs is our main class. There are 2 opportunities to run the program, through both windows application(possibility for user input from windows form) and console application(hard code).
 

# Requitment for use contract in C# 

The classes for code contracts can be found in the System.Diagnostics.Contracts namespace.

```sh
using System.Diagnostics.Contracts;
```

# Deposit
```sh

        public void Deposit(double d)
        {
            Contract.Requires(d >= 0);
            Contract.Ensures(Contract.OldValue(amount) + d == amount);
            amount += d;
        }
```
- expresses preconditions by using the Contract.Requires method.
- express standard postconditions by using the Ensures method


# Withdraw
```sh
        public void Withdraw(double d)
        {
            Contract.Requires(d >=0 );
            Contract.Ensures(Contract.OldValue(amount) - d == amount);
            Contract.EnsuresOnThrow<Exception>(Contract.OldValue(amount) == amount);
            if (d > amount) throw new Exception();
            amount = amount - d;
        }
```
