using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewScript : MonoBehaviour {

    public Text amount;
    //int resourceAmount; 
    //public resource resource;
    public TurnScript turnManager;

	// Use this for initialization
	void Start () {
        //resourceAmount = resource.amount;
        //amount.text = resourceAmount.ToString();
        //amount.text = turnManager.activePlayer.resource.ToString();
		
	}
	
	// Update is called once per frame
	void Update () {
        //resourceAmount = resource.amount;
        //amount.text = resource.name +  resourceAmount.ToString();
        amount.text = turnManager.activePlayer.resource.amount.ToString();
    }
}
