using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class Cell : MonoBehaviour {

     public int X { get; set; }
     public int Y { get; set; }

     Vector3 temp = new Vector3(0, 0.2f, 0);

    public  void highlight()
    {
        this.transform.position += temp;       
        Debug.Log("Cell" + " " + this.Y.ToString() + "x" + this.X.ToString() + " " + "selected");
    }

    public void unHighlight()
    {
        transform.position -= temp;
    }
}
