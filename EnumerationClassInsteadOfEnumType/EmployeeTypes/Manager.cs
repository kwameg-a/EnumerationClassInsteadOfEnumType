namespace EnumerationClassInsteadOfEnumType.EmployeeTypes
{
    public class Manager : EmployeeTypeBase
    {
        public Manager() : base(1, "Manager")
        {
        }

        public override decimal BonusSize => 20000;
    }
}
