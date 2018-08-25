using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace Equals
{
    public class Benchmark
    {
        private StructureWithDefaultEquals _structureWithDefaultEquals1;
        private StructureWithDefaultEquals _structureWithDefaultEquals2;
        private StructureWithOverrideEquals _structureWithOverrideEquals1;
        private StructureWithOverrideEquals _structureWithOverrideEquals2;
        private StructureWithIEquatableInterface _structureWithIEquatableInterface1;
        private StructureWithIEquatableInterface _structureWithIEquatableInterface2;
        private ClassWithOverrideEquals _classWithOverrideEquals1;
        private ClassWithOverrideEquals _classWithOverrideEquals2;
        private ClassWithIEquatableInterface _classWithIEquatableInterface1;
        private ClassWithIEquatableInterface _classWithIEquatableInterface2;
        private object _anonymousType1;
        private object _anonymousType2;
        private (string, int) _valueTuple1;
        private (string, int) _valueTuple2;
        private Tuple<string, int> _tuple1;
        private Tuple<string, int> _tuple2;

        [GlobalSetup]
        public void GlobalSetup()
        {
            _structureWithDefaultEquals1 = new StructureWithDefaultEquals();
            _structureWithDefaultEquals2 = new StructureWithDefaultEquals();
            _structureWithOverrideEquals1 = new StructureWithOverrideEquals();
            _structureWithOverrideEquals2 = new StructureWithOverrideEquals();
            _structureWithIEquatableInterface1 = new StructureWithIEquatableInterface();
            _structureWithIEquatableInterface2 = new StructureWithIEquatableInterface();
            _classWithOverrideEquals1 = new ClassWithOverrideEquals();
            _classWithOverrideEquals2 = new ClassWithOverrideEquals();
            _classWithIEquatableInterface1 = new ClassWithIEquatableInterface();
            _classWithIEquatableInterface2 = new ClassWithIEquatableInterface();
            _anonymousType1 = new {ReferenceField = default(string), ValueField = default(int)};
            _anonymousType2 = new {ReferenceField = default(string), ValueField = default(int)};
            _valueTuple1 = (default(string), default(int));
            _valueTuple2 = (default(string), default(int));
            _tuple1 = Tuple.Create(default(string), default(int));
            _tuple2 = Tuple.Create(default(string), default(int));
        }

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
            return EqualityComparer<StructureWithDefaultEquals>.Default.Equals(
                _structureWithDefaultEquals1,
                _structureWithDefaultEquals2);
        }

        [Benchmark]
        public bool CompareStructureWithOverrideEqualsByDefaultEqualityComparer()
        {
            return EqualityComparer<StructureWithOverrideEquals>.Default.Equals(
                _structureWithOverrideEquals1,
                _structureWithOverrideEquals2);
        }

        [Benchmark]
        public bool CompareStructureWithIEquatableInterfaceByDefaultEqualityComparer()
        {
            return EqualityComparer<StructureWithIEquatableInterface>.Default.Equals(
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
            return EqualityComparer<ClassWithOverrideEquals>.Default.Equals(
                _classWithOverrideEquals1,
                _classWithOverrideEquals2);
        }

        [Benchmark]
        public bool CompareClassWithIEquatableInterfaceByDefaultEqualityComparer()
        {
            return EqualityComparer<ClassWithIEquatableInterface>.Default.Equals(
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
    }
}