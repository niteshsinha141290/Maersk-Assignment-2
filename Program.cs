using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the payment you want to do for as shown below : ");
            Console.WriteLine("1. Physical Product");
            Console.WriteLine("2. Book");
            Console.WriteLine("3. Membership");
            Console.WriteLine("4. Upgrade to Membership");

            int option = Console.Read();

            switch(option)
            {
                case 1: Product product = new Product(1, "XYZ");
                    product.GeneratePackingSlip();
                    product.GenerateCommissionPayment(123, 5000m);
                    break;
                case 2:
                    Book book = new Book(1, "XYZ");
                    book.GeneratePackingSlip();
                    book.GenerateCommissionPayment(123, 5000m);
                    break;
                case 3:
                    Membership membership = new Membership();
                    membership.GenerateMembership(123);
                    break;
                case 4:
                    Membership membership1 = new Membership();
                    membership1.UpgradeMembership(123);
                    break;
            }
        }
    }

    public interface IPackingSlip
    {
        void GeneratePackingSlip();
    }

    public interface IAgentService
    {
        void GenerateCommissionPayment(long agentId, decimal commissionAmount);
    }

    public interface IEmailService
    {
        void sendEmail(string template);
    }

    public class Product: IPackingSlip, IAgentService
    {
        public Product(long productId, string shippingAdress)
        {
            ProductId = productId;
            ShippingAddress = shippingAdress;
        }
        public long ProductId { get; set; }
        public string ShippingAddress { get; set; }

        public void GenerateCommissionPayment(long agentId, decimal commissionAmount)
        {
            // generation of commission payment to agent  code
        }

        public void GeneratePackingSlip()
        {
            //generation of packing slip code 
        }
    }

    public class Book : IPackingSlip, IAgentService
    {
        public Book(long productId, string shippingAdress)
        {
            ProductId = productId;
            ShippingAddress = shippingAdress;
        }
        public long ProductId { get; set; }
        public string ShippingAddress { get; set; }

        public void GenerateCommissionPayment(long agentId, decimal commissionAmount)
        {
            // generation of commission payment to agent  code
        }

        public void GeneratePackingSlip()
        {
            //generation of duplicate packing slip code 
        }
    }

    public class Membership: IEmailService
    {
        public int MembershipId { get; set; }
        public int UserId { get; set; }

        public int GenerateMembership(int UserId)
        {
            //Add membership code
            return new Random().Next();
        }

        public void sendEmail(string template)
        {
            //send Email code
        }

        public bool UpgradeMembership(int MembershipId)
        {
            //upgrade code
            return true;
        }
    }


}
