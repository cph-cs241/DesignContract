# DesignContract


There is account classe as we have deposit and withdraw contract methods. Program.cs is our main classe. There are 2 opportunities to run the program, through both windows application and console.

# Requitment for use contract in C# in Account classe
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

- Requires 

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
