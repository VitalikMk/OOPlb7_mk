using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlb7_mk
{
    public class Repository<T>
    {
        private List<T> _items;

        public Repository()
        {
            _items = new List<T>();
        }

        public void Add(T item)
        {
            _items.Add(item);
        }

        public void Remove(T item)
        {
            _items.Remove(item);
        }

        public IList<T> Find(Criteria<T> criteria)
        {
            var results = new List<T>();

            foreach (var item in _items)
            {
                if (criteria(item))
                {
                    results.Add(item);
                }
            }

            return results;
        }
    }

    public delegate bool Criteria<T>(T item);


    public class Program
    {
        public static void Main(string[] args)
        {
            // Створюємо репозиторій для цілих чисел
            var repository = new Repository<int>();

            // Додаємо елементи до репозиторію
            repository.Add(1);
            repository.Add(2);
            repository.Add(3);

            // Визначаємо критерій для пошуку
            var criteria = (int item) => item % 2 == 0;

            // Знаходимо всі елементи, що задовольняють критерію
            var results = repository.Find(criteria);

            // Виводимо результати
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
    }

}
