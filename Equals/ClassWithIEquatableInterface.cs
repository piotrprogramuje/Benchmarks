using System;

namespace Equals
{
    public sealed class ClassWithIEquatableInterface : IEquatable<ClassWithIEquatableInterface>
    {
        private readonly string _referenceField;
        private readonly int _valueField;

        public ClassWithIEquatableInterface()
        :this(
            default(string),
            default(int))
        {
        }

        public ClassWithIEquatableInterface(
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
            return obj is ClassWithIEquatableInterface instance && Equals(instance);
        }

        public bool Equals(ClassWithIEquatableInterface other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
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