using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Maple2.Lua.Tests; 

[TestClass]
public class LuaTest {
    private const string LOCALE = "NA";
    
    private readonly Lua lua;
    
    public LuaTest() {
        lua = new Lua(LOCALE);
    }

    [DataTestMethod]
    [DataRow("KR")]
    [DataRow("CN")]
    [DataRow("NA")]
    [DataRow("JP")]
    [DataRow("TH")]
    [DataRow("TW")]
    public void TestLocale_SetGet(string locale) {
        lua.SetLocale(locale);
        Assert.AreEqual(locale, lua.GetLocale());
    }

    [DataTestMethod]
    [DataRow(0.5, 0.1, 0.8, 0.5, DisplayName = "no clipping")]
    [DataRow(0.5, 0.7, 0.8, 0.7, DisplayName = "clip min")]
    [DataRow(0.5, 0.1, 0.3, 0.3, DisplayName = "clip max")]
    public void TestClipValue(double value, double min, double max, double expected) {
        Assert.AreEqual(expected, lua.ClipValue(value, min, max));
    }

    [DataTestMethod]
    [DataRow(1.23456, 0, 1, DisplayName = "no decimals")]
    [DataRow(1.23456, 3, 1.235, DisplayName = "round up")]
    [DataRow(1.23456, 2, 1.23, DisplayName = "round down")]
    public void TestRound(double value, int digits, double expected) {
        Assert.AreEqual(expected, lua.Round(value, digits));
    }
    
    [DataTestMethod]
    [DataRow(1.23456, 0, 1, DisplayName = "no decimals")]
    [DataRow(1.23456, 3, 1.234, DisplayName = "don't round up")]
    [DataRow(1.23456, 2, 1.23, DisplayName = "normal round down")]
    public void TestFloor(double value, int digits, double expected) {
        Assert.AreEqual(expected, lua.Floor(value, digits));
    }
    
    [DataTestMethod]
    [DataRow(1.23456, 0, 2, DisplayName = "no decimals")]
    [DataRow(1.23456, 3, 1.235, DisplayName = "normal round up")]
    [DataRow(1.23456, 2, 1.24, DisplayName = "don't round down")]
    public void TestCeiling(double value, int digits, double expected) {
        Assert.AreEqual(expected, lua.Ceiling(value, digits));
    }
}
