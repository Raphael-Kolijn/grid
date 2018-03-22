using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonScript : MonoBehaviour {

    // public resource resource;
    public TurnScript turnManager;
    public int amountToAdd;

    public void addAmount()
    {
        // resource.addAmount(amountToAdd);
        turnManager.activePlayer.addAmount(amountToAdd);
    }

    public void subtractAmount()
    {
        // resource.subtractAmount(amountToAdd);
        turnManager.activePlayer.subtractAmount(amountToAdd);
    }
}
