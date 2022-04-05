using LuaGenerator;

namespace Maple2.Lua;

public partial class Lua {
    /// <param name="baseValue">base value from /itemoption/constant/itemoptionconstant_*.xml</param>
    /// <param name="deviation">defined in /table/itemoptionpick.xml {1, 2}</param>
    /// <param name="itemType">one of {BLUNT=30, DAGGER=31, LONGSWORD=32, SCEPTRE=33, JAVELIN=34, LARGESWORD=50, BOW=51, STAFF=52, HEAVYGUN=53, RUNEBLADE=54, KNUCKLE=55, ORB=56}</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="optionLevelFactor">option level factor from item_id.xml</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    /// <returns>constant value add weapon attack power</returns>
    [GlobalFunction(Name = "constant_value_addwap")]
    public partial float ConstantValueAddWap(int baseValue, int deviation, int itemType, int jobCode, int optionLevelFactor, int grade, ushort levelLimit, int a7 = 0);

    /// <param name="baseValue">base value from /itemoption/constant/itemoptionconstant_*.xml</param>
    /// <param name="deviation">defined in /table/itemoptionpick.xml {1, 2}</param>
    /// <param name="itemType">one of {BLUNT=30, DAGGER=31, LONGSWORD=32, SCEPTRE=33, JAVELIN=34, LARGESWORD=50, BOW=51, STAFF=52, HEAVYGUN=53, RUNEBLADE=54, KNUCKLE=55, ORB=56}</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="optionLevelFactor">option level factor from item_id.xml</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    /// <returns>(min, max) constant value weapon attack power min</returns>
    [GlobalFunction(Name = "constant_value_wapmin")]
    public partial (float, float) ConstantValueWapMin(int baseValue, int deviation, int itemType, int jobCode, int optionLevelFactor, int grade, ushort levelLimit, int a7 = 0);

    /// <param name="baseValue">base value from /itemoption/constant/itemoptionconstant_*.xml</param>
    /// <param name="deviation">defined in /table/itemoptionpick.xml {1, 2}</param>
    /// <param name="itemType">one of {BLUNT=30, DAGGER=31, LONGSWORD=32, SCEPTRE=33, JAVELIN=34, LARGESWORD=50, BOW=51, STAFF=52, HEAVYGUN=53, RUNEBLADE=54, KNUCKLE=55, ORB=56}</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="optionLevelFactor">option level factor from item_id.xml</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    /// <returns>(min, max) constant value weapon attack power max</returns>
    [GlobalFunction(Name = "constant_value_wapmax")]
    public partial (float, float) ConstantValueWapMax(int baseValue, int deviation, int itemType, int jobCode, int optionLevelFactor, int grade, ushort levelLimit, int a7 = 0);
    
    /// <param name="baseValue">base value from /itemoption/constant/itemoptionconstant_*.xml</param>
    /// <param name="deviation">defined in /table/itemoptionpick.xml {1, 2}</param>
    /// <param name="itemType">one of {EARRING=12, CAP=13, CLOTH=14, PANTS=15, GLOVES=16, SHOES=17, MENTLE=18, PANDANT=19, RI=20, BELT=21, ONEPIECE=22, SHIELD=41}</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="optionLevelFactor">option level factor from item_id.xml</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    /// <returns>constant value add defense</returns>
    [GlobalFunction(Name = "constant_value_addndd")]
    public partial float ConstantValueAddNdd(int baseValue, int deviation, int itemType, int jobCode, int optionLevelFactor, int grade, ushort levelLimit, int a7 = 0);

    /// <param name="baseValue">base value from /itemoption/constant/itemoptionconstant_*.xml</param>
    /// <param name="deviation">defined in /table/itemoptionpick.xml {1, 2}</param>
    /// <param name="itemType">one of {EARRING=12, CAP=13, CLOTH=14, PANTS=15, GLOVES=16, SHOES=17, MENTLE=18, PANDANT=19, RI=20, BELT=21, ONEPIECE=22, SHIELD=41}</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="optionLevelFactor">option level factor from item_id.xml</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    /// <returns>(min, max) constant value defense</returns>
    [GlobalFunction(Name = "constant_value_ndd")]
    public partial (float, float) ConstantValueNdd(int baseValue, int deviation, int itemType, int jobCode, int optionLevelFactor, int grade, ushort levelLimit, int a7 = 0);

