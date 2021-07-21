// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 

namespace ExploreUpdateDeckReponseData
{
    public class DedicatedWeapon
    {
        public int hp { get; set; }
        public int sp { get; set; }
        public int atk { get; set; }
        public int def { get; set; }
        public int hit { get; set; }
    }

    public class LevelUpItem
    {
        public int type { get; set; }
        public int id { get; set; }
        public int num { get; set; }
    }

    public class AdvancedJobInfo
    {
        public int maxLevel { get; set; }
        public int level { get; set; }
        public int styleLevel { get; set; }
        public List<LevelUpItem> levelUpItems { get; set; }
    }

    public class AttackUpgradeData
    {
        public int atkId { get; set; }
        public int order { get; set; }
        public int val1 { get; set; }
        public int val2 { get; set; }
        public int element1 { get; set; }
        public int element2 { get; set; }
    }

    public class ActionSkillUpgradeData
    {
        public int rootSkillId { get; set; }
        public int skillId { get; set; }
        public int level { get; set; }
        public int maxLevel { get; set; }
        public double val1 { get; set; }
        public double val2 { get; set; }
        public double element1 { get; set; }
        public double element2 { get; set; }
        public List<AttackUpgradeData> attackUpgradeData { get; set; }
    }

    public class ChangeCardInfo
    {
        public int cardId { get; set; }
        public int modelId { get; set; }
        public int elementType { get; set; }
        public int weaponClass { get; set; }
        public int weaponSubId { get; set; }
        public int motionType { get; set; }
        public int motionSubType { get; set; }
        public int rarity { get; set; }
        public int enemyChara { get; set; }
        public int isLocked { get; set; }
        public string illustratorStand { get; set; }
        public string illustratorAwake { get; set; }
        public string bgType { get; set; }
        public string frameType { get; set; }
        public AdvancedJobInfo advancedJobInfo { get; set; }
    }

    public class ExPassiveSkill
    {
        public int id { get; set; }
        public int category { get; set; }
        public int subcategory { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public int type { get; set; }
        public List<int> Nums { get; set; }
        public List<int> nums { get; set; }
        public string addInfo1 { get; set; }
        public int dType { get; set; }
        public int target { get; set; }
        public int advancedJobLevel { get; set; }
        public int activeCardLevel { get; set; }
    }

    public class HighLevelGloveActionSkill
    {
        public int consumeGauge { get; set; }
    }

    public class HighLevelWarriorActionSkill
    {
        public int gaugeDivisionNumber { get; set; }
    }

