public abstract class Calculation
{
    private  int Amount;                                                                                                              
    private int Data;
       
}
public abstract class Login: Calculation  
{
    private int UserLogin;
       
}
public class NaturalPerson: Login
{
    private int PassportData;
}
public class Client: Login
{
    private int CardNumber;
    private int PassportData;
}

public class Director: Login
{
    private int CommissionAmount;
    private int Wallet;
}

 public class CryptoWallet: Login
{ 
    private int Wallet;
}

public class LegalEntity: Calculation
{ 
    private int SettlementAccount;
    private int IDBank;
}

















