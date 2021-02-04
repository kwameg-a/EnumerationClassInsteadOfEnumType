namespace EnumerationClassInsteadOfEnumType.EmployeeTypes
{
    public class SeniorManager : EmployeeTypeBase
    {
        public SeniorManager() : base(0, "Senior Manager")
        {
        }

        public override decimal BonusSize => 3000;
    }
}
