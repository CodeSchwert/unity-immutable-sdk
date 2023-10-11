using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;

public class UnauthenticatedSceneTests
{
    // A Test behaves as an ordinary method
    [Test]
    public void UnauthenticatedSceneTestsSimplePasses()
    {
        // Use the Assert class to test conditions

    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator UnauthenticatedSceneTestsWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }

    [Test]
    public void UnauthenticatedSceneTestsSimpleFail()
    {
        // intentionally blow up tests!
        // Assert.AreEqual(true, false);
    }

    // [Test]
    // public void UnauthenticatedSceneTestOutputText()
    // {
    //     // Arrange
    //     UnauthenticatedScript unauthenticatedScript = new UnauthenticatedScript();
    //     Text outputext = unauthenticatedScript.output;

    //     // Act
    //     // Simulate user input or trigger events that modify the output Text variable
    //     // unauthenticatedScript.Some:undefinedTundefinedthodThatUpdatesOutputText();

    //     // Assert
    //     Assert.AreEqual("Expected Value", outputText.text);
    // }
}
