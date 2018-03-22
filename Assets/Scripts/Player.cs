using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public resource resource;
    public int amountToAdd;
    

    public void addAmount(int amountToAdd)
    {
        resource.addAmount(amountToAdd);
    }

    public void subtractAmount(int amountToAdd)
    {
        resource.subtractAmount(amountToAdd);
    }

}
