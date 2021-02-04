namespace EnumerationClassInsteadOfEnumType.EmployeeTypes
{
    public abstract class EmployeeTypeBase : Enumeration
    {
        public static readonly EmployeeTypeBase SeniorManager = new SeniorManager();
        public static readonly EmployeeTypeBase Manager = new Manager();
        public static readonly EmployeeTypeBase AssistantManager = new AssistantManager();
        public static readonly EmployeeTypeBase Contractor = new Contractor();

        protected EmployeeTypeBase() { }
        protected EmployeeTypeBase(int value, string displayName) : base(value, displayName) { }

        public abstract decimal BonusSize { get; }       
    }
}
