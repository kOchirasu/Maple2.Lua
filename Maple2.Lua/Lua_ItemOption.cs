using LuaGenerator;

namespace Maple2.Lua;

public partial class Lua {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="a0">unknown, sometimes used as multiplier</param>
    /// <param name="slot">valid values {1, 2}</param>
    /// <param name="itemType">one of {BLUNT=30, DAGGER=31, LONGSWORD=32, SCEPTRE=33, JAVELIN=34, LARGESWORD=50, BOW=51, STAFF=52, HEAVYGUN=53, RUNEBLADE=54, KNUCKLE=55, ORB=56}</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="a4">unknown, but important</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    [GlobalFunction(Name = "constant_value_addwap")]
    public partial float ConstantValueAddWap(int a0, int slot, int itemType, int jobCode, int a4, int grade, ushort levelLimit, int a7);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a0">unknown, sometimes used as multiplier</param>
    /// <param name="slot">1=main-hand, 2=off-hand</param>
    /// <param name="itemType">one of {BLUNT=30, DAGGER=31, LONGSWORD=32, SCEPTRE=33, JAVELIN=34, LARGESWORD=50, BOW=51, STAFF=52, HEAVYGUN=53, RUNEBLADE=54, KNUCKLE=55, ORB=56}</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="a4">unknown, but important</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    [GlobalFunction(Name = "constant_value_wapmin")]
    public partial float ConstantValueWapMin(int a0, int slot, int itemType, int jobCode, int a4, int grade, ushort levelLimit, int a7);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a0">unknown, sometimes used as multiplier</param>
    /// <param name="slot">1=main-hand, 2=off-hand</param>
    /// <param name="itemType">one of {BLUNT=30, DAGGER=31, LONGSWORD=32, SCEPTRE=33, JAVELIN=34, LARGESWORD=50, BOW=51, STAFF=52, HEAVYGUN=53, RUNEBLADE=54, KNUCKLE=55, ORB=56}</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="a4">unknown, but important</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    [GlobalFunction(Name = "constant_value_wapmax")]
    public partial float ConstantValueWapMax(int a0, int slot, int itemType, int jobCode, int a4, int grade, ushort levelLimit, int a7);
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="a0">unknown, sometimes used as multiplier</param>
    /// <param name="slot">1=main-hand, 2=off-hand</param>
    /// <param name="itemType">one of {EARRING=12, CAP=13, CLOTH=14, PANTS=15, GLOVES=16, SHOES=17, MENTLE=18, PANDANT=19, RI=20, BELT=21, ONEPIECE=22, SHIELD=41}</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="a4">unknown, but important</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    [GlobalFunction(Name = "constant_value_addndd")]
    public partial float ConstantValueAddNdd(int a0, int slot, int itemType, int jobCode, int a4, int grade, ushort levelLimit, int a7);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a0">unknown, sometimes used as multiplier</param>
    /// <param name="slot">1=main-hand, 2=off-hand</param>
    /// <param name="itemType">one of {EARRING=12, CAP=13, CLOTH=14, PANTS=15, GLOVES=16, SHOES=17, MENTLE=18, PANDANT=19, RI=20, BELT=21, ONEPIECE=22, SHIELD=41}</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="a4">unknown, but important</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    [GlobalFunction(Name = "constant_value_ndd")]
    public partial float ConstantValueNdd(int a0, int slot, int itemType, int jobCode, int a4, int grade, ushort levelLimit, int a7);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a0">unknown, sometimes used as multiplier</param>
    /// <param name="slot">1=main-hand, 2=off-hand</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="a4">unknown, but important</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    [GlobalFunction(Name = "constant_value_mar")]
    public partial float ConstantValueMar(int a0, int slot, int itemType, int jobCode, int a4, int grade, ushort levelLimit, int a7);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a0">unknown, sometimes used as multiplier</param>
    /// <param name="slot">1=main-hand, 2=off-hand</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="a4">unknown, but important</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    [GlobalFunction(Name = "constant_value_par")]
    public partial float ConstantValuePar(int a0, int slot, int itemType, int jobCode, int a4, int grade, ushort levelLimit, int a7);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a0">unknown, sometimes used as multiplier</param>
    /// <param name="slot">1=main-hand, 2=off-hand</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="a4">unknown, but important</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    [GlobalFunction(Name = "constant_value_hp")]
    public partial float ConstantValueHp(int a0, int slot, int itemType, int jobCode, int a4, int grade, ushort levelLimit, int a7);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a0">unknown, sometimes used as multiplier</param>
    /// <param name="slot">1=main-hand, 2=off-hand</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="a4">unknown, but important</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    [GlobalFunction(Name = "constant_value_map")]
    public partial float ConstantValueMap(int a0, int slot, int itemType, int jobCode, int a4, int grade, ushort levelLimit, int a7);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a0">unknown, sometimes used as multiplier</param>
    /// <param name="slot">1=main-hand, 2=off-hand</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="a4">unknown, but important</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    [GlobalFunction(Name = "constant_value_cap")]
    public partial float ConstantValueCap(int a0, int slot, int itemType, int jobCode, int a4, int grade, ushort levelLimit, int a7);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a0">unknown, sometimes used as multiplier</param>
    /// <param name="slot">1=main-hand, 2=off-hand</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="a4">unknown, but important</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    [GlobalFunction(Name = "constant_value_str")]
    public partial float ConstantValueStr(int a0, int slot, int itemType, int jobCode, int a4, int grade, ushort levelLimit, int a7);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a0">unknown, sometimes used as multiplier</param>
    /// <param name="slot">1=main-hand, 2=off-hand</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="a4">unknown, but important</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">not sure but it can affect output when == 1</param>
    [GlobalFunction(Name = "constant_value_int")]
    public partial float ConstantValueInt(int a0, int slot, int itemType, int jobCode, int a4, int grade, ushort levelLimit, int a7);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a0">unknown, sometimes used as multiplier</param>
    /// <param name="slot">1=main-hand, 2=off-hand</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="a4">unknown, but important</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    [GlobalFunction(Name = "constant_value_dex")]
    public partial float ConstantValueDex(int a0, int slot, int itemType, int jobCode, int a4, int grade, ushort levelLimit, int a7);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a0">unknown, sometimes used as multiplier</param>
    /// <param name="slot">1=main-hand, 2=off-hand</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="a4">unknown, but important</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    [GlobalFunction(Name = "constant_value_luk")]
    public partial float ConstantValueLuk(int a0, int slot, int itemType, int jobCode, int a4, int grade, ushort levelLimit, int a7);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a0">unknown, sometimes used as multiplier</param>
    /// <param name="slot">1=main-hand, 2=off-hand</param>
    /// <param name="itemType">one of {BLUNT=30, DAGGER=31, LONGSWORD=32, SCEPTRE=33, JAVELIN=34, LARGESWORD=50, BOW=51, STAFF=52, HEAVYGUN=53, RUNEBLADE=54, KNUCKLE=55, ORB=56}</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="a4">unknown, but important</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    [GlobalFunction(Name = "static_value_addwap")]
    public partial float StaticValueAddWap(int a0, int slot, int itemType, int jobCode, int a4, int grade, ushort levelLimit, int a7);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a0">unknown, sometimes used as multiplier</param>
    /// <param name="slot">1=main-hand, 2=off-hand</param>
    /// <param name="itemType">one of {BLUNT=30, DAGGER=31, LONGSWORD=32, SCEPTRE=33, JAVELIN=34, LARGESWORD=50, BOW=51, STAFF=52, HEAVYGUN=53, RUNEBLADE=54, KNUCKLE=55, ORB=56}</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="a4">unknown, but important</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    [GlobalFunction(Name = "static_value_wapmax")]
    public partial float StaticValueWapMax(int a0, int slot, int itemType, int jobCode, int a4, int grade, ushort levelLimit, int a7);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a0">unknown, sometimes used as multiplier</param>
    /// <param name="slot">1=main-hand, 2=off-hand</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="a4">unknown, but important</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    [GlobalFunction(Name = "static_value_pap")]
    public partial float StaticValuePap(int a0, int slot, int itemType, int jobCode, int a4, int grade, ushort levelLimit, int a7);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a0">unknown, sometimes used as multiplier</param>
    /// <param name="slot">1=main-hand, 2=off-hand</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="a4">unknown, but important</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    [GlobalFunction(Name = "static_value_map")]
    public partial float StaticValueMap(int a0, int slot, int itemType, int jobCode, int a4, int grade, ushort levelLimit, int a7);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a0">unknown, sometimes used as multiplier</param>
    /// <param name="slot">1=main-hand, 2=off-hand</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="a4">unknown, but important</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    [GlobalFunction(Name = "static_value_addndd")]
    public partial float StaticValueAddNdd(int a0, int slot, int itemType, int jobCode, int a4, int grade, ushort levelLimit, int a7);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a0">unknown, sometimes used as multiplier</param>
    /// <param name="slot">1=main-hand, 2=off-hand</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="a4">unknown, but important</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    [GlobalFunction(Name = "static_value_ndd")]
    public partial float StaticValueNdd(int a0, int slot, int itemType, int jobCode, int a4, int grade, ushort levelLimit, int a7);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a0">unknown, sometimes used as multiplier</param>
    /// <param name="slot">1=main-hand, 2=off-hand</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="a4">unknown, but important</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    [GlobalFunction(Name = "static_value_hp")]
    public partial float StaticValueHp(int a0, int slot, int itemType, int jobCode, int a4, int grade, ushort levelLimit, int a7);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a0">unknown, sometimes used as multiplier</param>
    /// <param name="slot">1=main-hand, 2=off-hand</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="a4">unknown, but important</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    [GlobalFunction(Name = "static_value_mar")]
    public partial float StaticValueMar(int a0, int slot, int itemType, int jobCode, int a4, int grade, ushort levelLimit, int a7);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a0">unknown, sometimes used as multiplier</param>
    /// <param name="slot">1=main-hand, 2=off-hand</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="a4">unknown, but important</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    [GlobalFunction(Name = "static_value_par")]
    public partial float StaticValuePar(int a0, int slot, int itemType, int jobCode, int a4, int grade, ushort levelLimit, int a7);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a0">unknown, sometimes used as multiplier</param>
    /// <param name="slot">1=main-hand, 2=off-hand</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="a4">unknown, but important</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    [GlobalFunction(Name = "static_rate_abp")]
    public partial float StaticRateAbp(int a0, int slot, int itemType, int jobCode, int a4, int grade, ushort levelLimit, int a7);
}