    /// <param name="baseValue">base value from /itemoption/constant/itemoptionconstant_*.xml</param>
    /// <param name="deviation">defined in /table/itemoptionpick.xml {1, 2}</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="optionLevelFactor">option level factor from item_id.xml</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    /// <returns>constant value magical resistance</returns>
    [GlobalFunction(Name = "constant_value_mar")]
    public partial (float, float) ConstantValueMar(int baseValue, int deviation, int itemType, int jobCode, int optionLevelFactor, int grade, ushort levelLimit, int a7 = 0);

    /// <param name="baseValue">base value from /itemoption/constant/itemoptionconstant_*.xml</param>
    /// <param name="deviation">defined in /table/itemoptionpick.xml {1, 2}</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="optionLevelFactor">option level factor from item_id.xml</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    /// <returns>constant value physical resistance</returns>
    [GlobalFunction(Name = "constant_value_par")]
    public partial (float, float) ConstantValuePar(int baseValue, int deviation, int itemType, int jobCode, int optionLevelFactor, int grade, ushort levelLimit, int a7 = 0);

    /// <param name="baseValue">base value from /itemoption/constant/itemoptionconstant_*.xml</param>
    /// <param name="deviation">defined in /table/itemoptionpick.xml {1, 2}</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="optionLevelFactor">option level factor from item_id.xml</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    /// <returns>constant value health</returns>
    [GlobalFunction(Name = "constant_value_hp")]
    public partial (float, float) ConstantValueHp(int baseValue, int deviation, int itemType, int jobCode, int optionLevelFactor, int grade, ushort levelLimit, int a7 = 0);

    /// <param name="baseValue">base value from /itemoption/constant/itemoptionconstant_*.xml</param>
    /// <param name="deviation">defined in /table/itemoptionpick.xml {1, 2}</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="optionLevelFactor">option level factor from item_id.xml</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    /// <returns>constant value magic attack power</returns>
    [GlobalFunction(Name = "constant_value_map")]
    public partial (float, float) ConstantValueMap(int baseValue, int deviation, int itemType, int jobCode, int optionLevelFactor, int grade, ushort levelLimit, int a7 = 0);

    /// <param name="baseValue">base value from /itemoption/constant/itemoptionconstant_*.xml</param>
    /// <param name="deviation">defined in /table/itemoptionpick.xml {1, 2}</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="optionLevelFactor">option level factor from item_id.xml</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    /// <returns>constant value critical rate</returns>
    [GlobalFunction(Name = "constant_value_cap")]
    public partial (float, float) ConstantValueCap(int baseValue, int deviation, int itemType, int jobCode, int optionLevelFactor, int grade, ushort levelLimit, int a7 = 0);

    /// <param name="baseValue">base value from /itemoption/constant/itemoptionconstant_*.xml</param>
    /// <param name="deviation">defined in /table/itemoptionpick.xml {1, 2}</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="optionLevelFactor">option level factor from item_id.xml</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    /// <returns>constant value strength</returns>
    [GlobalFunction(Name = "constant_value_str")]
    public partial (float, float) ConstantValueStr(int baseValue, int deviation, int itemType, int jobCode, int optionLevelFactor, int grade, ushort levelLimit, int a7 = 0);

    /// <param name="baseValue">base value from /itemoption/constant/itemoptionconstant_*.xml</param>
    /// <param name="deviation">defined in /table/itemoptionpick.xml {1, 2}</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="optionLevelFactor">option level factor from item_id.xml</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">not sure but it can affect output when == 1</param>
    /// <returns>constant value int</returns>
    [GlobalFunction(Name = "constant_value_int")]
    public partial (float, float) ConstantValueInt(int baseValue, int deviation, int itemType, int jobCode, int optionLevelFactor, int grade, ushort levelLimit, int a7);

