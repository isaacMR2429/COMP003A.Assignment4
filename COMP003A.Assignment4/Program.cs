namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This will keep track of the Tracking variables 
            int currentStep = 0;       // Keeps track on the current step you're in 
            int maximumStep = 6;     // Maximum number of steps it could reach
            int restrictedSteps = 2;   // This indicates the Restriced Steps (Skip Behavior)
            int safetyLimit = 4;       // This indicates the saftey stop
            int choice = 0;
            bool whenRunning = true;

            while (whenRunning)  // This will keep the loop going until you exit
            {
                Console.WriteLine();
                Console.WriteLine("Choice 1: Start/Continue Routine");
                Console.WriteLine("Choice 2: View Progress");
                Console.WriteLine("Choice 3: Exit");
                Console.Write("\nEnter Choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        currentStep++; // Steps continue to go keep going
                        if (currentStep == restrictedSteps) // Skips the restricted step
                        {
                            Console.WriteLine($"Step {currentStep} is restricted and was skipped");
                            continue; // Goes back to the menu option without having to complete the step
                        }
                        if (currentStep == safetyLimit) // Stops the routine early once the safety limit is reached
                        {
                            Console.WriteLine($"Step {currentStep} has activated Safety limit. Routine stopped.");
                            break; // breaks out of the switch and returns to the menu option
                        }
                        if (currentStep > maximumStep) // Stops the routine once the maximum number of steps have been completed
                        {
                            Console.WriteLine("Maximum Steps have been reached. Routine is completed");
                            break; 
                        }

                        // This pops up for every regular steps that have been completed
                        Console.WriteLine($"Routine Step {currentStep} completed.");
                        break;
                    case 2: // Choice 2 shows how many steps have been completed
                        Console.WriteLine($"Current Progress: {currentStep} steps completed");
                        break;
                    case 3:   // Choise 3 ends the Program
                        ifRunning = false;
                        Console.WriteLine("Program has Ended");
                        break;
                }
            }
        }
    }
}
