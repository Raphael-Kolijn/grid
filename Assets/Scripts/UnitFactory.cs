using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitFactory : MonoBehaviour {

    public Unit Prototype;
    public Map Map;

    public selectScript select;

    //int x;
    //int y;

    public TurnScript turnManager;

    public System.Random rnd = new System.Random();

	public void SpawnUnit()
    {
        
        //x = rnd.Next(0, 10);
        //y = rnd.Next(0, 10);
        Cell cell = Map.getCell(select.tmpCell.X, select.tmpCell.Y);
        if(cell.transform.childCount != 0)
        {
            Debug.Log("Cell is full");
            
        }
        else
        {
            Unit newUnit = Instantiate(Prototype);
            newUnit.transform.SetParent(cell.transform, false);
            turnManager.activePlayer.subtractAmount(Prototype.cost);
        }    
    } 
}
