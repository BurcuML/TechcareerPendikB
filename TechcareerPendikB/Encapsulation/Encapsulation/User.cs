using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// init yazdığımızda değeri tekrar değiştermiyoruz, değeri değiştirilemez hale getiriyoruz, immutable bir yapı sunar
namespace Encapsulation
{



    public class User
    {    
        
    private string firstName;
    private string lastName;
    private string email;
        private string fullName;

        private string name;
        public string FirstName {
            get
            {
                return firstName;
            }
            set
            {
                if (value.Length < 2)
                {
                    Console.WriteLine("Minimum 2 haneli olmalıdır.");
                    return;
                }
                firstName = value;
            } 
        }
        public string LastName { get; set; }
        public string Email {
            get
            {
                return email;
            }
            set {
                email = value;
                if (!email.EndsWith("@gmail.com"))
                {
                    Console.WriteLine("Hata");
                }
            }
        }
        public string Password { get; init; }
        public string UserName { get; set; }
        public string FullName { 
            
            get { 
                return fullName;
            }
            private set { 
            fullName = $"{firstName}:{lastName}";
            } 
        }

        public override string ToString()
        {
            return $"Ad: {FirstName}, Soyad: {LastName}, Email: {Email}, Password: {Password}, Username: {UserName}, Fullname: {FullName} ";
        }

    }
}
