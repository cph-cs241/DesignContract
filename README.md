# Code Contract

Code contracts provide a way to specify preconditions, postconditions, and object invariants in the code. Preconditions are requirements that must be met when entering a method or property. Postconditions describe expectations at the time the method or property code exits. Object invariants describe the expected state for a class that is in a good state.

- preconditions
- postconditions
- invariants

For Code Contract installation : https://marketplace.visualstudio.com/items?itemName=RiSEResearchinSoftwareEngineering.CodeContractsforNET

Efter installation you can se the Code Contracts Property Page in the project propertise 


![image](https://user-images.githubusercontent.com/20173643/49053309-f08c3b80-f1ef-11e8-8fba-bd99b681e39f.png)

In the project in account class as we have deposit and withdraw contract methods that use Code contract. Program.cs is our main class. There are 2 opportunities to run the program, through both windows application(possibility for user input from windows form) and console application(hard code).
 

# Requitment 

The classes for code contracts can be found in the System.Diagnostics.Contracts namespace.

```sh
using System.Diagnostics.Contracts;
```

# Contract methodes
. Diposit
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


- Withdraw
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
