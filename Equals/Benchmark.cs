using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace Equals
{
    public class Benchmark
    {
        [Benchmark]
        public bool CompareStructureWithDefaultEqualsByInstanceMethod()
        {
            return new StructureWithDefaultEquals().Equals(
                new StructureWithDefaultEquals());
        }

        [Benchmark]
        public bool CompareStructureWithOverrideEqualsByInstanceMethod()
        {
            return new StructureWithOverrideEquals().Equals(
                new StructureWithOverrideEquals());
        }

        [Benchmark]
        public bool CompareStructureWithIEquatableInterfaceByInstanceMethod()
        {
            return new StructureWithIEquatableInterface().Equals(
                new StructureWithIEquatableInterface());
        }

        [Benchmark]
        public bool CompareStructureWithDefaultEqualsByStaticMethod()
        {
            return Equals(
                new StructureWithDefaultEquals(),
                new StructureWithDefaultEquals());
        }

        [Benchmark]
        public bool CompareStructureWithOverrideEqualsByStaticMethod()
        {
            return Equals(
                new StructureWithOverrideEquals(),
                new StructureWithOverrideEquals());
        }

        [Benchmark]
        public bool CompareStructureWithIEquatableInterfaceByStaticMethod()
        {
            return Equals(
                new StructureWithIEquatableInterface(),
                new StructureWithIEquatableInterface());
        }

        [Benchmark]
        public bool CompareStructureWithDefaultEqualsByDefaultEqualityComparer()
        {
            return EqualityComparer<StructureWithDefaultEquals>.Default.Equals(
                new StructureWithDefaultEquals(),
                new StructureWithDefaultEquals());
        }

        [Benchmark]
        public bool CompareStructureWithOverrideEqualsByDefaultEqualityComparer()
        {
            return EqualityComparer<StructureWithOverrideEquals>.Default.Equals(
                new StructureWithOverrideEquals(),
                new StructureWithOverrideEquals());
        }

        [Benchmark]
        public bool CompareStructureWithIEquatableInterfaceByDefaultEqualityComparer()
        {
            return EqualityComparer<StructureWithIEquatableInterface>.Default.Equals(
                new StructureWithIEquatableInterface(),
                new StructureWithIEquatableInterface());
        }
    }
}