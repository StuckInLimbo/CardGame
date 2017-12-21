using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Code used from Sloan Kelly's tut series on card games, credit to him
public class DebugDealer : MonoBehaviour {

    public CardStack dealer;
    public CardStack player;

    private void OnGUI()
    {
        if (GUI.Button(new Rect(10,10,256,28), "Push me"))
        {
            player.Push(dealer.Pop());
        }
    }
}
