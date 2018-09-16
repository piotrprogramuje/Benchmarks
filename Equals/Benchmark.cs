using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace Equals
{
    [CoreJob]
    [IterationsColumn, MaxColumn, MinColumn]
    public class Benchmark
    {
        private readonly StructureWithDefaultEquals _structureWithDefaultEquals1 = new StructureWithDefaultEquals();
        private readonly StructureWithDefaultEquals _structureWithDefaultEquals2 = new StructureWithDefaultEquals();
        private readonly StructureWithOverrideEquals _structureWithOverrideEquals1 = new StructureWithOverrideEquals();
        private readonly StructureWithOverrideEquals _structureWithOverrideEquals2 = new StructureWithOverrideEquals();
        private readonly StructureWithIEquatableInterface _structureWithIEquatableInterface1 = new StructureWithIEquatableInterface();
        private readonly StructureWithIEquatableInterface _structureWithIEquatableInterface2 = new StructureWithIEquatableInterface();
        private readonly ClassWithOverrideEquals _classWithOverrideEquals1 = new ClassWithOverrideEquals();
        private readonly ClassWithOverrideEquals _classWithOverrideEquals2 = new ClassWithOverrideEquals();
        private readonly ClassWithIEquatableInterface _classWithIEquatableInterface1 = new ClassWithIEquatableInterface();
        private readonly ClassWithIEquatableInterface _classWithIEquatableInterface2 = new ClassWithIEquatableInterface();
        private readonly object _anonymousType1 = new { ReferenceField = default(string), ValueField = default(int) };
        private readonly object _anonymousType2 = new { ReferenceField = default(string), ValueField = default(int) };
        private readonly (string, int) _valueTuple1 = (default(string), default(int));
        private readonly (string, int) _valueTuple2 = (default(string), default(int));
        private readonly Tuple<string, int> _tuple1 = Tuple.Create(default(string), default(int));
        private readonly Tuple<string, int> _tuple2 = Tuple.Create(default(string), default(int));
        private readonly EqualityComparer<StructureWithDefaultEquals> _defaultEqualityComparerOfStructureWithDefaultEquals = EqualityComparer<StructureWithDefaultEquals>.Default;
        private readonly EqualityComparer<StructureWithOverrideEquals> _defaultEqualityComparerOfStructureWithOverrideEquals = EqualityComparer<StructureWithOverrideEquals>.Default;
        private readonly EqualityComparer<StructureWithIEquatableInterface> _defaultEqualityComparerOfStructureWithIEquatableInterface = EqualityComparer<StructureWithIEquatableInterface>.Default;
        private readonly EqualityComparer<ClassWithOverrideEquals> _defaultEqualityComparerOfClassWithOverrideEquals = EqualityComparer<ClassWithOverrideEquals>.Default;
        private readonly EqualityComparer<ClassWithIEquatableInterface> _defaultEqualityComparerOfClassWithIEquatableInterface = EqualityComparer<ClassWithIEquatableInterface>.Default;
        private readonly EqualityComparer<Tuple<string, int>> _defaultEqualityComparerOfTuple = EqualityComparer<Tuple<string, int>>.Default;
        private readonly EqualityComparer<ValueTuple<string, int>> _defaultEqualityComparerOfValueTuple = EqualityComparer<ValueTuple<string, int>>.Default;

        [Benchmark]
        public bool CompareStructureWithDefaultEqualsByInstanceMethod()
        {
            return _structureWithDefaultEquals1.Equals(
                _structureWithDefaultEquals2);
        }

        [Benchmark]
        public bool CompareStructureWithOverrideEqualsByInstanceMethod()
        {
            return _structureWithOverrideEquals1.Equals(
                _structureWithOverrideEquals2);
        }

        [Benchmark]
        public bool CompareStructureWithIEquatableInterfaceByInstanceMethod()
        {
            return _structureWithIEquatableInterface1.Equals(
                _structureWithIEquatableInterface2);
        }

        [Benchmark]
        public bool CompareStructureWithDefaultEqualsByStaticMethod()
        {
            return Equals(
                _structureWithDefaultEquals1,
                _structureWithDefaultEquals2);
        }

        [Benchmark]
        public bool CompareStructureWithOverrideEqualsByStaticMethod()
        {
            return Equals(
                _structureWithOverrideEquals1,
                _structureWithOverrideEquals2);
        }

        [Benchmark]
        public bool CompareStructureWithIEquatableInterfaceByStaticMethod()
        {
            return Equals(
                _structureWithIEquatableInterface1,
                _structureWithIEquatableInterface2);
        }

        [Benchmark]
        public bool CompareStructureWithDefaultEqualsByDefaultEqualityComparer()
        {
            return _defaultEqualityComparerOfStructureWithDefaultEquals.Equals(
                _structureWithDefaultEquals1,
                _structureWithDefaultEquals2);
        }

        [Benchmark]
        public bool CompareStructureWithOverrideEqualsByDefaultEqualityComparer()
        {
            return _defaultEqualityComparerOfStructureWithOverrideEquals.Equals(
                _structureWithOverrideEquals1,
                _structureWithOverrideEquals2);
        }

        [Benchmark]
        public bool CompareStructureWithIEquatableInterfaceByDefaultEqualityComparer()
        {
            return _defaultEqualityComparerOfStructureWithIEquatableInterface.Equals(
                _structureWithIEquatableInterface1,
                _structureWithIEquatableInterface2);
        }

        [Benchmark]
        public bool CompareClassWithOverrideEqualsByInstanceMethod()
        {
            return _classWithOverrideEquals1.Equals(
                _classWithOverrideEquals2);
        }

        [Benchmark]
        public bool CompareClassWithIEquatableInterfaceByInstanceMethod()
        {
            return _classWithIEquatableInterface1.Equals(
                _classWithIEquatableInterface2);
        }

        [Benchmark]
        public bool CompareClassWithOverrideEqualsByStaticMethod()
        {
            return Equals(
                _classWithOverrideEquals1,
                _classWithOverrideEquals2);
        }

        [Benchmark]
        public bool CompareClassWithIEquatableInterfaceByStaticMethod()
        {
            return Equals(
                _classWithIEquatableInterface1,
                _classWithIEquatableInterface2);
        }

        [Benchmark]
        public bool CompareClassWithOverrideEqualsByDefaultEqualityComparer()
        {
            return _defaultEqualityComparerOfClassWithOverrideEquals.Equals(
                _classWithOverrideEquals1,
                _classWithOverrideEquals2);
        }

        [Benchmark]
        public bool CompareClassWithIEquatableInterfaceByDefaultEqualityComparer()
        {
            return _defaultEqualityComparerOfClassWithIEquatableInterface.Equals(
                _classWithIEquatableInterface1,
                _classWithIEquatableInterface2);
        }

        [Benchmark]
        public bool CompareAnonymousTypesByInstanceMethod()
        {
            return _anonymousType1.Equals(
                _anonymousType2);
        }

        [Benchmark]
        public bool CompareValueTuplesByInstanceMethod()
        {
            return _valueTuple1.Equals(
                _valueTuple2);
        }

        [Benchmark]
        public bool CompareTuplesByInstanceMethod()
        {
            return _tuple1.Equals(
                _tuple2);
        }

        [Benchmark]
        public bool CompareAnonymousTypesByStaticMethod()
        {
            return Equals(
                _anonymousType1,
                _anonymousType2);
        }

        [Benchmark]
        public bool CompareValueTuplesByStaticMethod()
        {
            return Equals(
                _valueTuple1,
                _valueTuple2);
        }

        [Benchmark]
        public bool CompareTuplesByStaticMethod()
        {
            return Equals(
                _tuple1,
                _tuple2);
        }

        [Benchmark]
        public bool CompareValueTuplesByDefaultEqualityComparer()
        {
            return _defaultEqualityComparerOfValueTuple.Equals(
                _valueTuple1,
                _valueTuple2);
        }

        [Benchmark]
        public bool CompareTuplesByDefaultEqualityComparer()
        {
            return _defaultEqualityComparerOfTuple.Equals(
                _tuple1,
                _tuple2);
        }
    }
}