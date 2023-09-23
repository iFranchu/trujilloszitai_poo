using Microsoft.VisualBasic;

namespace pawnshop
{
    class Business
    {
        string name;
        Address address;
        List<Item> items = new List<Item>();

        public string Name => name;
        public Address Address => address;
        public List<Item> Items => items;

        public Business(string name, Address address)
        {
            this.name = name;
            this.address = address;
        }
        public Business(string name, Address address, List<Item> items)
        {
            this.name = name;
            this.address = address;
            this.items = items;
        }

        public bool addItem(Item item)
        {
            Item? selectItem = searchItem(item.Name);

            if (selectItem is null)
            {
                items.Add(item);
                return true;
            }

            return false;
        }

        public bool deleteItem(string itemName)
        {
            Item? selectItem = searchItem(itemName);

            if (selectItem is not null)
            {
                int index = items.IndexOf(selectItem);
                items.RemoveAt(index);
                return true;
            }

            return false;
        }

        public Item? searchItem(string itemName)
        {
            bool foundItem = false;
            int i = 0;
            Item? searchItem = null;
            Item item;

            // Condiciones para búsqueda son:
            // SI lo encontró -> foundItem
            // SI no llegó al final de la lista -> 
            while (!foundItem && i < items.Count)
            {
                 item = items[i];

                if (item.Name == itemName)
                {
                    foundItem = true;
                    searchItem = item;
                }
                i++;
            }

            return searchItem;

            // más basado ↓↓↓↓
            /* foreach (Item item in items)
            {
                if(item.Name == itemName) return item;
            }

            return null; */
        }
    }
}