using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitFactory : MonoBehaviour {

    public Unit Prototype;
    public Map Map;

    int x;
    int y;

    public System.Random rnd = new System.Random();

	public void SpawnUnit()
    {
        
        x = rnd.Next(0, 10);
        y = rnd.Next(0, 10);
        Cell cell = Map.getCell(x, y);
        if(cell.transform.childCount != 0)
        {
            Debug.Log("Cell is full");
            SpawnUnit();
        }
        else
        {
            Unit newUnit = Instantiate(Prototype);
            newUnit.transform.SetParent(cell.transform, false);
        }
        
    }
    

}
