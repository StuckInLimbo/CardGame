using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public int coins;
	// Use this for initialization
	void Start () {
        coins = 2;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 100, 20), "Coins: " + coins);
    }
}
