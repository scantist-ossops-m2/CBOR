package com.upokecenter.test;

import java.io.*;

import org.junit.Assert;
import org.junit.Test;
import com.upokecenter.util.*;

  public class DataUtilitiesTest {
    @Test
    public void TestCodePointAt() {
      // not implemented yet
    }
    @Test
    public void TestCodePointBefore() {
      // not implemented yet
    }
    @Test
    public void TestCodePointCompare() {
      // not implemented yet
    }
    @Test
    public void TestGetUtf8Bytes() {
      try {
        DataUtilities.GetUtf8Bytes(null, true);
        Assert.fail("Should have failed");
      } catch (NullPointerException ex) {
      } catch (Exception ex) {
        Assert.fail(ex.toString());
        throw new IllegalStateException("", ex);
      }
    }
    @Test
    public void TestGetUtf8Length() {
      try {
        DataUtilities.GetUtf8Length(null, true);
        Assert.fail("Should have failed");
      } catch (NullPointerException ex) {
      } catch (Exception ex) {
        Assert.fail(ex.toString());
        throw new IllegalStateException("", ex);
      }
      Assert.assertEquals(6, DataUtilities.GetUtf8Length("ABC\ud800", true));
      Assert.assertEquals(-1, DataUtilities.GetUtf8Length("ABC\ud800", false));
    }
    @Test
    public void TestGetUtf8String() {
      try {
        DataUtilities.GetUtf8String(null, 0, 1, true);
        Assert.fail("Should have failed");
      } catch (NullPointerException ex) {
      } catch (Exception ex) {
        Assert.fail(ex.toString());
        throw new IllegalStateException("", ex);
      }
      try {
        DataUtilities.GetUtf8String(new byte[] {  0  }, -1, 1, true);
        Assert.fail("Should have failed");
      } catch (IllegalArgumentException ex) {
      } catch (Exception ex) {
        Assert.fail(ex.toString());
        throw new IllegalStateException("", ex);
      }
      try {
        DataUtilities.GetUtf8String(new byte[] {  0  }, 2, 1, true);
        Assert.fail("Should have failed");
      } catch (IllegalArgumentException ex) {
      } catch (Exception ex) {
        Assert.fail(ex.toString());
        throw new IllegalStateException("", ex);
      }
      try {
        DataUtilities.GetUtf8String(new byte[] {  0  }, 0, -1, true);
        Assert.fail("Should have failed");
      } catch (IllegalArgumentException ex) {
      } catch (Exception ex) {
        Assert.fail(ex.toString());
        throw new IllegalStateException("", ex);
      }
      try {
        DataUtilities.GetUtf8String(new byte[] {  0  }, 0, 2, true);
        Assert.fail("Should have failed");
      } catch (IllegalArgumentException ex) {
      } catch (Exception ex) {
        Assert.fail(ex.toString());
        throw new IllegalStateException("", ex);
      }
      try {
        DataUtilities.GetUtf8String(new byte[] {  0  }, 1, 1, true);
        Assert.fail("Should have failed");
      } catch (IllegalArgumentException ex) {
      } catch (Exception ex) {
        Assert.fail(ex.toString());
        throw new IllegalStateException("", ex);
      }
      Assert.assertEquals(
        "ABC",
        DataUtilities.GetUtf8String(new byte[] {  0x41, 0x42, 0x43  }, 0, 3, true));
      Assert.assertEquals(
        "ABC\ufffd",
        DataUtilities.GetUtf8String(new byte[] {  0x41, 0x42, 0x43, (byte)0x80  }, 0, 4, true));
      try {
        DataUtilities.GetUtf8String(new byte[] {  0x41, 0x42, 0x43, (byte)0x80  }, 0, 4, false);
        Assert.fail("Should have failed");
      } catch (IllegalArgumentException ex) {
      } catch (Exception ex) {
        Assert.fail(ex.toString());
        throw new IllegalStateException("", ex);
      }
    }
    @Test
    public void TestReadUtf8() {
      try {
        DataUtilities.ReadUtf8(null, 1, null, true);
        Assert.fail("Should have failed");
      } catch (NullPointerException ex) {
      } catch (Exception ex) {
        Assert.fail(ex.toString());
        throw new IllegalStateException("", ex);
      }
    }
    @Test
    public void TestReadUtf8FromBytes() {
      try {
        DataUtilities.WriteUtf8("x", 0, 1, null, true);
        Assert.fail("Should have failed");
      } catch (NullPointerException ex) {
      } catch (Exception ex) {
        Assert.fail(ex.toString());
        throw new IllegalStateException("", ex);
      }
      try {
        DataUtilities.ReadUtf8FromBytes(null, 0, 1, new StringBuilder(), true);
        Assert.fail("Should have failed");
      } catch (NullPointerException ex) {
      } catch (Exception ex) {
        Assert.fail(ex.toString());
        throw new IllegalStateException("", ex);
      }
      try {
        DataUtilities.ReadUtf8FromBytes(new byte[] {  0  }, -1, 1, new StringBuilder(), true);
        Assert.fail("Should have failed");
      } catch (IllegalArgumentException ex) {
      } catch (Exception ex) {
        Assert.fail(ex.toString());
        throw new IllegalStateException("", ex);
      }
      try {
        DataUtilities.ReadUtf8FromBytes(new byte[] {  0  }, 2, 1, new StringBuilder(), true);
        Assert.fail("Should have failed");
      } catch (IllegalArgumentException ex) {
      } catch (Exception ex) {
        Assert.fail(ex.toString());
        throw new IllegalStateException("", ex);
      }
      try {
        DataUtilities.ReadUtf8FromBytes(new byte[] {  0  }, 0, -1, new StringBuilder(), true);
        Assert.fail("Should have failed");
      } catch (IllegalArgumentException ex) {
      } catch (Exception ex) {
        Assert.fail(ex.toString());
        throw new IllegalStateException("", ex);
      }
      try {
        DataUtilities.ReadUtf8FromBytes(new byte[] {  0  }, 0, 2, new StringBuilder(), true);
        Assert.fail("Should have failed");
      } catch (IllegalArgumentException ex) {
      } catch (Exception ex) {
        Assert.fail(ex.toString());
        throw new IllegalStateException("", ex);
      }
      try {
        DataUtilities.ReadUtf8FromBytes(new byte[] {  0  }, 1, 1, new StringBuilder(), true);
        Assert.fail("Should have failed");
      } catch (IllegalArgumentException ex) {
      } catch (Exception ex) {
        Assert.fail(ex.toString());
        throw new IllegalStateException("", ex);
      }
    }
    @Test
    public void TestReadUtf8ToString() {
      try {
        DataUtilities.ReadUtf8ToString(null);
        Assert.fail("Should have failed");
      } catch (NullPointerException ex) {
      } catch (Exception ex) {
        Assert.fail(ex.toString());
        throw new IllegalStateException("", ex);
      }
      try {
        DataUtilities.ReadUtf8ToString(null, 1, true);
        Assert.fail("Should have failed");
      } catch (NullPointerException ex) {
      } catch (Exception ex) {
        Assert.fail(ex.toString());
        throw new IllegalStateException("", ex);
      }
    }
    @Test
    public void TestToLowerCaseAscii() {
      if((DataUtilities.ToLowerCaseAscii(null))!=null)Assert.fail();
      Assert.assertEquals("abc012-=?", DataUtilities.ToLowerCaseAscii("abc012-=?"));
      Assert.assertEquals("abc012-=?", DataUtilities.ToLowerCaseAscii("ABC012-=?"));
    }
    @Test
    public void TestWriteUtf8() {
      try {
        java.io.ByteArrayOutputStream ms=null;
try {
ms=new java.io.ByteArrayOutputStream();

          try {
            DataUtilities.WriteUtf8("x", null, true);
            Assert.fail("Should have failed");
          } catch (NullPointerException ex) {
          } catch (Exception ex) {
            Assert.fail(ex.toString());
            throw new IllegalStateException("", ex);
          }
          try {
            DataUtilities.WriteUtf8("x", 0, 1, null, true);
            Assert.fail("Should have failed");
          } catch (NullPointerException ex) {
          } catch (Exception ex) {
            Assert.fail(ex.toString());
            throw new IllegalStateException("", ex);
          }
          try {
            DataUtilities.WriteUtf8("x", 0, 1, null, true, true);
            Assert.fail("Should have failed");
          } catch (NullPointerException ex) {
          } catch (Exception ex) {
            Assert.fail(ex.toString());
            throw new IllegalStateException("", ex);
          }
          try {
            DataUtilities.WriteUtf8(null, 0, 1, ms, true);
            Assert.fail("Should have failed");
          } catch (NullPointerException ex) {
          } catch (Exception ex) {
            Assert.fail(ex.toString());
            throw new IllegalStateException("", ex);
          }
          try {
            DataUtilities.WriteUtf8("x", -1, 1, ms, true);
            Assert.fail("Should have failed");
          } catch (IllegalArgumentException ex) {
          } catch (Exception ex) {
            Assert.fail(ex.toString());
            throw new IllegalStateException("", ex);
          }
          try {
            DataUtilities.WriteUtf8("x", 2, 1, ms, true);
            Assert.fail("Should have failed");
          } catch (IllegalArgumentException ex) {
          } catch (Exception ex) {
            Assert.fail(ex.toString());
            throw new IllegalStateException("", ex);
          }
          try {
            DataUtilities.WriteUtf8("x", 0, -1, ms, true);
            Assert.fail("Should have failed");
          } catch (IllegalArgumentException ex) {
          } catch (Exception ex) {
            Assert.fail(ex.toString());
            throw new IllegalStateException("", ex);
          }
          try {
            DataUtilities.WriteUtf8("x", 0, 2, ms, true);
            Assert.fail("Should have failed");
          } catch (IllegalArgumentException ex) {
          } catch (Exception ex) {
            Assert.fail(ex.toString());
            throw new IllegalStateException("", ex);
          }
          try {
            DataUtilities.WriteUtf8("x", 1, 1, ms, true);
            Assert.fail("Should have failed");
          } catch (IllegalArgumentException ex) {
          } catch (Exception ex) {
            Assert.fail(ex.toString());
            throw new IllegalStateException("", ex);
          }
          try {
            DataUtilities.WriteUtf8(null, 0, 1, ms, true, true);
            Assert.fail("Should have failed");
          } catch (NullPointerException ex) {
          } catch (Exception ex) {
            Assert.fail(ex.toString());
            throw new IllegalStateException("", ex);
          }
          try {
            DataUtilities.WriteUtf8("x", -1, 1, ms, true, true);
            Assert.fail("Should have failed");
          } catch (IllegalArgumentException ex) {
          } catch (Exception ex) {
            Assert.fail(ex.toString());
            throw new IllegalStateException("", ex);
          }
          try {
            DataUtilities.WriteUtf8("x", 2, 1, ms, true, true);
            Assert.fail("Should have failed");
          } catch (IllegalArgumentException ex) {
          } catch (Exception ex) {
            Assert.fail(ex.toString());
            throw new IllegalStateException("", ex);
          }
          try {
            DataUtilities.WriteUtf8("x", 0, -1, ms, true, true);
            Assert.fail("Should have failed");
          } catch (IllegalArgumentException ex) {
          } catch (Exception ex) {
            Assert.fail(ex.toString());
            throw new IllegalStateException("", ex);
          }
          try {
            DataUtilities.WriteUtf8("x", 0, 2, ms, true, true);
            Assert.fail("Should have failed");
          } catch (IllegalArgumentException ex) {
          } catch (Exception ex) {
            Assert.fail(ex.toString());
            throw new IllegalStateException("", ex);
          }
          try {
            DataUtilities.WriteUtf8("x", 1, 1, ms, true, true);
            Assert.fail("Should have failed");
          } catch (IllegalArgumentException ex) {
          } catch (Exception ex) {
            Assert.fail(ex.toString());
            throw new IllegalStateException("", ex);
          }
}
finally {
try { if(ms!=null)ms.close(); } catch (java.io.IOException ex){}
}
      } catch (Exception ex) {
        throw new IllegalStateException(ex.getMessage(), ex);
      }
    }
  }
