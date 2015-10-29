using System.Collections;

namespace Yield
{
    class Enumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return "Element";
        }
    }
}
