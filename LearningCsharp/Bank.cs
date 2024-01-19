namespace myapp;

class bank
{
    public string accountnumber { get; private set; }
    public string nameuseraccount { get; private set; }
    private double _amout;
    public bool initialdeposit;

    public bank(string accountnumber, string nameuseraccount)
    {
        accountnumber = accountnumber;
        nameuseraccount = nameuseraccount;
    }

    public bank(
        string accountnumber,
        string nameuseraccount,
        bool initialdeposit) : this(accountnumber, nameuseraccount)
    {
        initialdeposit = initialdeposit;
    }

    public double Amout
    {
        get { return _amout; }
        set
        {
            if (value > 0)
            {
                _amout = value;
            }
        }
    }

    public void depositamount(double amout)
    {
        Amout(amout);
        info();
    }

    public void withdraw(double amount)
    {
        double amountaccount = getamount();
        double newamount = amountaccount - amount;
        setamount(newamount);
        info();
    }

    public double getamount()
    {
        return Amounts;
    }

    public void info()
    {
        Console.WriteLine($"conta: {accountnumber}, nameuser: {nameuseraccount}, amount: {Amounts}");
    }
}
