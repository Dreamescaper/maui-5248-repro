using System.Linq;

namespace MauiRepro
{
    public class ReproModel
    {
        public ItemModel[] Items => Enumerable.Repeat(new[] { 1, 2, 3 }, 1000)
            .SelectMany(i => i)
            .Select(i => new ItemModel(i))
            .ToArray();
    }

    public class ItemModel
    {
        int i;

        public ItemModel(int i)
        {
            this.i = i;
        }

        public bool OneEnabled => i == 1;
        public bool TwoEnabled => i == 2;
        public bool ThreeEnabled => i == 3;
    }
}