    /// <param name="baseValue">base value from /itemoption/constant/itemoptionconstant_*.xml</param>
    /// <param name="deviation">defined in /table/itemoptionpick.xml {1, 2}</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="optionLevelFactor">option level factor from item_id.xml</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    /// <returns>constant value dex</returns>
    [GlobalFunction(Name = "constant_value_dex")]
    public partial (float, float) ConstantValueDex(int baseValue, int deviation, int itemType, int jobCode, int optionLevelFactor, int grade, ushort levelLimit, int a7 = 0);

    /// <param name="baseValue">base value from /itemoption/constant/itemoptionconstant_*.xml</param>
    /// <param name="deviation">defined in /table/itemoptionpick.xml {1, 2}</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="optionLevelFactor">option level factor from item_id.xml</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    /// <returns>constant value luk</returns>
    [GlobalFunction(Name = "constant_value_luk")]
    public partial (float, float) ConstantValueLuk(int baseValue, int deviation, int itemType, int jobCode, int optionLevelFactor, int grade, ushort levelLimit, int a7 = 0);

    /// <param name="baseValue">base value from /itemoption/option/static/itemoptionstatic_*.xml</param>
    /// <param name="deviation">defined in /table/itemoptionpick.xml {1, 2}</param>
    /// <param name="itemType">one of {BLUNT=30, DAGGER=31, LONGSWORD=32, SCEPTRE=33, JAVELIN=34, LARGESWORD=50, BOW=51, STAFF=52, HEAVYGUN=53, RUNEBLADE=54, KNUCKLE=55, ORB=56}</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="optionLevelFactor">option level factor from item_id.xml</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    /// <returns>static value add weapon attack power</returns>
    [GlobalFunction(Name = "static_value_addwap")]
    public partial float StaticValueAddWap(int baseValue, int deviation, int itemType, int jobCode, int optionLevelFactor, int grade, ushort levelLimit, int a7 = 0);

    /// <param name="baseValue">base value from /itemoption/option/static/itemoptionstatic_*.xml</param>
    /// <param name="deviation">defined in /table/itemoptionpick.xml {1, 2}</param>
    /// <param name="itemType">one of {BLUNT=30, DAGGER=31, LONGSWORD=32, SCEPTRE=33, JAVELIN=34, LARGESWORD=50, BOW=51, STAFF=52, HEAVYGUN=53, RUNEBLADE=54, KNUCKLE=55, ORB=56}</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="optionLevelFactor">option level factor from item_id.xml</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    /// <returns>static value weapon attack max</returns>
    [GlobalFunction(Name = "static_value_wapmax")]
    public partial (float, float) StaticValueWapMax(int baseValue, int deviation, int itemType, int jobCode, int optionLevelFactor, int grade, ushort levelLimit, int a7 = 0);

    /// <param name="baseValue">base value from /itemoption/option/static/itemoptionstatic_*.xml</param>
    /// <param name="deviation">defined in /table/itemoptionpick.xml {1, 2}</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="optionLevelFactor">option level factor from item_id.xml</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    /// <returns>static value physical attack power</returns>
    [GlobalFunction(Name = "static_value_pap")]
    public partial (float, float) StaticValuePap(int baseValue, int deviation, int itemType, int jobCode, int optionLevelFactor, int grade, ushort levelLimit, int a7 = 0);

    /// <param name="baseValue">base value from /itemoption/option/static/itemoptionstatic_*.xml</param>
    /// <param name="deviation">defined in /table/itemoptionpick.xml {1, 2}</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="optionLevelFactor">option level factor from item_id.xml</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    /// <returns>static value magical attack power</returns>
    [GlobalFunction(Name = "static_value_map")]
    public partial (float, float) StaticValueMap(int baseValue, int deviation, int itemType, int jobCode, int optionLevelFactor, int grade, ushort levelLimit, int a7 = 0);

