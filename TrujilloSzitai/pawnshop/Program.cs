using System;
using System.Linq;

namespace pawnshop
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Array conditionValues = Enum.GetValues(typeof(Condition));
            Array categoryValues = Enum.GetValues(typeof(Category));

            Business pawnshop = new Business("El precio de la historia", new Address("Ayacucho", "1431", "2244"));

            // items that I only use to add them and then delete them
            List<Item> myGenericItems = new List<Item>(){
                new Item("item1", 400.50, true, Condition.GOOD, Category.ANTIQUES),
                new Item("flamenco albino", 200.75, false, Condition.REGULAR, Category.VALUABLE),
                new Item("item3", 50, false, Condition.BADNESS, Category.JEWELRY),
                new Item("caja de zapatos", 1, true, Condition.REGULAR, Category.VALUABLE),
                new Item("item2", 50, false, Condition.BADNESS, Category.JEWELRY),
                new Item("item5", 50, false, Condition.BADNESS, Category.JEWELRY),
                new Item("item7", 50, false, Condition.BADNESS, Category.JEWELRY),
                new Item("item8", 50, false, Condition.BADNESS, Category.JEWELRY),
            };

            // certain items that I want to search
            List<Item> searchableItems = new List<Item>(){
                new Item("item1", 400.50, true, Condition.GOOD, Category.ANTIQUES),
                new Item("item6", 50, false, Condition.BADNESS, Category.JEWELRY),
                new Item("item2", 50, false, Condition.BADNESS, Category.JEWELRY),
                new Item("item4", 50, true, Condition.BADNESS, Category.JEWELRY),
                new Item("item7", 50, false, Condition.BADNESS, Category.JEWELRY),
                new Item("item9", 50, true, Condition.BADNESS, Category.JEWELRY),
            };

            Console.WriteLine("AGREGANDO OBJETOS...");

            // Creating random items
            for (int i = 1; i < 11; i++)
            {
                bool randomBoolean = r.Next(2) == 1;
                Condition itemCondition = (Condition)conditionValues.GetValue(r.Next(conditionValues.Length));
                Category itemCategory = (Category)categoryValues.GetValue(r.Next(categoryValues.Length));

                Item newItem = new Item($"item{i}", i * 5, randomBoolean, itemCondition, itemCategory);
                Console.WriteLine(tryAdd(newItem, pawnshop));
            }

            Console.WriteLine("AGREGANDO OBJETOS (OTRA VEZ)...");

            foreach (Item item in myGenericItems)
            {
                Console.WriteLine(tryAdd(item, pawnshop));
            }

            Console.WriteLine("ELIMINANDO OBJETOS...");
            foreach (Item item in myGenericItems)
            {
                Console.WriteLine(tryDelete(item, pawnshop));
            }

            Console.WriteLine("BUSCANDO OBJETOS...");
            foreach(Item item in searchableItems) {
                Console.WriteLine(trySearch(item, pawnshop));
            }
        }

        private static string tryAdd(Item item, Business business)
        {
            if (business.addItem(item))
            {
                return $"El objeto {item.Name} se ha agregado con éxito.";
            }
            else
            {
                return $"El objeto {item.Name} no se ha podido agregar.";
            }
        }

        private static string tryDelete(Item item, Business business)
        {
            if (business.deleteItem(item.Name))
            {
                return $"El objeto {item.Name} se ha eliminado con éxito.";
            }
            else
            {
                return $"El objeto {item.Name} no ha podido ser eliminado.";
            }
        }

        private static string trySearch(Item item, Business business)
        {
            if (business.searchItem(item.Name) != null)
            {
                return $"El objeto {item.Name} ha sido encontrado.";
            }
            else
            {
                return $"El objeto {item.Name} no ha podido ser encontrado.";
            }
        }
    }
}