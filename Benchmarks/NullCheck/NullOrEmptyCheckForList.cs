using BenchmarkDotNet.Attributes;

namespace Benchmarks.NullCheck
{
    [RankColumn]
    [SimpleJob(iterationCount: 25)]
    public class NullOrEmptyCheckForList
    {
        IEnumerable<string> listIEnumerable;
        List<string> list;

        [Params(0, 100, 1000)]
        public int listSize;

        [GlobalSetup]
        public void Setup()
        {
            listIEnumerable = Utils.Utils.GenerateRandomStringList(listSize);
            list = listIEnumerable.ToList();
        }

        [Benchmark]
        public bool Count_Property_List()
        {
            return list.Count == 0;
        }

        [Benchmark]
        public bool Count_Method_List()
        {
            return list.Count() == 0;
        }

        [Benchmark]
        public bool Linq_FirstOrDefault_List()
        {
            return list.FirstOrDefault() == null;
        }

        [Benchmark]
        public bool Linq_Any_List()
        {
            return list.Any();
        }

        [Benchmark]
        public bool Capacity_List()
        {
            return list.Capacity == 0;
        }

        [Benchmark]
        public bool Count_Method_IEnumerable()
        {
            return listIEnumerable.Count() == 0;
        }

        [Benchmark]
        public bool Linq_Any_IEnumerable()
        {
            return listIEnumerable.Any();
        }

        [Benchmark]
        public bool Linq_FirstOrDefault_IEnumerable()
        {
            return listIEnumerable.FirstOrDefault() == null;
        }
    }
}
