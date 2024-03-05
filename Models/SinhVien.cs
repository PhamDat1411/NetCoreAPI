using FirstWebMVC.Models;
    public class SinhVien
    {
        public string? FullName{get; set; }
        public string? Address{get; set; }
        public int Age{get; set; }
        public decimal PhoneNumber{get; set; }
        public void EnterData()
        {
            System.Console.Write("FullName");
            FullName = Console.ReadLine();
            System.Console.Write("Address");
            Address = Console.ReadLine();
            System.Console.Write("Age");
            Age = Convert.ToInt16(Console.ReadLine());
            System.Console.Write("PhoneNumber");
            PhoneNumber = Convert.ToDecimal(Console.ReadLine());
            try{
                //câu lệnh có thể gây ngoại lệ
                Age = Convert.ToInt16(Console.ReadLine());
                PhoneNumber = Convert.ToDecimal(Console.ReadLine());
            }catch(Exception )
            {
                //Câu lệnh xử lí ngoại lê
                Age = 0;
                PhoneNumber = 0147896523;
            }
        }
        public void Display()
        {
            System.Console.WriteLine("{0} - {1} - {2} - {3}", FullName, Address, Age, PhoneNumber);
        }
    }
