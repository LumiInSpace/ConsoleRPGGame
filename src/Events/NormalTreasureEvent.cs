using ConsoleRPGGame.src.Main.Chests;
using System.Dynamic;
using System.Xml.Serialization;

namespace ConsoleRPGGame.src.Events
{
    public class NormalTreasureEvent : AbtractEventBase
    {
        public Biome Biome { get; set; }
        public bool IsTrap { get; set; }
        public bool IsLocked { get; set; }
        public string EntryText { get; set; }
        public string LeaveText1 { get; set; }
        public string ChestText { get; set; }


        public NormalTreasureEvent(string name, string description, EventTyp eventTyp, Rarity rarity, Biome biome, string entryText, string leaveText1, string chestText) : base(name, description, eventTyp)
        {
            Biome = biome;

            Random random = new Random();
            if (random.Next(0, 5) == 0) { IsTrap = true; }
            if (random.Next(0, 2) == 0) { IsLocked = true; }

            EntryText = entryText;
            LeaveText1 = leaveText1;
            ChestText = chestText;
        }

        public override void Execute(Character player, List<Item> allItems)
        {
            Console.WriteLine(Description);
            Console.WriteLine();

            Console.WriteLine("[1] Betreten");
            Console.WriteLine("[2] Weitergegehen");
            Console.Write("[#]: ");
            var pos1 = Console.CursorLeft;

            var choice1 = Console.ReadLine();

            if (choice1 == "1")
            {
                Console.WriteLine(EntryText);
                GetIn(player, allItems);
            }
            else if (choice1 == "2")
            {
                Console.Write(LeaveText1);
            }
            else
            {
                Console.CursorLeft = pos1;
                Console.Write("                                                                        ");
                Console.CursorLeft = pos1;
            }


        }

        private void GetIn(Character player, List<Item> allItems) 
        {
            Console.WriteLine(ChestText);
            Console.WriteLine();

            if (IsLocked)
            {
                Console.WriteLine("Du näherst dich der Truhe und merkst das diese verschloßen ist.");
                Console.WriteLine("Was tust du?");
                Console.WriteLine();
                while (true)
                {
                    Console.WriteLine("[1] Truhenschlüssel nutzen");
                    Console.WriteLine("[2] Verlassen");
                    string choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        Item Truhenschlüssel = player.Inventory.PlayerInventory.FirstOrDefault(x => x.Name == "Truhenschlüssel");
                        if (Truhenschlüssel != null)
                        {
                            Console.WriteLine("Du hast keinen Truhenschlüssel in deinem Inventar!");
                        }
                        else
                        {
                            player.Inventory.RemoveItem(Truhenschlüssel);
                            //Console.WriteLine($"Du hast 1 {Truhenschlüssel.Name} benutzt!");

                            if (IsTrap)
                            {
                                GetTrap(player);
                            }
                            else
                            {
                                Chest chest = GetChest();
                                List<Item> loot = LootRandomizer.GetLoot(chest, allItems, 3);
                                Gui.ShowTakeLootScreen(loot, player);
                            }
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }

        }

        private void GetTrap(Character player)
        {

        }

        private Chest GetChest()
        {
            Random random = new Random();

            Rarity chestRarity = LootRandomizer.GetRandomRarity(new Dictionary<Rarity, float>
                                {
                                    { Rarity.Common, 47f },
                                    { Rarity.Uncommon, 33f },
                                    { Rarity.Rare, 20f }
                                });


            return (chestRarity) switch
            {
                Rarity.Common => new CommonChest(),
                Rarity.Uncommon => new UncommonChest(),
                Rarity.Rare => new RareChest(),
            };
        }
    }
}
