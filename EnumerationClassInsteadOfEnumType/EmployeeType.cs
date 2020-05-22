namespace EnumerationClassInsteadOfEnumType
{
    public abstract class EmployeeType : Enumeration
    {
        public static readonly EmployeeType SeniorManager = new SeniorManagerType();
        public static readonly EmployeeType Manager = new ManagerType();
        public static readonly EmployeeType AssistantManager = new AssistantManagerType();

        private EmployeeType() { }
        private EmployeeType(int value, string displayName) : base(value, displayName) { }

        public abstract decimal BonusSize { get; }

        public class SeniorManagerType : EmployeeType
        {
            public SeniorManagerType() : base(0, "Senior Manager")
            {
            }

            public override decimal BonusSize => 3000;
        }

        private class ManagerType : EmployeeType
        {
            public ManagerType() : base(1, "Manager")
            {
            }

            public override decimal BonusSize => 20000;
        }

        public class AssistantManagerType : EmployeeType
        {
            public AssistantManagerType() : base(2, "Assistant Manager")
            {
            }

            public override decimal BonusSize => 10000;
        }
    }
}
