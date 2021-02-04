using EnumerationClassInsteadOfEnumType.EmployeeTypes;
using System;

namespace EnumerationClassInsteadOfEnumType
{
    class Program
    {
        static void Main(string[] args)
        {
            var seniorManager = EmployeeTypeBase.SeniorManager;
            var manager = EmployeeTypeBase.Manager;
            var assistantManager = EmployeeTypeBase.AssistantManager;
            var contractor = EmployeeTypeBase.Contractor;
                  

            Console.WriteLine($"Hello {seniorManager.DisplayName} has {seniorManager.BonusSize} bonus!");
            Console.WriteLine($"Hello {manager.DisplayName} has {manager.BonusSize} bonus!");
            Console.WriteLine($"Hello {assistantManager.DisplayName} has {assistantManager.BonusSize} bonus!");
            Console.WriteLine($"Hello {contractor.DisplayName} has {contractor.BonusSize} bonus!");
        }
    }
}
