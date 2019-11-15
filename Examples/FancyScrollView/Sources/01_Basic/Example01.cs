using System.Linq;
using UnityEngine;

namespace UnityEngine.UI.Extensions.Examples.FancyScrollViewExample01
{
    public class Example01 : MonoBehaviour
    {
        [SerializeField] ScrollView scrollView = default;

        void Start()
        {
            var items = Enumerable.Range(0, 20)
                .Select(i => new ItemData($"Cell {i}"))
                .ToArray();

            scrollView.UpdateData(items);
        }
    }
}
