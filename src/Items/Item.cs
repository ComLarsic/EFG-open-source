namespace EvilFarmingGame.Items
{
    public class Item
    {
        public string Name { get { return Name;} set{} }
        public string Icon { get { return Name;} set{} }
        public string Discription { get { return Name;} set{} }
        public int ID { get { return ID;} set{} }
        
        public Item(string Name, string Icon, string Discription, int ID)
        {
            this.Name = Name;
            this.Icon = Icon;
            this.Discription = Discription;
            this.ID = ID;
        }
        
    }
}