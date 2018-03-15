using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnScript : MonoBehaviour {

    public Player player1;
    public Player player2;
    [HideInInspector]
    public Player activePlayer;

    public Text currentPlayer;

    // Player 1 always starts
    void Start()
    {
        activePlayer = player1;      
    }
    
    
    public void endTurn()
    {
        if(activePlayer == player1)
        {
            activePlayer = player2;
            currentPlayer.text = "Player 2's turn";
            Debug.Log("Test");
        }
        else
        {
            activePlayer = player1;
            currentPlayer.text = "Player 1's turn";
        }      
    }
}
