using BenchmarkDotNet.Running;
using Benchmarks.NullCheck;

namespace Benchmarks;
class Program
{
    static void Main(string[] args)
    {

        #region NullCheck
        //BenchmarkRunner.Run<NullCheckForString>();
        //BenchmarkRunner.Run<NullCheckForObject>();
        BenchmarkRunner.Run<NullOrEmptyCheckForList>();
        #endregion
    }
}