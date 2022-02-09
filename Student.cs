using System;

namespace ClassRegister
{
    public class Student
    {
        public Student()
        {
            System.Console.WriteLine("please fill in your details in this format");
            System.Console.WriteLine("FirstName: \nSecondName:");
            Id = Guid.NewGuid();
        }
        public Guid Id { get; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Fullname
        {
            get
            {
                return !string.IsNullOrWhiteSpace(Lastname) ? $"{Lastname} {Firstname}" : Firstname;
            }
        }
        public string Gender { get; set; }
        public string[] Gadgets { get; set; }

        public string Email;

        public string phoneNumber;

        // overriding the tocstring method     
        public override string ToString()
        {
            return $"Id: {Id}\nFullname: {Fullname}\nGender: {Gender}\nEmail: {Email}\nPhone number: {phoneNumber}\nGadgets: {string.Join(", ", Gadgets)}\n";
        }
    }
}