namespace WebAddressbookTests
{
    public class ContactDate
    {
        private string firstname;
        private string lastname = "";

        public ContactDate(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public string Firstname
        {
            get
            {
                return firstname;

            }
            set
            {
                firstname = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;

            }
            set
            {
                lastname = value;
            }
        }
    }
}
