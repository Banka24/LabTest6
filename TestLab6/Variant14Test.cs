using Lab63;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLab6;

[TestClass]
public class Variant14Test
{
    [TestMethod]
    public void GetSrSum_Return7dot8()
    {
        var array = new double[,]
        {
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 }
        };

        var expected = 7.80;
        var actual = Variant14.GetSrSum(array);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetSrSum_Return7dot08()
    {
        var array = new double[,]
        {
            { 1, 2, 3, 4, 5, 4, 5, 9, 8 },
            { 1, 2, 3, 4, 5, 4, 5, 9, 8 },
            { 1, 2, 3, 4, 5, 4, 5, 9, 8 },
            { 1, 2, 3, 4, 5, 4, 5, 9, 8 },
            { 1, 2, 3, 4, 5, 4, 5, 9, 8 },
            { 1, 2, 3, 4, 5, 4, 5, 9, 8 },
            { 1, 2, 3, 4, 5, 4, 5, 9, 8 },
            { 1, 2, 3, 4, 5, 4, 5, 9, 8 },
            { 1, 2, 3, 4, 5, 4, 5, 9, 8 },
        };

        var expected = 7.08;
        var actual = Variant14.GetSrSum(array);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetSrSum_Return7dot2()
    {
        var array = new double[,]
        {
            { 1, 2, 3, 4, 2, 6, 5, 9, 8 },
            { 1, 2, 3, 4, 2, 6, 5, 9, 8 },
            { 1, 2, 3, 4, 2, 6, 5, 9, 8 },
            { 1, 2, 3, 4, 2, 6, 5, 9, 8 },
            { 1, 2, 3, 4, 2, 6, 5, 9, 8 },
            { 1, 2, 3, 4, 2, 6, 5, 9, 8 },
            { 1, 2, 3, 4, 2, 6, 5, 9, 8 },
            { 1, 2, 3, 4, 2, 6, 5, 9, 8 },
            { 1, 2, 3, 4, 2, 6, 5, 9, 8 },
        };

        var expected = 7.20;
        var actual = Variant14.GetSrSum(array);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetSrSum_Return8dot32()
    {
        var array = new double[,]
        {
            { 1, 2, 3, 4, 12, 6, 10, 8, 8 },
            { 1, 2, 3, 4, 12, 6, 10, 8, 8 },
            { 1, 2, 3, 4, 12, 6, 10, 8, 8 },
            { 1, 2, 3, 4, 12, 6, 10, 8, 8 },
            { 1, 2, 3, 4, 12, 6, 10, 8, 8 },
            { 1, 2, 3, 4, 12, 6, 10, 8, 8 },
            { 1, 2, 3, 4, 12, 6, 10, 8, 8 },
            { 1, 2, 3, 4, 12, 6, 10, 8, 8 },
            { 1, 2, 3, 4, 12, 6, 10, 8, 8 },
        };

        var expected = 8.32;
        var actual = Variant14.GetSrSum(array);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetSrSum_Return30dot16()
    {
        var array = new double[,]
        {
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
        };

        var expected = 30.16;
        var actual = Variant14.GetSrSum(array);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetNegativeElements_Return1()
    {
        var array = new double[,]
        {
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, -9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, -8, -9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, -9 }
        };

        double[] expected = [-9, -9, -9, -8];
        var actual = Variant14.GetNegativeElements(array);
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetNegativeElements_Return2()
    {
        var array = new double[,]
        {
            { 1, 2, 3, 4, 5, 6, 7, -8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, -9 },
            { 1, 2, 3, 4, 5, 6, -7, -8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, -6, -7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, -8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, -8, -9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, -9 }
        };

        double[] expected = [-9, -9, -9, -8, -8, -8, -7, -7, -6];
        var actual = Variant14.GetNegativeElements(array);
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetNegativeElements_Return3()
    {
        var array = new double[,]
        {
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, -6, -7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, -8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, -8, -9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, -9 }
        };

        double[] expected = [-9, -9, -8, -8, -7, -6];
        var actual = Variant14.GetNegativeElements(array);
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetNegativeElements_Return4()
    {
        var array = new double[,]
        {
            { 1, 2, 3, 4, 5, 6, 7, -8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, -9 },
            { 1, 2, 3, 4, 5, 6, -7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, -6, -7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 }
        };

        double[] expected = [-9, -7, -7, -6];
        var actual = Variant14.GetNegativeElements(array);
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetNegativeElements_Return()
    {
        var array = new double[,]
        {
            { 1, 2, 3, 4, 5, 6, 7, -8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, -9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, -8, -9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, -9 }
        };

        double[] expected = [-9, -9, -9, -8];
        var actual = Variant14.GetNegativeElements(array);
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetProducts_Return1()
    {
        var array = new double[,]
        {
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            {9, 8, 7, 6, 5, 4, 3, 2, 1},
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            {9, 8, 7, 6, 5, 4, 3, 2, 1},
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            {9, 8, 7, 6, 5, 4, 3, 2, 1},
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            {9, 8, 7, 6, 5, 4, 3, 2, 1},
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 }
        };

        double[] expected = [59049, 8192, 3087, 96, 5];
        var actual = Variant14.GetProducts(array);
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetProducts_Return2()
    {
        var array = new double[,]
        {
            { 1, 2, 3, 4, 5, 6, 7, 8, 7 },
            {9, 8, 7, 6, 5, 4, 3, 2, 1},
            { 1, 2, 3, 4, 5, 6, 7, 8, 3 },
            {9, 8, 7, 6, 5, 4, 3, 2, 1},
            { 1, 2, 3, 4, 6, 6, 7, 8, 5 },
            {9, 8, 7, 6, 5, 4, 3, 2, 1},
            { 1, 2, 3, 4, 5, 6, 7, 8, 4 },
            {9, 8, 7, 6, 5, 4, 3, 2, 1},
            { 1, 2, 3, 4, 5, 6, 7, 8, 2 }
        };

        double[] expected = [840, 8192, 3087, 96, 6];
        var actual = Variant14.GetProducts(array);
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetProducts_Return3()
    {
        var array = new double[,]
        {
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            {9, 8, 7, 6, 5, 4, 3, 2, 1},
            { 1, 2, 3, 4, 5, 6, 7, 7, 9 },
            {9, 8, 7, 6, 5, 4, 3, 2, 1},
            { 1, 2, 3, 4, 5, 6, 7, 7, 9 },
            {9, 8, 7, 6, 5, 4, 3, 2, 1},
            { 1, 2, 3, 4, 5, 6, 7, 7, 9 },
            {9, 8, 7, 6, 5, 4, 3, 2, 1},
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 }
        };

        double[] expected = [59049, 5488, 3087, 96, 5];
        var actual = Variant14.GetProducts(array);
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetProducts_Return4()
    {
        var array = new double[,]
        {
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            {9, 8, 7, 6, 5, 4, 3, 2, 1},
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            {9, 8, 7, 6, 5, 4, 4, 2, 1},
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            {9, 8, 7, 6, 5, 4, 4, 2, 1},
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            {9, 8, 7, 6, 5, 4, 4, 2, 1},
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 }
        };

        double[] expected = [59049, 8192, 5488, 96, 5];
        var actual = Variant14.GetProducts(array);
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetProducts_Return5()
    {
        var array = new double[,]
        {
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            {9, 8, 7, 6, 5, 4, 3, 2, 1},
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            {9, 8, 7, 6, 5, 4, 3, 2, 1},
            { 1, 2, 3, 4, 9, 6, 7, 8, 9 },
            {9, 8, 7, 6, 5, 4, 3, 2, 1},
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            {9, 8, 7, 6, 5, 4, 3, 2, 1},
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 }
        };

        double[] expected = [59049, 8192, 3087, 96, 9];
        var actual = Variant14.GetProducts(array);
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Replace_Return1()
    {
        var array = new double[,]
        {
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            {9, 8, 7, 6, 5, 4, 3, 2, 1},
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            {9, 8, 7, 6, 5, 4, 3, 2, 1},
            { 1, 2, 3, 4, 9, 6, 7, 8, 9 },
            {9, 8, 7, 6, 5, 4, 3, 2, 1},
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            {9, 8, 7, 6, 5, 4, 3, 2, 1},
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 }
        };

        var expected = new double[,]
        {
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            {9, 8, 7, 6, 5, 4, 3, 2, 1},
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            {9, 8, 7, 6, 5, 4, 3, 2, 1},
            { 1, 2, 3, 4, 9, 6, 7, 8, 9 },
            {9, 8, 7, 6, 5, 4, 3, 2, 1},
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            {9, 8, 7, 6, 5, 4, 3, 2, 1},
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 }
        };

        var actual = Variant14.Replace(array);
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Replace_Return2()
    {
        var array = new double[,]
        {
            { 1, 2, 3, 4, 5, 6, 7, -8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, -9 },
            { 1, 2, 3, 4, 5, 6, -7, -8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, -6, -7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, -8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, -8, -9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, -9 }
        };

        var expected = new double[,]
        {
            { 1, 2, 3, 4, 5, 6, 7, -8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, -9 },
            { 1, 2, 3, 4, 5, 6, -7, -8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, -6, -7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, -8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, -8, -9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, -9 }
        };

        var actual = Variant14.Replace(array);
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Replace_Return3()
    {
        var array = new double[,]
        {
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
        };

        var expected = new double[,]
        {
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
        };

        var actual = Variant14.Replace(array);
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Replace_Return4()
    {
        var array = new double[,]
        {
            { 1, 2, 3, 4, 12, 6, 17, 81, 12 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 12 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 12, 17, 12, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
        };

        var expected = new double[,]
        {
            { 1, 2, 3, 4, 12, 6, 17, 81, -1 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, -1 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, -1, 17, -1, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
        };

        var actual = Variant14.Replace(array);
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Replace_Return5()
    {
        var array = new double[,]
        {
            { 1, 2, 3, 4, 12, 6, 17, 81, 12 },
            { 1, 2, 3, 4, 12, 12, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 12 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 12, 17, 12,12 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 12, 12, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
        };

        var expected = new double[,]
        {
            { 1, 2, 3, 4, 12, 6, 17, 81, -1 },
            { 1, 2, 3, 4, 12, -1, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, -1 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, -1, 17, -1,-1 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, -1, -1, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
            { 1, 2, 3, 4, 12, 6, 17, 81, 8 },
        };

        var actual = Variant14.Replace(array);
        CollectionAssert.AreEqual(expected, actual);
    }
}