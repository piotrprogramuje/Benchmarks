namespace Equals
{
    public struct StructureWithDefaultEquals
    {
        private readonly string _referenceField;
        private readonly int _valueField;

        public StructureWithDefaultEquals(
            string referenceField,
            int valueField)
        {
            _referenceField = referenceField;
            _valueField = valueField;
        }
    }
}