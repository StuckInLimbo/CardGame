using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public int playerTurn; //pub or priv?
    public int numOfPlayers; //pub or priv?
    public int currentPlayer;
    private PlayerController pc;

    private void initPlayer(int playerNum)
    {
        pc = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    public void takeCoin(int num, int playerNum)
    {
        initPlayer(playerNum);
        pc.coins = pc.coins + num;
    }
}
