using BenchmarkDotNet.Attributes;
using Benchmarks.Mapster.Dto;
using Benchmarks.Utils.Models;
using Mapster;

namespace Benchmarks.Mapster
{
    [RankColumn]
    [MemoryDiagnoser]
    [SimpleJob(iterationCount: 5)]
    public class MappingForList
    {
        private IEnumerable<User> _listIEnumerable;
        private List<User> _list;

        [Params(10, 100, 1000, 10000)]
        public int listSize;

        [GlobalSetup]
        public void Setup()
        {
            _listIEnumerable = Utils.Utils.GenerateRandomUserList(listSize);
            _list = _listIEnumerable.ToList();
        }


        [Benchmark]
        public void Apdapt()
        {
            List<UserDto> user = _list.Adapt<List<UserDto>>();
        }

        [Benchmark]
        public void ProjectToType()
        {
            List<UserDto> user = _list.AsQueryable().ProjectToType<UserDto>().ToList();
        }
    }
}
