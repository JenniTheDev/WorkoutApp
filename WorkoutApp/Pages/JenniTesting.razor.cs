using MudBlazor;

namespace WorkoutApp.Pages {

    public partial class JenniTesting
    {
        private void ItemUpdated(MudItemDropInfo<DropItem> dropItem)
        {
            dropItem.Item.Identifier = dropItem.DropzoneIdentifier;
        }

        private List<DropItem> _items = new()
        {
            new DropItem() { Name = "Jenni", Identifier = "Best" },
            new DropItem() { Name = "Vast", Identifier = "Super Bestest" },
            new DropItem() { Name = "Jacob", Identifier = "Best" },
            new DropItem() { Name = "Jason", Identifier = "Good" },
            new DropItem() { Name = "Mike", Identifier = "Good" },
        };

        public class DropItem
        {
            public string Name { get; init; }
            public string Identifier { get; set; }
        }
    }

}