using System.Collections;
using System.Collections.Generic;
using GameLogic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CardShould
{
    [Test]
    public void CardFoldsCorrectly()
    {
        var card = new Card(3);
        Assert.AreEqual(2, card.Fold().Durability);
        Assert.AreEqual(2, card.Fold().Fold().Durability);
    }

    /*// A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator CardShouldWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }*/
}
