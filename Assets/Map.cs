using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

    public int SizeX;
    public int SizeY;

    public float TileOffset;

    public Cell Prototype;

    // public List<Cell> cells;

    public void Start()
    {
        Spawn();
    }

    public void Spawn()
    {
        float xOffset = 0;
        for (int x = 0; x < SizeX; x++)
        {
            float yOffset = 0;
            for (int y = 0; y < SizeY; y++)
            {
                Cell newTile = Instantiate(Prototype);
                newTile.transform.SetParent(transform);
                newTile.transform.localPosition = new Vector3(xOffset, 0, yOffset);
                newTile.name = string.Format("Cell {0}x{1}", x, y);
                // newTile.name = "Cell "+ x + "x" + y;
                newTile.X = x;
                newTile.Y = y;

                yOffset += TileOffset;
            }
            xOffset += TileOffset;
        }
    }

    public Cell getCell(int x, int y)
    {
        if(x >= SizeX || y >= SizeY)
        {
            Debug.LogError("Out of bounds");
            return null;
        }
        return transform.GetChild((x * SizeY)+ y).GetComponent<Cell>();
    }
}
