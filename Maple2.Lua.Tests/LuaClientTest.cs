using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Maple2.Lua.Tests;

[TestClass]
public class LuaClientTest {
    private const string LOCALE = "NA";

    private readonly Lua lua;

    public LuaClientTest() {
        lua = new Lua(LOCALE);
    }

    [TestMethod]
    public void TestCalcNpcSpawnWeight() {
        Assert.AreEqual(44, lua.CalcNpcSpawnWeight(1, 1, 100, 31));
        Assert.AreEqual(5, lua.CalcNpcSpawnWeight(0, 1, 100, 31));
        Assert.AreEqual(47, lua.CalcNpcSpawnWeight(1, 4, 100, 31));
    }

    [TestMethod]
    public void TestItemRemakeIngredient() {
        const int accessoryType = 12;
        const int armorType = 13;
        const int weaponType = 30;
        const int rarity = 4;
        const ushort level = 50;

        Assert.AreEqual(("GreenCrystal", 5, "CrystalPiece", 200, "MetaCell", 11),
            lua.CalcGetItemRemakeIngredient(accessoryType, 0, rarity, level));
        Assert.AreEqual(("GreenCrystal", 5, "CrystalPiece", 1718, "MetaCell", 21),
            lua.CalcGetItemRemakeIngredient(accessoryType, 10, rarity, level));
        Assert.AreEqual(("GreenCrystal", 5, "CrystalPiece", 4063, "MetaCell", 25),
            lua.CalcGetItemRemakeIngredient(accessoryType, 20, rarity, level));

        Assert.AreEqual(("BlueCrystal", 1, "CrystalPiece", 200, "MetaCell", 11),
            lua.CalcGetItemRemakeIngredient(armorType, 0, rarity, level));
        Assert.AreEqual(("BlueCrystal", 1, "CrystalPiece", 1718, "MetaCell", 21),
            lua.CalcGetItemRemakeIngredient(armorType, 10, rarity, level));
        Assert.AreEqual(("BlueCrystal", 1, "CrystalPiece", 4063, "MetaCell", 25),
            lua.CalcGetItemRemakeIngredient(armorType, 20, rarity, level));

        Assert.AreEqual(("RedCrystal", 2, "CrystalPiece", 400, "MetaCell", 22),
            lua.CalcGetItemRemakeIngredient(weaponType, 0, rarity, level));
        Assert.AreEqual(("RedCrystal", 2, "CrystalPiece", 3436, "MetaCell", 42),
            lua.CalcGetItemRemakeIngredient(weaponType, 10, rarity, level));
        Assert.AreEqual(("RedCrystal", 2, "CrystalPiece", 8126, "MetaCell", 50),
            lua.CalcGetItemRemakeIngredient(weaponType, 20, rarity, level));
    }

    [TestMethod]
    public void TestItemRemakeIngredientNew() {
        const int accessoryType = 12;
        const int armorType = 13;
        const int weaponType = 30;
        const int rarity = 4;
        const ushort level = 50;

        Assert.AreEqual(("GreenCrystal", 5, "CrystalPiece", 200, "MetaCell", 11),
            lua.CalcGetItemRemakeIngredientNew(accessoryType, 0, rarity, level));
        Assert.AreEqual(("GreenCrystal", 5, "CrystalPiece", 1718, "MetaCell", 21),
            lua.CalcGetItemRemakeIngredientNew(accessoryType, 10, rarity, level));
        Assert.AreEqual(("GreenCrystal", 5, "CrystalPiece", 4063, "MetaCell", 25),
            lua.CalcGetItemRemakeIngredientNew(accessoryType, 20, rarity, level));

        Assert.AreEqual(("BlueCrystal", 1, "CrystalPiece", 200, "MetaCell", 11),
            lua.CalcGetItemRemakeIngredientNew(armorType, 0, rarity, level));
        Assert.AreEqual(("BlueCrystal", 1, "CrystalPiece", 1718, "MetaCell", 21),
            lua.CalcGetItemRemakeIngredientNew(armorType, 10, rarity, level));
        Assert.AreEqual(("BlueCrystal", 1, "CrystalPiece", 4063, "MetaCell", 25),
            lua.CalcGetItemRemakeIngredientNew(armorType, 20, rarity, level));

        Assert.AreEqual(("RedCrystal", 2, "CrystalPiece", 400, "MetaCell", 22),
            lua.CalcGetItemRemakeIngredientNew(weaponType, 0, rarity, level));
        Assert.AreEqual(("RedCrystal", 2, "CrystalPiece", 3436, "MetaCell", 42),
            lua.CalcGetItemRemakeIngredientNew(weaponType, 10, rarity, level));
        Assert.AreEqual(("RedCrystal", 2, "CrystalPiece", 8126, "MetaCell", 50),
            lua.CalcGetItemRemakeIngredientNew(weaponType, 20, rarity, level));
    }
}
