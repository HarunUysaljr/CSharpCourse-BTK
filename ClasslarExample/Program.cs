using Classes;

Customer customer = new Customer();

add eklendi = new add();

eklendi.customerAdd();

customer.Id = 1;
customer.Name = "harun";
customer.SurName = "Uysal";
customer.City = "Ankara";

Console.WriteLine(customer.Name);

Console.ReadLine();
