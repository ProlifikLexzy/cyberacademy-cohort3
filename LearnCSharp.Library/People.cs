using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Library
{
    public class People<T> : IEnumerable<T>
    {
        private readonly PeopleEnumerator<T>  peopleEnumerator;
        public People(T[] people)
        {
            peopleEnumerator = new PeopleEnumerator<T>(people);
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            return peopleEnumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class PeopleEnumerator<T> : IEnumerator<T>
    {
        private readonly T[] _people;

        public PeopleEnumerator(T[] people)
        {
            _people = people;
        }
        private int current = -1;
        public T Current => _people[current];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }

}
