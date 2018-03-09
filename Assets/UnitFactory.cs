using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitFactory : MonoBehaviour {

    public Unit Prototype;
    public Map Map;

    public int x;
    public int y;

	public void SpawnUnit()
    {
        Unit newUnit = Instantiate(Prototype);
        Cell cell = Map.getCell(x, y);

        newUnit.transform.SetParent(cell.transform, false);
    }
    

}