    public class Card
    {
        public int uId { get; set; }
        public string ucId { get; set; }
        public int cId { get; set; }
        public string preName { get; set; }
        public string name { get; set; }
        public int rar { get; set; }
        public int lv { get; set; }
        public int exceedCnt { get; set; }
        public int exceedCostType { get; set; }
        public int exceedMaxCnt { get; set; }
        public int heroFlag { get; set; }
        public int hp { get; set; }
        public int sp { get; set; }
        public int atk { get; set; }
        public int def { get; set; }
        public int hit { get; set; }
        public int agi { get; set; }
        public int addHp { get; set; }
        public int addSp { get; set; }
        public int addAtk { get; set; }
        public int addDef { get; set; }
        public int addHit { get; set; }
        public int addAgi { get; set; }
        public int flameBlock { get; set; }
        public int slowBlock { get; set; }
        public int shockBlock { get; set; }
        public int darkBlock { get; set; }
        public int freezeBlock { get; set; }
        public int poisonBlock { get; set; }
        public int sleepBlock { get; set; }
        public int loveMax { get; set; }
        public int love { get; set; }
        public int loveLevel { get; set; }
        public int loveMaxLevel { get; set; }
        public int lovePrev { get; set; }
        public int loveNext { get; set; }
        public int addLove { get; set; }
        public int greetFlag { get; set; }
        public int evolveStep { get; set; }
        public int cost { get; set; }
        public int comboLevel { get; set; }
        public int comboNum { get; set; }
        public int asId1 { get; set; }
        public int asId2 { get; set; }
        public int asExtId1 { get; set; }
        public int asExtId2 { get; set; }
        public int lsId { get; set; }
        public int weaponId { get; set; }
        public int weaponClass { get; set; }
        public int weaponSubId { get; set; }
        public int motionType { get; set; }
        public int motionSubType { get; set; }
        public int excludeFlag { get; set; }
        public int prevCardId { get; set; }
        public DedicatedWeapon dedicatedWeapon { get; set; }
        public int nextCardId { get; set; }
        public int tribeType1 { get; set; }
        public string tribeName1 { get; set; }
        public int tribeType2 { get; set; }
        public string tribeName2 { get; set; }
        public int eventType { get; set; }
        public int personalityId { get; set; }
        public int styleId { get; set; }
        public int elementType { get; set; }
        public int elementAtk { get; set; }
        public int invalidLoveFlg { get; set; }
        public int fiendEvolveDirectionType { get; set; }
        public int eventStepActionType { get; set; }
        public int withoutMemories { get; set; }
        public int startBurstGaugeRate { get; set; }
        public int noExistEventTalk { get; set; }
        public int enemyChara { get; set; }
        public bool favorite { get; set; }
        public bool canReceiveLoveReward { get; set; }
        public int invalidProfileAvator { get; set; }
        public string invalidProfileReason { get; set; }
        public int modelId { get; set; }
        public string talkEventName { get; set; }
        public string lsName { get; set; }
        public string lsDesc { get; set; }
        public int lsType { get; set; }
        public int lsNum1 { get; set; }
        public int lsNum2 { get; set; }
        public int lsNum3 { get; set; }
        public int lsNum4 { get; set; }
        public int lsWType { get; set; }
        public int lsTType { get; set; }
        public int lsEffect { get; set; }
        public int eventStep { get; set; }
        public string talkEventName0 { get; set; }
        public int talkEventName0Status { get; set; }
        public string talkEventName1 { get; set; }
        public int talkEventName1Status { get; set; }
        public string talkEventName2 { get; set; }
        public int talkEventName2Status { get; set; }
        public string talkEventName3 { get; set; }
        public int talkEventName3Status { get; set; }
        public string talkEventName4 { get; set; }
        public int talkEventName4Status { get; set; }
        public string talkEventName5 { get; set; }
        public int talkEventName5Status { get; set; }
        public int accessoryMaxNum { get; set; }
        public int levelCap { get; set; }
        public AdvancedJobInfo advancedJobInfo { get; set; }
        public int ps1Id { get; set; }
        public string ps1Name { get; set; }
        public string ps1Desc { get; set; }
        public int ps1Category { get; set; }
        public int ps1Subcategory { get; set; }
        public int ps1Type { get; set; }
        public int ps1DType { get; set; }
        public int ps1Num1 { get; set; }
        public int ps1Num2 { get; set; }
        public int ps1Num3 { get; set; }
        public int ps1Num4 { get; set; }
        public int ps1Num5 { get; set; }
        public int ps1Num6 { get; set; }
        public int ps1AdvancedJobLevel { get; set; }
        public int ps1ActiveCardLevel { get; set; }
        public int ps2Id { get; set; }
        public string ps2Name { get; set; }
        public string ps2Desc { get; set; }
        public int ps2Category { get; set; }
        public int ps2Subcategory { get; set; }
        public int ps2Type { get; set; }
        public int ps2DType { get; set; }
        public int ps2Num1 { get; set; }
        public int ps2Num2 { get; set; }
        public int ps2Num3 { get; set; }
        public int ps2Num4 { get; set; }
        public int ps2Num5 { get; set; }
        public int ps2Num6 { get; set; }
        public int ps2AdvancedJobLevel { get; set; }
        public int ps2ActiveCardLevel { get; set; }
        public int ps3Id { get; set; }
        public string asName1 { get; set; }
        public string asName2 { get; set; }
        public int hasCharismaSkill { get; set; }
        public int paramUpChara { get; set; }
        public List<ActionSkillUpgradeData> actionSkillUpgradeData { get; set; }
        public int skillUpgradeStatus { get; set; }
        public string fSlot1 { get; set; }
        public int isInExplore { get; set; }
        public int isInExploreDeck { get; set; }
        public string talkEventName6 { get; set; }
        public int? talkEventName6Status { get; set; }
        public string talkEventName7 { get; set; }
        public int? talkEventName7Status { get; set; }
        public string ps3Name { get; set; }
        public string ps3Desc { get; set; }
        public int? ps3Category { get; set; }
        public int? ps3Subcategory { get; set; }
        public int? ps3Type { get; set; }
        public int? ps3DType { get; set; }
        public int? ps3Num1 { get; set; }
        public int? ps3Num2 { get; set; }
        public int? ps3Num3 { get; set; }
        public int? ps3Num4 { get; set; }
        public int? ps3Num5 { get; set; }
        public int? ps3Num6 { get; set; }
        public int? ps3AdvancedJobLevel { get; set; }
        public int? ps3ActiveCardLevel { get; set; }
        public int? thunderBlock { get; set; }
        public int? waterBlock { get; set; }
        public List<ChangeCardInfo> changeCardInfo { get; set; }
        public int? lsElementType { get; set; }
        public int? fireBlock { get; set; }
        public int? lightBlock { get; set; }
        public int? skillBanBlock { get; set; }
        public string asExtName1 { get; set; }
        public string spoilerAlert { get; set; }
        public string asExtName2 { get; set; }
        public string fSlot2 { get; set; }
        public string fSlot3 { get; set; }
        public string fSlot4 { get; set; }
        public string ps1AddInfo1 { get; set; }
        public List<ExPassiveSkill> exPassiveSkills { get; set; }
        public int? ps2Target { get; set; }
        public HighLevelGloveActionSkill highLevelGloveActionSkill { get; set; }
        public int? lsEventType { get; set; }
        public int? voiceType { get; set; }
        public HighLevelWarriorActionSkill highLevelWarriorActionSkill { get; set; }
    }

    public class Unit
    {
        public string ueId { get; set; }
        public string ucId { get; set; }
        public string uwId { get; set; }
        public int odrNo { get; set; }
        public string uaId { get; set; }
        public string uaId2 { get; set; }
        public string uaId3 { get; set; }
        public string uaId4 { get; set; }
        public string uaId5 { get; set; }
    }

    public class Deck
    {
        public List<Unit> units { get; set; }
    }

    public class UserExplore
    {
        public int deckNo { get; set; }
        public int exploreId { get; set; }
        public int explorePoint { get; set; }
        public string endDate { get; set; }
        public string restTime { get; set; }
        public string leftTime { get; set; }
        public string spendTime { get; set; }
        public int status { get; set; }
        public Deck deck { get; set; }
    }

    public class Result
    {
        public List<Card> cards { get; set; }
        public List<UserExplore> userExplores { get; set; }
    }

    public class RootObject
    {
        public int error { get; set; }
        public Result result { get; set; }
        public int tutorial { get; set; }
        public DateTime serverDate { get; set; }
    }
}
