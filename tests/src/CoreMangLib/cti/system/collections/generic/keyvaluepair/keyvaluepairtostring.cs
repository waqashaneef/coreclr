using System;
using System.Collections.Generic;
/// <summary>
///ToString
/// </summary>
public class KeyValuePairToString
{
    public static int Main()
    {
        KeyValuePairToString KeyValuePairToString = new KeyValuePairToString();

        TestLibrary.TestFramework.BeginTestCase("KeyValuePairToString");
        if (KeyValuePairToString.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }
    public bool RunTests()
    {
        bool retVal = true;
        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        retVal = PosTest2() && retVal;
        retVal = PosTest3() && retVal;
        retVal = PosTest4() && retVal;
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest1()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest1: Create a new instance of KeyValuePair.key is string and value is int");
        try
        {
            string ExpectValue1 = "HELLO";
            int ExpectValue2 = 1;
            KeyValuePair<string, int> myKeValuePair = new KeyValuePair<string, int>(ExpectValue1, ExpectValue2);
            string expectValue = "[HELLO, 1]";
            string actualValue=myKeValuePair.ToString();
            if (actualValue != expectValue)
            {
                TestLibrary.TestFramework.LogError("001.1", "calling tostring method  should return " + expectValue);
                retVal = false;
            }
           
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.0", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest2()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest2: Create a new instance of KeyValuePair.key is string and value is int");
        try
        {
            string ExpectValue1 = "HELLO";
            int ExpectValue2 = 1;
            KeyValuePair<int, string> myKeValuePair = new KeyValuePair<int, string>(ExpectValue2, ExpectValue1);
            string expectValue = "[1, HELLO]";
            string actualValue = myKeValuePair.ToString();
            if (actualValue != expectValue)
            {
                TestLibrary.TestFramework.LogError("002.1", "calling tostring method  should return " + expectValue);
                retVal = false;
            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002.0", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest3()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest3: Create a new instance of KeyValuePair,key is 0 and value is null.");
        try
        {
            KeyValuePair<int, string> myKeValuePair = new KeyValuePair<int, string>();
            string expectValue = "[0, ]";
            string actualValue = myKeValuePair.ToString();
            if (expectValue != actualValue)
            {
                TestLibrary.TestFramework.LogError("003.1", "the key of KeyValuePair should return " + actualValue);
                retVal = false;
            }
           
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("003.0", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }


    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest4()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest4: Create a new instance of KeyValuePair,key is null and value is 0.");
        try
        {
            KeyValuePair<string, int> myKeValuePair = new KeyValuePair<string, int>();
            string expectValue = "[, 0]";
            string actualValue = myKeValuePair.ToString();
            if (expectValue != actualValue)
            {
                TestLibrary.TestFramework.LogError("004.1", "the key of KeyValuePair should return " + actualValue);
                retVal = false;
            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("004.0", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
}
