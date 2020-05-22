using System;

namespace EnumerationClassInsteadOfEnumType
{
    class Program
    {
        static void Main(string[] args)
        {
            var seniorManager = EmployeeType.SeniorManager;
            var manager = EmployeeType.Manager;
            var assistantManager = EmployeeType.AssistantManager;

            Console.WriteLine($"Hello {seniorManager.DisplayName} has {seniorManager.BonusSize} bonus!");
            Console.WriteLine($"Hello {manager.DisplayName} has {manager.BonusSize} bonus!");
            Console.WriteLine($"Hello {assistantManager.DisplayName} has {assistantManager.BonusSize} bonus!");
        }
    }
}
