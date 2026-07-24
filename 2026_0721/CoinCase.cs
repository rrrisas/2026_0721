class CoinCase
    {
    private int aCoin = 0;
    private int bCoin = 0;
    private int cCoin = 0;
    private int dCoin = 0;
    private int eCoin = 0;
    private int fCoin = 0;

    public void AddCoins(int x, int y)
    {
        if(x == 500)
        {
            aCoin += y;
        }
        else if(x ==100)
        {
            bCoin += y;
        }
        else if (x == 50)
        {
            cCoin += y;
        }
        else if (x == 10)
        {
            dCoin += y;
        }
        else if (x == 5)
        {
            eCoin += y;
        }
        else if (x == 1)
        {
            fCoin += y;
        }
    }

    public int GetCount(int x) 
       {
        if(x == 500)
        {
            return aCoin;
        }
        else if (x == 100)
        {
            return bCoin;
        }
        else if (x == 50)
        {
            return cCoin;
        }
        else if (x == 10)
        {
            return dCoin;
        }
        else if (x == 5)
        {
            return eCoin;
        }
        else if (x == 1)
        {
            return fCoin;
        }

        return 0;
    }

    public int GetAmount(int x)
    {
        {
            if (x == 500)
            {
                return aCoin * 500;
            }
            else if (x == 100)
            {
                return bCoin * 100;
            }
            else if (x == 50)
            {
                return cCoin * 50;
            }
            else if (x == 10)
            {
                return dCoin * 10;
            }
            else if (x == 5)
            {
                return eCoin * 5;
            }
            else if (x == 1)
            {
                return fCoin;
            }

            return 0;
        }
    }

    public int GetCount()
    {
        return aCoin + bCoin + cCoin + eCoin + fCoin;

    }
    public int GetAmount()
    {
        return aCoin * 500 + bCoin * 100 + cCoin * 50 + dCoin * 10 + eCoin * 5 + fCoin * 1;
    }
    
}
