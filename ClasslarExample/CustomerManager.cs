namespace Classes
{
    class Customer
    {
        public int Id { get; set; }

        string _firstname;
        public string Name { 
            get { return "Mr." +
                 _firstname;
            } 
            set {
                _firstname = value;
            }
        }
        public string SurName { get; set; }
        public string City { get; set; }


    }
}