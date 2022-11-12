using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Maple2.Lua.Tests;

[TestClass]
public class LuaItemOptionTest {
    private const string LOCALE = "NA";

    private readonly Lua lua;

    public LuaItemOptionTest() {
        lua = new Lua(LOCALE);
    }

    [TestMethod]
    public void TestCalcItemOption() {
        (float, float) wapMin = lua.ConstantValueWapMin(0, 1, 54, 90, 50, 5, 50);
        (float, float) wapMax = lua.ConstantValueWapMax(0, 1, 54, 90, 50, 5, 50);
        (float, float) cap = lua.ConstantValueCap(0, 1, 54, 90, 50, 5, 54);
        Assert.AreEqual((3493, 3493), wapMin);
        Assert.AreEqual((3708, 3708), wapMax);
        Assert.AreEqual((20, 20), cap);

        (float, float) staticWapMax = lua.StaticValueWapMax(0, 0, 54, 90, 50, 5, 54);
        (float, float) staticMap = lua.StaticValueMap(0, 0, 54, 90, 50, 5, 54);
        Assert.AreEqual((443.905029296875, 569.1090087890625), staticWapMax);
        Assert.AreEqual((6, 9), staticMap);
    }

    [TestMethod]
    public void TestConstValue() {
        const int weaponType = 30;
        const int capeType = 18;
        const int ringType = 20;
        const int armorType = 13;
        const int levelFactor = 50;
        const int rarity = 4;
        const ushort level = 60;

        Assert.AreEqual((30, 30), lua.ConstantValueStr(0, 0, armorType, 20, levelFactor, rarity, level));
        Assert.AreEqual((30, 30), lua.ConstantValueDex(0, 0, weaponType, 50, levelFactor, rarity, level));
        Assert.AreEqual((30, 30), lua.ConstantValueInt(0, 0, weaponType, 30, levelFactor, rarity, level, 0));
        Assert.AreEqual((0, 0), lua.ConstantValueInt(0, 0, weaponType, 100, levelFactor, rarity, level, 0));
        Assert.AreEqual((30, 30), lua.ConstantValueInt(0, 0, weaponType, 100, levelFactor, rarity, level, 1));
        Assert.AreEqual((30, 30), lua.ConstantValueLuk(0, 0, weaponType, 70, levelFactor, rarity, level));

        Assert.AreEqual((325, 325), lua.ConstantValueHp(0, 0, capeType, 10, 60, rarity, level));
        Assert.AreEqual((9, 9), lua.ConstantValueCap(0, 0, weaponType, 80, levelFactor, rarity, level));
        Assert.AreEqual((461, 461), lua.ConstantValueNdd(0, 1, armorType, 10, levelFactor, rarity, level));
        Assert.AreEqual((34, 34), lua.ConstantValueMap(0, 0, weaponType, 30, levelFactor, rarity, level));
        Assert.AreEqual((36, 36), lua.ConstantValuePar(0, 0, capeType, 10, levelFactor, rarity, level));
        Assert.AreEqual((53, 53), lua.ConstantValueMar(0, 0, ringType, 30, levelFactor, rarity, level));
        Assert.AreEqual((2853, 2853), lua.ConstantValueWapMin(0, 1, weaponType, 1, levelFactor, rarity, level));
        Assert.AreEqual((3152, 3152), lua.ConstantValueWapMax(0, 1, weaponType, 1, levelFactor, rarity, level));
    }

    [TestMethod]
    public void TestStaticValue() {
        const int weaponType = 30;
        const int armorType = 13;
        const int job = 1;
        const int levelFactor = 50;
        const int rarity = 4;
        const ushort level = 50;

        Assert.AreEqual((40, 55), lua.StaticValueHp(0, 0, weaponType, job, levelFactor, rarity, level));
        Assert.AreEqual((29, 36), lua.StaticValueNdd(0, 0, armorType, job, levelFactor, rarity, level));
        Assert.AreEqual((3, 6), lua.StaticValuePap(0, 0, weaponType, job, levelFactor, rarity, level));
        Assert.AreEqual((3, 6), lua.StaticValueMap(0, 0, weaponType, job, levelFactor, rarity, level));
        Assert.AreEqual((17, 22), lua.StaticValuePar(0, 0, weaponType, job, levelFactor, rarity, level));
        Assert.AreEqual((14, 19), lua.StaticValueMar(0, 0, weaponType, job, levelFactor, rarity, level));
        Assert.AreEqual((229.08412170410156, 293.6976013183594),
            lua.StaticValueWapMax(0, 0, weaponType, job, levelFactor, rarity, level));
    }

    [TestMethod]
    public void TestStaticRate() {
        const int armorType = 13;
        const int job = 1;
        const int levelFactor = 50;
        const int rarity = 4;
        const ushort level = 50;

        Assert.AreEqual((0.1420000046491623, 0.1550000011920929),
            lua.StaticRateAbp(0, 0, armorType, job, levelFactor, rarity, level));
    }
}
