﻿namespace Equals
{
    public struct StructureWithOverrideEquals
    {
        private readonly string _referenceField;
        private readonly int _valueField;

        public StructureWithOverrideEquals(
            string referenceField,
            int valueField)
        {
            _referenceField = referenceField;
            _valueField = valueField;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is StructureWithOverrideEquals instance && Equals(instance);
        }

        private bool Equals(StructureWithOverrideEquals other)
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