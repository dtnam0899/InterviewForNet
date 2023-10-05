using BenchmarkDotNet.Attributes;
using Benchmarks.Utils.Models;

namespace Benchmarks.NullCheck
{
    [RankColumn]
    [SimpleJob(iterationCount: 25)]
    public class NullCheckForObject
    {
        private User _user;

        [Benchmark]
        public void Equal_Operator()
        {
            _user = null;
            if (_user == null)
            {
                _user = new User();
            }
        }

        [Benchmark]
        public void Equals_Method()
        {
            _user = null;
            if (Equals(_user, null))
            {
                _user = new User();
            }
        }

        [Benchmark]
        public void ReferenceEquals_Method()
        {
            _user = null;
            if (ReferenceEquals(_user, null))
            {
                _user = new User();
            }
        }

        [Benchmark]
        public void Is_Operator()
        {
            _user = null;
            if (_user is null)
            {
                _user = new User();
            }
        }

        [Benchmark]
        public void Default_Operator()
        {
            _user = null;
            if (_user == default)
            {
                _user = new User();
            }
        }

        [Benchmark]
        public void Coalesce_Operator()
        {
            _user = null;
            _user = _user ?? new User();
        }

        [Benchmark]
        public void Ternary_Operator()
        {
            _user = null;
            _user = _user == null ? new User() : _user;
        }

        [Benchmark]
        public void Is_Operator_Braces()
        {
            _user = null;
            if (_user is not { })
            {
                _user = new User();
            }
        }
    }
}
