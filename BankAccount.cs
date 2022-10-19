class BankAccount{
  private string name,bankBranchName,userName,loginUserName,loginPassword,password,newPassword;
  public double accountNumber;
  public string aadhaarNumber,mobileNumber;
  readonly string bankName;
  private string IFSCCode,IFSC;
  public int number,CIFNumber,CIF;
  private int balance = 1000;

  public BankAccount(double accountNo,string name,int CIFnumber,int balance,string bankName , string branchName,string IFSCCode,string username,string password){  
    this.accountNumber = accountNo;
    this.name = name;
    this.CIFNumber=CIFnumber;
    this.balance = balance;
    this.bankName = bankName;
    bankBranchName = branchName;
    this.IFSCCode = IFSCCode;
    loginUserName = username;
    loginPassword = password;
  }

  public virtual void validateLoginPassword(){
    if(verifyUserNameAndPassword()){
      Console.WriteLine("You're successfully logged in.");
    }
    else{
      changePassword(); 
    }
  }
  public bool verifyUserNameAndPassword(){
    Console.WriteLine("Enter the username and password to login:");
    Console.Write("User Name: ");
    userName = Console.ReadLine();
    Console.WriteLine("Password: ");
    password = Console.ReadLine();
    if(userName == loginUserName && password == loginPassword){
      return true;
    }
    else{
      return false;
    }
  }

  public void setNewUserNameAndPassword(){
    Console.Write("Enter New Password:");
        password = Console.ReadLine();
        Console.WriteLine("Confirm New Password: ");
        newPassword = Console.ReadLine();
        if(password==newPassword){
          Console.WriteLine("Your password has been reset successfully.");
        }
  }
  public virtual void changePassword(){
    Console.WriteLine("If you had forget your password , Then you can reset the password by entering CIF number,Account number and IFSC Code:");
      Console.Write("Account Number: ");
      number = Convert.ToInt32(Console.ReadLine());
      Console.Write("CIF Number: ");
      CIF = Convert.ToInt32(Console.ReadLine());
      Console.Write("IFSC Code: ");
      IFSC = Console.ReadLine();
      if(number==accountNumber && CIF == CIFNumber && IFSC == IFSCCode){
          setNewUserNameAndPassword();
        }
  }
}
  


