// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
using System;
using System.Collections.Generic;

namespace PresentReceiveResponseData
{
    public class ItemCost
    {
        public int iId { get; set; }
        public string name { get; set; }
        public int num { get; set; }
    }

    public class LearnCost
    {
        public int crystalNum { get; set; }
        public int soul { get; set; }
        public List<ItemCost> itemCost { get; set; }
    }

    public class SkillTree
    {
        public int no { get; set; }
        public int learnStatus { get; set; }
        public int type { get; set; }
        public string typeName { get; set; }
        public int effectType { get; set; }
        public string effectTypeName { get; set; }
        public int baseVal { get; set; }
        public int posX { get; set; }
        public int posZ { get; set; }
        public int prevNo { get; set; }
        public LearnCost learnCost { get; set; }
    }

    public class Result
    {
        public List<SkillTree> skillTree { get; set; }
        public int skillCnt { get; set; }
    }

    public class RootObject
    {
        public int error { get; set; }
        public Result result { get; set; }
        public int tutorial { get; set; }
        public DateTime serverDate { get; set; }
    }
}
