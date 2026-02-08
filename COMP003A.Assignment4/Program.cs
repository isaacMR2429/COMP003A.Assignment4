namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This will keep track of the Tracking variables 
            int currentStep = 0;       // Keeps track on the current step you're in 
            int maximumStep = 10;     // Maximum number of steps it could reach
            int restrictedSteps = 3;   // This indicates the Restriced Steps (Skip Behavior)
            int safetyLimit = 7;       // This indicates the saftey stop
            int choice = 0;
            bool ifRunning = true;

            while (ifRunning)  // This will keep the loop going until you exit
            {
                Console.WriteLine("Choice 1: Start/Continue Routine");
                Console.WriteLine("Choice 2: View Progress");
                Console.WriteLine("Choice 3: Exit");
                Console.Write("Enter Choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        currentStep++;
                        if (currentStep == restrictedSteps)
                        {
                            Console.WriteLine($"Step {currentStep} is restrcited and was skipped");
                            continue;
                        }
                        if (currentStep == safetyLimit)
                        {
                            Console.WriteLine("Saftey limit reached. Routine stopped.");
                            break;
                        }
                        if (currentStep > maximumStep)
                        {
                            Console.WriteLine("Maximum Steps has been reached. Routine is completed");
                            break; 
                        }
                        Console.WriteLine($"Routine Step {currentStep} completed.");
                        break;
                }
            }
        }
    }
}
