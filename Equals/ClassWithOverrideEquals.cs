namespace Equals
{
    public sealed class ClassWithOverrideEquals
    {
        private readonly string _referenceField;
        private readonly int _valueField;

        public ClassWithOverrideEquals()
            : this(
                default(string),
                default(int))
        {
        }

        public ClassWithOverrideEquals(
            string referenceField,
            int valueField)
        {
            _referenceField = referenceField;
            _valueField = valueField;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj is ClassWithOverrideEquals instance && Equals(instance);
        }

        private bool Equals(ClassWithOverrideEquals other)
        {
            return string.Equals(_referenceField, other._referenceField) && _valueField == other._valueField;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((_referenceField != null ? _referenceField.GetHashCode() : 0) * 397) ^ _valueField;
            }
        }
    }
}