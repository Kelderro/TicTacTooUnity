using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class NewTestScript {
  public Board board;

  // A Test behaves as an ordinary method
  [Test]
  public void NewTestScriptSimplePasses() {
    // Use the Assert class to test conditions
  }

  // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
  // `yield return null;` to skip a frame.
  [UnityTest]
  public IEnumerator NewTestScriptWithEnumeratorPasses() {

    var boardGameObject = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Board"));
    board = boardGameObject.GetComponent<Board>();

    Assert.NotNull(board);

    board.SwitchPlayer();
    // Use the Assert class to test conditions.
    // Use yield to skip a frame.
    yield return null;
  }
}
