// See https://aka.ms/new-console-template for more information
using System.Security.Principal;

Console.WriteLine("Hello, World!");

List<Customer> customerList = new List<Customer>
{
    new Customer(1, new DateTime(2021, 4, 30), new DateTime(2021, 5, 3), 250000.00m),
    new Customer(2, new DateTime(2021, 4, 30), new DateTime(2021, 5, 3), 250000.00m),
    new Customer(3, new DateTime(2021, 4, 19), new DateTime(2021, 4, 20), 228500.00m),
    new Customer(4, new DateTime(2021, 7, 9), new DateTime(2021, 7, 12), 43615.70m),
    new Customer(5, new DateTime(2021, 7, 5), new DateTime(2021, 7, 5), 50000.00m),
    new Customer(6, new DateTime(2021, 7, 2), new DateTime(2021, 7, 5), 40000.00m),
    new Customer(7, new DateTime(2021, 6, 25), new DateTime(2021, 6, 28), 30000.00m),
    new Customer(8, new DateTime(2021, 6, 25), new DateTime(2021, 6, 28), 80000.00m),
    new Customer(9, new DateTime(2021, 6, 20), new DateTime(2021, 6, 22), 153935.65m),
    new Customer(10, new DateTime(2021, 6, 18), new DateTime(2021, 6, 21), 115000.00m),
    new Customer(11, new DateTime(2021, 6, 15), new DateTime(2021, 6, 16), 120000.00m),
    new Customer(12, new DateTime(2021, 6, 11), new DateTime(2021, 6, 14), 50000.00m),
    new Customer(13, new DateTime(2021, 6, 25), new DateTime(2021, 6, 28), 20000.00m),
    new Customer(14, new DateTime(2021, 5, 31), new DateTime(2021, 5, 31), 100000.00m),
    new Customer(15, new DateTime(2021, 5, 29), new DateTime(2021, 6, 1), 97154.19m),
    new Customer(16, new DateTime(2021, 5, 29), new DateTime(2021, 6, 1), 60000.00m),
    new Customer(17, new DateTime(2021, 5, 19), new DateTime(2021, 5, 28), 116000.00m),
    new Customer(18, new DateTime(2021, 5, 18), new DateTime(2021, 5, 20), 133581.00m),
    new Customer(19, new DateTime(2021, 5, 10), new DateTime(2021, 5, 11), 85000.00m),
    new Customer(20, new DateTime(2021, 5, 7), new DateTime(2021, 5, 10), 125000.00m),
    new Customer(21, new DateTime(2021, 5, 10), new DateTime(2021, 5, 11), 50600.00m),
    new Customer(22, new DateTime(2021, 5, 8), new DateTime(2021, 5, 11), 150000.00m),
    new Customer(23, new DateTime(2021, 5, 28), new DateTime(2021, 5, 31), 45000.00m),
    new Customer(24, new DateTime(2021, 4, 30), new DateTime(2021, 6, 2), 130300.00m),
    new Customer(25, new DateTime(2021, 4, 27), new DateTime(2021, 4, 28), 228527.07m),
    new Customer(26, new DateTime(2021, 4, 30), new DateTime(2021, 5, 3), 150000.00m),
    new Customer(27, new DateTime(2021, 4, 30), new DateTime(2021, 5, 3), 191400.69m),
    new Customer(28, new DateTime(2021, 4, 9), new DateTime(2021, 4, 12), 10000.00m),
    new Customer(29, new DateTime(2021, 9, 30), new DateTime(2021, 10, 1), 100000.00m),
    new Customer(30, new DateTime(2021, 6, 8), new DateTime(2021, 6, 9), 120000.00m),
     new Customer(31, new DateTime(2021, 6, 25), new DateTime(2021, 6, 28), 150000.00m),
    new Customer(32, new DateTime(2021, 7, 9), new DateTime(2021, 7, 12), 146400.00m),
    new Customer(33, new DateTime(2021, 7, 9), new DateTime(2021, 7, 12), 65000.00m),
    new Customer(34, new DateTime(2021, 7, 2), new DateTime(2021, 7, 5), 65000.00m),
    new Customer(35, new DateTime(2021, 7, 31), new DateTime(2021, 8, 3), 106000.00m),
    new Customer(36, new DateTime(2021, 7, 31), new DateTime(2021, 8, 3), 100000.00m),
    new Customer(37, new DateTime(2021, 10, 31), new DateTime(2021, 11, 2), 40000.00m),
    new Customer(38, new DateTime(2021, 7, 31), new DateTime(2021, 8, 3), 60000.00m),
    new Customer(39, new DateTime(2021, 5, 31), new DateTime(2021, 6, 1), 6000.00m),
    new Customer(40, new DateTime(2021, 5, 10), new DateTime(2021, 5, 11), 18537.66m),
    new Customer(41, new DateTime(2021, 5, 30), new DateTime(2021, 6, 1), 15000.00m),
    new Customer(42, new DateTime(2021, 7, 3), new DateTime(2021, 7, 6), 75000.00m),
    new Customer(43, new DateTime(2021, 12, 9), new DateTime(2021, 12, 10), 65000.00m),
    new Customer(44, new DateTime(2021, 7, 12), new DateTime(2021, 7, 13), 31309.00m),
    new Customer(45, new DateTime(2021, 9, 22), new DateTime(2021, 9, 23), 75000.00m),
    new Customer(46, new DateTime(2021, 7, 10), new DateTime(2021, 7, 13), 250000.00m),
    new Customer(47, new DateTime(2021, 10, 10), new DateTime(2021, 10, 12), 263000.00m),
    new Customer(48, new DateTime(2021, 7, 10), new DateTime(2021, 7, 13), 70000.00m),
    new Customer(49, new DateTime(2021, 9, 24), new DateTime(2021, 9, 27), 75000.00m),
    new Customer(50, new DateTime(2021, 10, 31), new DateTime(2021, 11, 2), 36019.50m),
    new Customer(51, new DateTime(2021, 9, 30), new DateTime(2021, 10, 1), 263000.00m),
    new Customer(52, new DateTime(2021, 7, 9), new DateTime(2021, 7, 12), 220408.68m),
    new Customer(53, new DateTime(2021, 10, 5), new DateTime(2021, 10, 6), 240000.00m),
    new Customer(54, new DateTime(2021, 7, 9), new DateTime(2021, 7, 12), 107000.00m),
    new Customer(55, new DateTime(2021, 10, 5), new DateTime(2021, 10, 5), 238000.00m),
    new Customer(56, new DateTime(2021, 9, 15), new DateTime(2021, 9, 16), 100000.00m),
    new Customer(57, new DateTime(2021, 2, 15), new DateTime(2021, 2, 16), 105425.00m),
    new Customer(58, new DateTime(2021, 3, 22), new DateTime(2021, 3, 23), 154000.00m),
    new Customer(59, new DateTime(2021, 6, 25), new DateTime(2021, 6, 28), 12500.00m),
    new Customer(60, new DateTime(2021, 6, 30), new DateTime(2021, 7, 1), 180000.00m),
     new Customer(61, new DateTime(2021, 6, 30), new DateTime(2021, 7, 1), 40000.00m),
    new Customer(62, new DateTime(2021, 6, 15), new DateTime(2021, 6, 18), 100000.00m),
    new Customer(63, new DateTime(2021, 4, 30), new DateTime(2021, 5, 6), 20000.00m),
    new Customer(64, new DateTime(2021, 6, 30), new DateTime(2021, 6, 30), 35000.00m),
    new Customer(65, new DateTime(2021, 4, 30), new DateTime(2021, 5, 3), 95000.00m),
    new Customer(66, new DateTime(2021, 4, 15), new DateTime(2021, 4, 16), 104332.49m),
    new Customer(67, new DateTime(2021, 3, 25), new DateTime(2021, 3, 26), 200000.00m),
    new Customer(68, new DateTime(2021, 3, 31), new DateTime(2021, 4, 1), 25000.00m),
    new Customer(69, new DateTime(2021, 5, 31), new DateTime(2021, 6, 1), 166000.00m),
    new Customer(70, new DateTime(2021, 8, 10), new DateTime(2021, 8, 11), 100084.45m),
    new Customer(71, new DateTime(2021, 8, 18), new DateTime(2021, 8, 19), 30000.00m),
    new Customer(72, new DateTime(2021, 8, 15), new DateTime(2021, 8, 17), 134209.28m),
    new Customer(73, new DateTime(2021, 8, 31), new DateTime(2021, 9, 1), 75810.00m),
    new Customer(74, new DateTime(2021, 8, 31), new DateTime(2021, 9, 1), 70400.00m),
    new Customer(75, new DateTime(2021, 8, 31), new DateTime(2021, 9, 1), 60000.00m),
    new Customer(76, new DateTime(2021, 7, 30), new DateTime(2021, 8, 2), 167750.19m),
    new Customer(77, new DateTime(2021, 9, 30), new DateTime(2021, 10, 1), 50000.00m),
    new Customer(78, new DateTime(2021, 9, 30), new DateTime(2021, 10, 1), 50000.00m),
    new Customer(79, new DateTime(2021, 7, 28), new DateTime(2021, 7, 29), 78657.00m),
    new Customer(80, new DateTime(2021, 7, 22), new DateTime(2021, 7, 27), 78504.00m),
    new Customer(81, new DateTime(2021, 8, 6), new DateTime(2021, 8, 9), 80000.00m),
    new Customer(82, new DateTime(2021, 9, 24), new DateTime(2021, 9, 27), 75992.00m),
    new Customer(83, new DateTime(2021, 8, 27), new DateTime(2021, 8, 31), 60000.00m),
    new Customer(84, new DateTime(2021, 8, 31), new DateTime(2021, 9, 1), 50000.00m),
    new Customer(85, new DateTime(2021, 10, 30), new DateTime(2021, 11, 2), 17790.00m),
    new Customer(86, new DateTime(2021, 9, 24), new DateTime(2021, 9, 24), 80000.00m),
    new Customer(87, new DateTime(2021, 10, 10), new DateTime(2021, 10, 12), 182000.00m),
    new Customer(88, new DateTime(2021, 10, 30), new DateTime(2021, 11, 2), 20000.00m),
    new Customer(89, new DateTime(2021, 9, 25), new DateTime(2021, 9, 28), 86829.61m),
    new Customer(90, new DateTime(2021, 9, 28), new DateTime(2021, 9, 29), 100000.00m),
     new Customer(91, new DateTime(2021, 10, 31), new DateTime(2021, 11, 2), 35000.00m),
    new Customer(92, new DateTime(2021, 10, 16), new DateTime(2021, 10, 19), 50000.00m),
    new Customer(93, new DateTime(2021, 10, 6), new DateTime(2021, 10, 7), 55000.00m),
    new Customer(94, new DateTime(2021, 9, 30), new DateTime(2021, 10, 1), 17790.00m),
    new Customer(95, new DateTime(2021, 10, 10), new DateTime(2021, 10, 12), 318000.00m),
    new Customer(96, new DateTime(2021, 10, 31), new DateTime(2021, 11, 2), 22250.00m),
    new Customer(97, new DateTime(2021, 10, 25), new DateTime(2021, 10, 26), 56000.00m),
    new Customer(98, new DateTime(2021, 9, 24), new DateTime(2021, 9, 27), 23903.00m),
    new Customer(99, new DateTime(2022, 1, 29), new DateTime(2022, 2, 1), 436000.00m),
    new Customer(100, new DateTime(2022, 1, 30), new DateTime(2022, 2, 1), 275000.00m),
    new Customer(101, new DateTime(2022, 1, 31), new DateTime(2022, 2, 1), 71001.08m),
    new Customer(102, new DateTime(2022, 1, 31), new DateTime(2022, 2, 1), 20000.00m),
    new Customer(103, new DateTime(2022, 2, 7), new DateTime(2022, 2, 8), 43590.00m),
    new Customer(104, new DateTime(2022, 2, 28), new DateTime(2022, 2, 28), 250000.00m),
    new Customer(105, new DateTime(2022, 2, 2), new DateTime(2022, 2, 4), 100000.00m),
    new Customer(106, new DateTime(2021, 9, 23), new DateTime(2021, 9, 24), 31550.00m),
    new Customer(107, new DateTime(2021, 2, 18), new DateTime(2021, 2, 19), 61051.55m),
    new Customer(108, new DateTime(2021, 7, 19), new DateTime(2021, 7, 27), 50000.00m),
    new Customer(109, new DateTime(2021, 6, 30), new DateTime(2021, 7, 1), 150000.00m),
    new Customer(110, new DateTime(2022, 5, 18),  null   , 27000.00m), // Ödeme tarihi yok
    new Customer(111, new DateTime(2021, 10, 21), new DateTime(2021, 10, 22), 87000.00m),
    new Customer(112, new DateTime(2020, 10, 31), new DateTime(2020, 11, 2), 60000.00m),
    new Customer(113, new DateTime(2021, 1, 10), new DateTime(2021, 1, 12), 100000.00m)
};





