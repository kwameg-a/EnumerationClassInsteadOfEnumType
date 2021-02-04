namespace EnumerationClassInsteadOfEnumType.EmployeeTypes
{
    public class Contractor : EmployeeTypeBase
    {
        public Contractor() : base(3, "Contractor")
        {

        }

        public override decimal BonusSize => 0;
    }
}
