namespace RefitApplication
{

    public class DogBreedResponse
    {
        public string id { get; set; }
        public string type { get; set; }
        public Attributes attributes { get; set; }
        public Relationships relationships { get; set; }
    }

    public class Attributes
    {
        public string name { get; set; }
        public string description { get; set; }
        public Life life { get; set; }
        public Male_Weight male_weight { get; set; }
        public Female_Weight female_weight { get; set; }
        public bool hypoallergenic { get; set; }
    }

    public class Life
    {
        public int max { get; set; }
        public int min { get; set; }
    }

    public class Male_Weight
    {
        public int max { get; set; }
        public int min { get; set; }
    }

    public class Female_Weight
    {
        public int max { get; set; }
        public int min { get; set; }
    }

    public class Relationships
    {
        public Group group { get; set; }
    }

    public class Group
    {
        public Data data { get; set; }
    }

    public class Data
    {
        public string id { get; set; }
        public string type { get; set; }
    }

}
