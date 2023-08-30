using RestaurantSystem;

Console.WriteLine("Welcome to Restaurant System");
Console.WriteLine("Menu:");

//Object Creation
FoodItem Pasta = new FoodItem("Pasta", 100, "Starter", false);
Console.WriteLine(Pasta.ItemName + "-" + Pasta.Price+", Type: "+Pasta.Type+", Is Veg: "+Pasta.IsVeg);
FoodItem Fries = new FoodItem("Fries",80, "Starter", true);
Console.WriteLine(Fries.ItemName + "-" +Fries.Price + ", Type: " + Fries.Type + ", Is Veg: " + Fries.IsVeg);

Console.WriteLine("ROLES: ");
Console.WriteLine("Chef: ");

RestaurantEmployees chef1 = new Chef(1, "Ravi");
Console.WriteLine(chef1.EmpName);

Console.WriteLine("Waiter: ");

RestaurantEmployees waiter1 = new Waiter(2, "Hari");
Console.WriteLine(waiter1.EmpName);


Console.WriteLine("Receptionist: ");

RestaurantEmployees receptionist1 = new Receptionist(3, "Shyam");
Console.WriteLine(receptionist1.EmpName);



