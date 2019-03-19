
namespace CityCM.BL
{
    public class Customer
    {
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public string FullName
        {
            get {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }

                return fullName;
            }
        }
        // the static modifier is used on members of the Class itself instead of instance of objects created from it

        public static int InstanceCount { get; set; }


        private string _lastName;

        public string LastName
        {
            get { return _lastName; }

            set { _lastName = value; }
        }
        
    }
}
 