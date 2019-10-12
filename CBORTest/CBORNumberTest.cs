using System;
using NUnit.Framework;
using PeterO.Cbor;
using PeterO.Numbers;
namespace Test {
[TestFixture]
public class CBORNumberTest {
[Test]
public void TestToCBORObject() {
// not implemented yet
}
[Test]
public void TestFromCBORObject() {
// not implemented yet
}
[Test]
public void TestToString() {
// not implemented yet
}
[Test]
public void TestCanFitInInt32() {
// not implemented yet
}
[Test]
public void TestCanFitInInt64() {
// not implemented yet
}
[Test]
public void TestIsInfinity() {
// not implemented yet
}
[Test]
public void TestIsNaN() {
      Assert.IsFalse(CBORObject.FromObject(0).AsNumber().IsNaN());
      Assert.IsFalse(CBORObject.FromObject(99).AsNumber().IsNaN());
      Assert.IsFalse(CBORObject.PositiveInfinity.AsNumber().IsNaN());
      Assert.IsFalse(CBORObject.NegativeInfinity.AsNumber().IsNaN());
      Assert.IsTrue(CBORObject.NaN.AsNumber().IsNaN());
}
[Test]
public void TestNegate() {
// not implemented yet
}
[Test]
public void TestAdd() {
// not implemented yet
}
[Test]
public void TestSubtract() {
// not implemented yet
}
[Test]
public void TestMultiply() {
// not implemented yet
}
[Test]
public void TestDivide() {
// not implemented yet
}
[Test]
public void TestRemainder() {
// not implemented yet
}
[Test]
public void TestCompareTo() {
// not implemented yet
}
[Test]
public void TestLessThan() {
// not implemented yet
}
[Test]
public void TestLessThanOrEqual() {
// not implemented yet
}
[Test]
public void TestGreaterThan() {
// not implemented yet
}
[Test]
public void TestGreaterThanOrEqual() {
// not implemented yet
}
[Test]
public void TestGetType() {
// not implemented yet
}

[Test]
public void TestAsEInteger() {
      try {
        ToObjectTest.TestToFromObjectRoundTrip(
          (object)null).AsNumber().AsEInteger();
        Assert.Fail("Should have failed");
      } catch (InvalidOperationException) {
        // NOTE: Intentionally empty
      } catch (Exception ex) {
        Assert.Fail(ex.ToString());
        throw new InvalidOperationException(String.Empty, ex);
      }
      try {
        CBORObject.Null.AsNumber().AsEInteger();
        Assert.Fail("Should have failed");
      } catch (InvalidOperationException) {
        // NOTE: Intentionally empty
      } catch (Exception ex) {
        Assert.Fail(ex.ToString());
        throw new InvalidOperationException(String.Empty, ex);
      }
      try {
        CBORObject.True.AsNumber().AsEInteger();
        Assert.Fail("Should have failed");
      } catch (InvalidOperationException) {
        // NOTE: Intentionally empty
      } catch (Exception ex) {
        Assert.Fail(ex.ToString());
        throw new InvalidOperationException(String.Empty, ex);
      }
      try {
        CBORObject.False.AsNumber().AsEInteger();
        Assert.Fail("Should have failed");
      } catch (InvalidOperationException) {
        // NOTE: Intentionally empty
      } catch (Exception ex) {
        Assert.Fail(ex.ToString());
        throw new InvalidOperationException(String.Empty, ex);
      }
      try {
        CBORObject.Undefined.AsNumber().AsEInteger();
        Assert.Fail("Should have failed");
      } catch (InvalidOperationException) {
        // NOTE: Intentionally empty
      } catch (Exception ex) {
        Assert.Fail(ex.ToString());
        throw new InvalidOperationException(String.Empty, ex);
      }
      try {
        CBORObject.NewArray().AsNumber().AsEInteger();
        Assert.Fail("Should have failed");
      } catch (InvalidOperationException) {
        // NOTE: Intentionally empty
      } catch (Exception ex) {
        Assert.Fail(ex.ToString());
        throw new InvalidOperationException(String.Empty, ex);
      }
      try {
        CBORObject.NewMap().AsNumber().AsEInteger();
        Assert.Fail("Should have failed");
      } catch (InvalidOperationException) {
        // NOTE: Intentionally empty
      } catch (Exception ex) {
        Assert.Fail(ex.ToString());
        throw new InvalidOperationException(String.Empty, ex);
      }
      CBORObject numbers = CBORObjectTest.GetNumberData();
      for (int i = 0; i < numbers.Count; ++i) {
        CBORObject numberinfo = numbers[i];
        string numberString = numberinfo["number"].AsString();
        CBORObject cbornumber =
  ToObjectTest.TestToFromObjectRoundTrip(EDecimal.FromString(numberString));
        if (!numberinfo["integer"].Equals(CBORObject.Null)) {
          Assert.AreEqual(
            numberinfo["integer"].AsString(),
            cbornumber.AsNumber().AsEInteger().ToString());
        } else {
          try {
            cbornumber.AsNumber().AsEInteger();
            Assert.Fail("Should have failed");
          } catch (OverflowException) {
            // NOTE: Intentionally empty
          } catch (Exception ex) {
            Assert.Fail(ex.ToString());
            throw new InvalidOperationException(String.Empty, ex);
          }
        }
      }

      {
        string stringTemp =
ToObjectTest.TestToFromObjectRoundTrip(0.75f).AsNumber().AsEInteger()
            .ToString();
        Assert.AreEqual(
          "0",
          stringTemp);
      }
      {
        string stringTemp =
ToObjectTest.TestToFromObjectRoundTrip(0.99f).AsNumber().AsEInteger()
            .ToString();
        Assert.AreEqual(
          "0",
          stringTemp);
      }
      {
        string stringTemp =
ToObjectTest.TestToFromObjectRoundTrip(0.0000000000000001f)
            .AsNumber().AsEInteger().ToString();
        Assert.AreEqual(
          "0",
          stringTemp);
      }
      {
        string stringTemp =
ToObjectTest.TestToFromObjectRoundTrip(0.5f).AsNumber().AsEInteger()
            .ToString();
        Assert.AreEqual(
          "0",
          stringTemp);
      }
      {
        string stringTemp =
ToObjectTest.TestToFromObjectRoundTrip(1.5f).AsNumber().AsEInteger()
            .ToString();
        Assert.AreEqual(
          "1",
          stringTemp);
      }
      {
        string stringTemp =
ToObjectTest.TestToFromObjectRoundTrip(2.5f).AsNumber().AsEInteger()
            .ToString();
        Assert.AreEqual(
          "2",
          stringTemp);
      }
      {
        string stringTemp =

ToObjectTest.TestToFromObjectRoundTrip(
  (float)328323f).AsNumber().AsEInteger().ToString();
        Assert.AreEqual(
          "328323",
          stringTemp);
      }
      {
        string stringTemp =
ToObjectTest.TestToFromObjectRoundTrip((double)0.75).AsNumber().AsEInteger()
            .ToString();
        Assert.AreEqual(
          "0",
          stringTemp);
      }
      {
        string stringTemp =
ToObjectTest.TestToFromObjectRoundTrip((double)0.99).AsNumber().AsEInteger()
            .ToString();
        Assert.AreEqual(
          "0",
          stringTemp);
      }
      {
        string stringTemp =
ToObjectTest.TestToFromObjectRoundTrip((double)0.0000000000000001)
            .AsNumber().AsEInteger().ToString();
        Assert.AreEqual(
          "0",
          stringTemp);
      }
      {
        string stringTemp =
ToObjectTest.TestToFromObjectRoundTrip((double)0.5).AsNumber().AsEInteger()
            .ToString();
        Assert.AreEqual(
          "0",
          stringTemp);
      }
      {
        string stringTemp =
ToObjectTest.TestToFromObjectRoundTrip((double)1.5).AsNumber().AsEInteger()
            .ToString();
        Assert.AreEqual(
          "1",
          stringTemp);
      }
      {
        string stringTemp =
ToObjectTest.TestToFromObjectRoundTrip((double)2.5).AsNumber().AsEInteger()
            .ToString();
        Assert.AreEqual(
          "2",
          stringTemp);
      }
      {
        double dbl = 328323;
        string stringTemp =
          ToObjectTest.TestToFromObjectRoundTrip(dbl)
            .AsNumber().AsEInteger().ToString();
        Assert.AreEqual(
          "328323",
          stringTemp);
      }
      try {
        ToObjectTest.TestToFromObjectRoundTrip(Single.PositiveInfinity)
                  .AsNumber().AsEInteger();
        Assert.Fail("Should have failed");
      } catch (OverflowException) {
        // NOTE: Intentionally empty
      } catch (Exception ex) {
        Assert.Fail(ex.ToString());
        throw new InvalidOperationException(String.Empty, ex);
      }
      try {
        ToObjectTest.TestToFromObjectRoundTrip(Single.NegativeInfinity)
                  .AsNumber().AsEInteger();
        Assert.Fail("Should have failed");
      } catch (OverflowException) {
        // NOTE: Intentionally empty
      } catch (Exception ex) {
        Assert.Fail(ex.ToString());
        throw new InvalidOperationException(String.Empty, ex);
      }
      try {
        ToObjectTest.TestToFromObjectRoundTrip(
          Single.NaN).AsNumber().AsEInteger();
        Assert.Fail("Should have failed");
      } catch (OverflowException) {
        // NOTE: Intentionally empty
      } catch (Exception ex) {
        Assert.Fail(ex.ToString());
        throw new InvalidOperationException(String.Empty, ex);
      }
      try {
        ToObjectTest.TestToFromObjectRoundTrip(Double.PositiveInfinity)
                  .AsNumber().AsEInteger();
        Assert.Fail("Should have failed");
      } catch (OverflowException) {
        // NOTE: Intentionally empty
      } catch (Exception ex) {
        Assert.Fail(ex.ToString());
        throw new InvalidOperationException(String.Empty, ex);
      }
      try {
        ToObjectTest.TestToFromObjectRoundTrip(Double.NegativeInfinity)
                  .AsNumber().AsEInteger();
        Assert.Fail("Should have failed");
      } catch (OverflowException) {
        // NOTE: Intentionally empty
      } catch (Exception ex) {
        Assert.Fail(ex.ToString());
        throw new InvalidOperationException(String.Empty, ex);
      }
      try {
        ToObjectTest.TestToFromObjectRoundTrip(
          Double.NaN).AsNumber().AsEInteger();
        Assert.Fail("Should have failed");
      } catch (OverflowException) {
        // NOTE: Intentionally empty
      } catch (Exception ex) {
        Assert.Fail(ex.ToString());
        throw new InvalidOperationException(String.Empty, ex);
      }
    }

[Test]
public void TestAsEDecimal() {
      {
        object objectTemp = CBORTestCommon.DecPosInf;
        object objectTemp2 =
          ToObjectTest.TestToFromObjectRoundTrip(Single.PositiveInfinity)
                  .AsNumber().AsEDecimal();
        Assert.AreEqual(objectTemp, objectTemp2);
      }
      {
        object objectTemp = CBORTestCommon.DecNegInf;
        object objectTemp2 =
          ToObjectTest.TestToFromObjectRoundTrip(Single.NegativeInfinity)
                  .AsNumber().AsEDecimal();
        Assert.AreEqual(objectTemp, objectTemp2);
      }
      {
        string stringTemp =
ToObjectTest.TestToFromObjectRoundTrip(Single.NaN).AsNumber().AsEDecimal()
            .ToString();
        Assert.AreEqual(
          "NaN",
          stringTemp);
      }
      {
        object objectTemp = CBORTestCommon.DecPosInf;
        object objectTemp2 =
          ToObjectTest.TestToFromObjectRoundTrip(Double.PositiveInfinity)
                  .AsNumber().AsEDecimal();
        Assert.AreEqual(objectTemp, objectTemp2);
      }
      {
        object objectTemp = CBORTestCommon.DecNegInf;
        object objectTemp2 =
          ToObjectTest.TestToFromObjectRoundTrip(Double.NegativeInfinity)
                  .AsNumber().AsEDecimal();
        Assert.AreEqual(objectTemp, objectTemp2);
      }
      {
        object objectTemp = "NaN";
        object objectTemp2 =
          ToObjectTest.TestToFromObjectRoundTrip(
            Double.NaN).AsNumber().AsEDecimal()
                    .ToString();
        Assert.AreEqual(objectTemp, objectTemp2);
      }
      try {
        CBORObject.NewArray().AsNumber().AsEDecimal();
        Assert.Fail("Should have failed");
      } catch (InvalidOperationException) {
        // NOTE: Intentionally empty
      } catch (Exception ex) {
        Assert.Fail(ex.ToString());
        throw new InvalidOperationException(String.Empty, ex);
      }
      try {
        CBORObject.NewMap().AsNumber().AsEDecimal();
        Assert.Fail("Should have failed");
      } catch (InvalidOperationException) {
        // NOTE: Intentionally empty
      } catch (Exception ex) {
        Assert.Fail(ex.ToString());
        throw new InvalidOperationException(String.Empty, ex);
      }
      try {
        CBORObject.True.AsNumber().AsEDecimal();
        Assert.Fail("Should have failed");
      } catch (InvalidOperationException) {
        // NOTE: Intentionally empty
      } catch (Exception ex) {
        Assert.Fail(ex.ToString());
        throw new InvalidOperationException(String.Empty, ex);
      }
      try {
        CBORObject.False.AsNumber().AsEDecimal();
        Assert.Fail("Should have failed");
      } catch (InvalidOperationException) {
        // NOTE: Intentionally empty
      } catch (Exception ex) {
        Assert.Fail(ex.ToString());
        throw new InvalidOperationException(String.Empty, ex);
      }
      try {
        CBORObject.Undefined.AsNumber().AsEDecimal();
        Assert.Fail("Should have failed");
      } catch (InvalidOperationException) {
        // NOTE: Intentionally empty
      } catch (Exception ex) {
        Assert.Fail(ex.ToString());
        throw new InvalidOperationException(String.Empty, ex);
      }
      try {
        ToObjectTest.TestToFromObjectRoundTrip(
          String.Empty).AsNumber().AsEDecimal();
        Assert.Fail("Should have failed");
      } catch (InvalidOperationException) {
        // NOTE: Intentionally empty
      } catch (Exception ex) {
        Assert.Fail(ex.ToString());
        throw new InvalidOperationException(String.Empty, ex);
      }
    }
    [Test]
    public void TestAsEFloat() {
      {
        object objectTemp = CBORTestCommon.FloatPosInf;
        object objectTemp2 =
          ToObjectTest.TestToFromObjectRoundTrip(Single.PositiveInfinity)
                  .AsNumber().AsEFloat();
        Assert.AreEqual(objectTemp, objectTemp2);
      }
      {
        object objectTemp = CBORTestCommon.FloatNegInf;
        object objectTemp2 =
          ToObjectTest.TestToFromObjectRoundTrip(Single.NegativeInfinity)
                  .AsNumber().AsEFloat();
        Assert.AreEqual(objectTemp, objectTemp2);
      }
      Assert.IsTrue(ToObjectTest.TestToFromObjectRoundTrip(Single.NaN)
        .AsNumber().IsNaN());
      {
        object objectTemp = CBORTestCommon.FloatPosInf;
        object objectTemp2 =
          ToObjectTest.TestToFromObjectRoundTrip(Double.PositiveInfinity)
                  .AsNumber().AsEFloat();
        Assert.AreEqual(objectTemp, objectTemp2);
      }
      {
        object objectTemp = CBORTestCommon.FloatNegInf;
        object objectTemp2 =
          ToObjectTest.TestToFromObjectRoundTrip(Double.NegativeInfinity)
                  .AsNumber().AsEFloat();
        Assert.AreEqual(objectTemp, objectTemp2);
      }
      Assert.IsTrue(ToObjectTest.TestToFromObjectRoundTrip(Double.NaN)
        .AsNumber().IsNaN());
    }
    [Test]
    public void TestAsERational() {
      {
        object objectTemp = CBORTestCommon.RatPosInf;
        object objectTemp2 =
          ToObjectTest.TestToFromObjectRoundTrip(Single.PositiveInfinity)
                  .AsNumber().AsERational();
        Assert.AreEqual(objectTemp, objectTemp2);
      }
      {
        object objectTemp = CBORTestCommon.RatNegInf;
        object objectTemp2 =
          ToObjectTest.TestToFromObjectRoundTrip(Single.NegativeInfinity)
                  .AsNumber().AsERational();
        Assert.AreEqual(objectTemp, objectTemp2);
      }

      Assert.IsTrue(
        ToObjectTest.TestToFromObjectRoundTrip(
        ToObjectTest.TestToFromObjectRoundTrip(Single.NaN)
                        .AsNumber().AsERational()).AsNumber().IsNaN());
      {
        object objectTemp = CBORTestCommon.RatPosInf;
        object objectTemp2 =
          ToObjectTest.TestToFromObjectRoundTrip(Double.PositiveInfinity)
                  .AsNumber().AsERational();
        Assert.AreEqual(objectTemp, objectTemp2);
      }
      {
        object objectTemp = CBORTestCommon.RatNegInf;
        object objectTemp2 =
          ToObjectTest.TestToFromObjectRoundTrip(Double.NegativeInfinity)
                  .AsNumber().AsERational();
        Assert.AreEqual(objectTemp, objectTemp2);
      }
      Assert.IsTrue(
      ToObjectTest.TestToFromObjectRoundTrip(Double.NaN)
          .AsNumber().AsERational().IsNaN());
    }
}
}