    /// <param name="baseValue">base value from /itemoption/option/static/itemoptionstatic_*.xml</param>
    /// <param name="deviation">defined in /table/itemoptionpick.xml {1, 2}</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="optionLevelFactor">option level factor from item_id.xml</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    /// <returns>static value add defense</returns>
    [GlobalFunction(Name = "static_value_addndd")]
    public partial float StaticValueAddNdd(int baseValue, int deviation, int itemType, int jobCode, int optionLevelFactor, int grade, ushort levelLimit, int a7 = 0);

    /// <param name="baseValue">base value from /itemoption/option/static/itemoptionstatic_*.xml</param>
    /// <param name="deviation">defined in /table/itemoptionpick.xml {1, 2}</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="optionLevelFactor">option level factor from item_id.xml</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    /// <returns>static value defense</returns>
    [GlobalFunction(Name = "static_value_ndd")]
    public partial (float, float) StaticValueNdd(int baseValue, int deviation, int itemType, int jobCode, int optionLevelFactor, int grade, ushort levelLimit, int a7 = 0);

    /// <param name="baseValue">base value from /itemoption/option/static/itemoptionstatic_*.xml</param>
    /// <param name="deviation">defined in /table/itemoptionpick.xml {1, 2}</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="optionLevelFactor">option level factor from item_id.xml</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    /// <returns>static value health</returns>
    [GlobalFunction(Name = "static_value_hp")]
    public partial (float, float) StaticValueHp(int baseValue, int deviation, int itemType, int jobCode, int optionLevelFactor, int grade, ushort levelLimit, int a7 = 0);

    /// <param name="baseValue">base value from /itemoption/option/static/itemoptionstatic_*.xml</param>
    /// <param name="deviation">defined in /table/itemoptionpick.xml {1, 2}</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="optionLevelFactor">option level factor from item_id.xml</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    /// <returns>static value magical resistance</returns>
    [GlobalFunction(Name = "static_value_mar")]
    public partial (float, float) StaticValueMar(int baseValue, int deviation, int itemType, int jobCode, int optionLevelFactor, int grade, ushort levelLimit, int a7 = 0);

    /// <param name="baseValue">base value from /itemoption/option/static/itemoptionstatic_*.xml</param>
    /// <param name="deviation">defined in /table/itemoptionpick.xml {1, 2}</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="optionLevelFactor">option level factor from item_id.xml</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    /// <returns>static value physical resistance</returns>
    [GlobalFunction(Name = "static_value_par")]
    public partial (float, float) StaticValuePar(int baseValue, int deviation, int itemType, int jobCode, int optionLevelFactor, int grade, ushort levelLimit, int a7 = 0);

    /// <param name="baseValue">base value from /itemoption/option/static/itemoptionstatic_*.xml</param>
    /// <param name="deviation">defined in /table/itemoptionpick.xml {1, 2}</param>
    /// <param name="itemType">item type code</param>
    /// <param name="jobCode">one of {Newbie=1, Knight=10, Berserker=20, Wizard=30, Priest=40, Ranger=50, HeavyGunner=60, Thief=70, Assassin=80, RuneBlader=90, Striker=100, SoulBinder=110, GM=999}</param>
    /// <param name="optionLevelFactor">option level factor from item_id.xml</param>
    /// <param name="grade">one of {Normal=1, Rare=2, Elite=3, Excellent=4, Legendary=5, Artifact=6}</param>
    /// <param name="levelLimit">level limit of the item</param>
    /// <param name="a7">unused</param>
    /// <returns>static rate perfect guard</returns>
    [GlobalFunction(Name = "static_rate_abp")]
    public partial (float, float) StaticRateAbp(int baseValue, int deviation, int itemType, int jobCode, int optionLevelFactor, int grade, ushort levelLimit, int a7 = 0);
}
