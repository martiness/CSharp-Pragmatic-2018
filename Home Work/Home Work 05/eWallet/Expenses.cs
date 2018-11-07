namespace eWallet
{
    public enum ExpensesCategories
    {
        Bills = 0,
        Food = 1,
        Transport = 2,
        Clothes = 3,
        ChildCare = 4,
        MedicalCare = 5,
        PetCare = 6,
        Leasures = 7,
        Hobies = 8,
        Vacation = 9,
        Gifts = 10
    }

    public class Expenses
    {
        string expenseDescription = string.Empty;
        string expenseDateTime = string.Empty;
        string expenseAmount = string.Empty;

    }
}
