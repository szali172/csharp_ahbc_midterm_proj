using FitnessCenter;

static void Main() 
{

    // Initialize the UI with members and clubs
    UI ui = new UI(null, null);

    // Directly call RemoveMemberScreen method
    ui.MainPage();
  
    // Keep the console open to view results
    Console.WriteLine("Press any key to exit...");
    Console.ReadKey();

}

Main();


