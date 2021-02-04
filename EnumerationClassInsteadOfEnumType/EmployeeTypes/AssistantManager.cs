namespace EnumerationClassInsteadOfEnumType.EmployeeTypes
{
    public class AssistantManager : EmployeeTypeBase
    {
        public AssistantManager() : base(2, "Assistant Manager")
        {
        }

        public override decimal BonusSize => 10000;
    }
}
