using BenchmarkDotNet.Attributes;

namespace Benchmarks.NullCheck
{
    [RankColumn]
    [SimpleJob(iterationCount: 25)]
    public class NullCheckForString
    {
        private string message;
        private string value = "value is null";

        [Benchmark]
        public void Equal_Operator()
        {
            message = null;
            if (message == null)
            {
                message = value;
            }
        }

        [Benchmark]
        public void Equals_Method()
        {
            message = null;
            if (string.Equals(message, null))
            {
                message = value;
            }
        }

        [Benchmark]
        public void ReferenceEquals_Method()
        {
            message = null;
            if (ReferenceEquals(null, message))
            {
                message = value;
            }
        }

        [Benchmark]
        public void Is_Operator()
        {
            message = null;
            if (message is null)
            {
                message = value;
            }
        }

        [Benchmark]
        public void NullOrEmpty_Method()
        {
            message = null;
            if (string.IsNullOrEmpty(message))
            {
                message = value;
            }
        }

        [Benchmark]
        public void Default_Operator()
        {
            message = null;
            if (message == default)
            {
                message = value;
            }
        }

        [Benchmark]
        public void Coalesce_Operator()
        {
            message = null;
            message = message ?? value;
        }

        [Benchmark]
        public void Ternary_Operator()
        {
            message = null;
            message = message == null ? value : message;
        }

        [Benchmark]
        public void Is_Operator_Braces()
        {
            message = null;
            if (message is not { })
            {
                message = value;
            }
        }
    }
}
