using System;

public class Program {
    //ผมทำไม่ได้ และก็ไม่เสร็จด้วย ขออภัยด้วยครับ
    public static void Main(string[] args) {
        string store = InputstoreInformation();
        string co_founder = InputCo_founderInformation();
        string staff = InputStaffInfotmation();
        int finance = InputFinanceInformation();
        string options = SelectOption();
        int confirm = ConfirmOption();

        PrintInformation(confirm);
    }

    public static string SelectOption(){
        Console.WriteLine("Select Options : ");

        return Console.ReadLine();
    }

    public static int ConfirmOption(string options) {
        if (int.TryParse(options, out int number)){

        return number;
        }

        throw new Exception("Please Input Options");
    }

    public static void PrintInformation(int confirm) {
        if (confirm = 1) {
            Console.WriteLine("capital : {0}", InputstoreInformation.capital);
            Console.WriteLine("branch : {0}", InputstoreInformation.branch);
            Console.WriteLine("address : {0}", InputstoreInformation.address);
        }

        else if (confirm = 2) {
            Console.WriteLine("Co_founder-name : {0}", InputCo_founderInformation.name);
            Console.WriteLine("Co_founder-surname : {0}", InputCo_founderInformation.surname);
            Console.WriteLine("Co_founder-id : {0}", InputCo_founderInformation.id);
        }

        else if (confirm = 3) {
            Console.WriteLine("Staff-type : {0}", InputStaffInfotmation.type);
            Console.WriteLine("Staff-name : {0}", InputStaffInfotmation.S_name);
            Console.WriteLine("Staff-surname : {0}", InputStaffInfotmation.S_surname);
            Console.WriteLine("Staff-id : {0}", InputStaffInfotmation.S_id);
            }
        else
        {
            Console.WriteLine("Monthly-income : {0}", InputFinanceInformation.monthly_income);
            Console.WriteLine("Staff_expenses : {0}", InputFinanceInformation.staff_expenses);
            Console.WriteLine("Balance : {0}", InputFinanceInformation.Balance);
        }
    }

    public static string InputstoreInformation() {
        string capital = InputCapital();
        string branch = InputBranch();
        string address = InputAddress();

        return capital, branch, address;
    }

    public static string InputCapital() {
        Console.WriteLine("Input Capital : ");

        return Console.ReadLine();
    }

    public static string InputBranch() {
        Console.WriteLine("Input Branch : ");

        return Console.ReadLine();
    }

    public static string InputAddress() {
        Console.WriteLine("Input Address : ");

        return Console.ReadLine();
    }

    public static string InputCo_founderInformation() {
        string name = InputName();
        string surname = InputSurname();
        string id = InputId();

        return name, surname, id;
    }

    public static string InputName() {
        Console.WriteLine("Input Name : ");

        return Console.ReadLine();
    }

    public static string InputSurname() {
        Console.WriteLine("Input Surname : ");

        return Console.ReadLine();
    }

    public static string InputId() {
        Console.WriteLine("Input Id : ");

        return Console.ReadLine();
    }

    public static string InputStaffInfotmation() {
        string type = InputType();
        string S_name = InputS_Name();
        string S_surname = InputS_Surname();
        string S_id = InputS_Id();
    }

        public static string InputType() {
        Console.WriteLine("Input Type : ");

        return Console.ReadLine();
    }

        public static string InputS_Name() {
        Console.WriteLine("Input Staff Name : ");

        return Console.ReadLine();
    }

        public static string InputS_Surname() {
        Console.WriteLine("Input Staff Surname : ");

        return Console.ReadLine();
    }

        public static string InputS_Id() {
        Console.WriteLine("Input Staff Id : ");

        return Console.ReadLine();
    }

    public static int InputFinanceInformation() {
        int monthly_income = InputMonthly_Income();
        int staff_expenses = InputStaff_Expenses();
        int balance = InputBalance();
    }
    public static string InputMonthly_Income() {
        Console.WriteLine("Input Income : ");

        return Console.ReadLine();
    }
    public static string InputStaff_Expenses() {
        Console.WriteLine("Input Expenses : ");

        return Console.ReadLine();
    }
    public static string InputBalance() {
        Console.WriteLine("Input Balance : ");

        return Console.ReadLine();
    }
}