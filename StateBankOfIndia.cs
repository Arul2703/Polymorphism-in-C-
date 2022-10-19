class StateBankOfIndiaAccount : BankAccount{
  private string address;
  public double rateOfInterest = 7.75;
  public int choice;
  public string mobile;
  public string aadhaar;
  private string username,password,newPassword;
  public StateBankOfIndiaAccount(double accountNo,string name,int CIFNumber,string aadhaarNumber,int balance,string bankName, string branchName,string IFSCCode,string address,string mobileNumber,string username,string password):base(accountNo,name,CIFNumber,1000,bankName,branchName,IFSCCode,username,password){
    this.address = address;
    this.mobileNumber = mobileNumber;
    this.aadhaarNumber = aadhaarNumber;
    this.CIFNumber = CIFNumber;
    Console.WriteLine("Your account has been created successfully...");
  }

  
  public void resetLoginPassword(){
    Console.Write("Enter your Aadhaar and Mobile Number");
    Console.Write("Aadhaar Number: ");
    aadhaar = Console.ReadLine();
    Console.Write("Mobile Number: ");
    mobile = Console.ReadLine();
    if(aadhaar == aadhaarNumber && mobile == mobileNumber){
      Console.Write("Enter New Password:");
        password = Console.ReadLine();
        Console.WriteLine("Confirm New Password: ");
        newPassword = Console.ReadLine();
        if(password==newPassword){
          Console.WriteLine("Your password has been reset successfully.");
        }
    }
    
  }
  public override void validateLoginPassword()
  { if(verifyUserNameAndPassword()){
      Console.WriteLine("You're successfully logged in.");
    }
    else{
      Console.Write("The Password which you had entered is wrong..");
      Console.WriteLine("You can reset your password by entering either of these details");
      Console.WriteLine("1. Account Number,CIF Number, IFSC Code");
      Console.WriteLine("2. Aadhaar Number,Mobile Number.");
      Console.WriteLine("Enter your choice:");
      choice = Convert.ToInt32(Console.ReadLine());
      switch(choice){
        case 1:
          base.validateLoginPassword();
          break;
        case 2:
          resetLoginPassword();
          break;
      }  
    }
    
  }
}