MaxDebt(customerList);

 static void MaxDebt(List<Customer> customers)
{
    decimal maxDebt = 0;
    DateTime maxDebtDate=DateTime.Now;

    ////for (DateTime tempDate = new DateTime(1999, 12, 30); tempDate < DateTime.Now; tempDate = tempDate. ///*AddDays(1))*/
    foreach(var myDate in customers)
    {
        DateTime tempDate=myDate.BillDate;
        decimal currentBorc = 0;
        foreach (Customer customer in customers)
        {
            if (customer.BillDate < tempDate && (customer.PayDate > tempDate || customer.PayDate == null))
            {
                currentBorc += customer.PayAmount;
            }


            if (currentBorc > maxDebt)
            {
                maxDebt = currentBorc;
                maxDebtDate = tempDate;
            }
        }
    }
    Console.WriteLine(maxDebt);
    Console.WriteLine(maxDebtDate);

}





Console.ReadLine();
public class Customer
{
    public int  ID { get; set; }
    public  DateTime BillDate { get; set; }

    public DateTime?  PayDate { get; set; }

    public decimal PayAmount { get; set; }

    public Customer(int id, DateTime billDate, DateTime? payDate, decimal amount)
    {
        ID = id;
        BillDate = billDate;
        PayDate = payDate;
        PayAmount = amount;
    }
}
