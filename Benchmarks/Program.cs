using BenchmarkDotNet.Running;
using Benchmarks.Mapster;

namespace Benchmarks;

internal class Program
{
    private static void Main(string[] args)
    {

        #region NullCheck
        //BenchmarkRunner.Run<NullCheckForString>();
        //BenchmarkRunner.Run<NullCheckForObject>();
        //BenchmarkRunner.Run<NullOrEmptyCheckForList>();
        #endregion

        #region Mapster
        BenchmarkRunner.Run<MappingForList>();
        #endregion
    }
}