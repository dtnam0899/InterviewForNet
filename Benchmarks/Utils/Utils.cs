using Benchmarks.Extensions;
using Benchmarks.Utils.Models;

namespace Benchmarks.Utils
{
    public class Utils
    {
        private static string[] names = { "James", "Cate", "Dave", "Allen", "Monica", "Amy", "John", "Mark", "Rose", "Mike" };

        public static IEnumerable<User> GenerateRandomUserList(int size)
        {
            Random random = new();
            List<User> list = new();

            while (size > 0)
            {
                int index = random.Next(names.Length);
                string randomName = names[index];

                int randomYears = random.Next(0, 10);

                list.Add(new User(randomName, randomName.ToEmail(), randomYears));

                size--;
            }
            return list;
        }

        public IEnumerable<User> GenerateUserList(int size)
        {
            List<User> list = new();

            while (size > 0)
            {
                foreach (string name in names)
                {
                    list.Add(new User(name, name.ToEmail()));
                    size--;
                    if (size == 0)
                        break;
                }
            }
            return list;
        }

        public IEnumerable<int> GenerateRandomNumbersList(int size)
        {
            return Enumerable.Range(1, size);
        }

        public static IEnumerable<string> GenerateRandomStringList(int size)
        {
            List<string> list = new();

            while (size > 0)
            {
                list.Add(Guid.NewGuid().ToString());
                size--;
            }
            return list;
        }

        /// <summary>
        /// Generates a list with half random values and another half with null values
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public IEnumerable<string> GenerateRandomStringListWithNull(int size)
        {
            List<string> list = new();

            while (size > 0)
            {
                if (size % 2 == 0)
                {
                    list.Add(Guid.NewGuid().ToString());
                }
                else
                {
                    list.Add(null);
                }
                size--;

            }
            return list;
        }
    }
}
