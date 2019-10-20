class Account {
    public decimal Balance { 
        get; 
        private set; 
        }

    public Account(decimal initialBalance) {
        if(initialBalance < 0)
            throw new ArgumentOutOfRangeException("The initial balance must be greater or equals to 0");
        this.Balance = initialBalance;
    }

    public bool TryDeposit(decimal amount) {
        if(amount <= 0)
            return false;
        this.Balance += amount;
        return true;
    }

    public bool TryWithdraw(decimal amount) {
        if(amount <= 0 || this.Balance - amount < 0)
            return false;
        this.Balance -= amount;
        return true;
    }
}