using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectScript : MonoBehaviour {

    [HideInInspector]
    public Cell tmpCell;
    

    // Use this for initialization
    void Start () {
        tmpCell = new Cell();
        
	}

    // Update is called once per frame
    void Update() {
        {
            if (Input.GetMouseButtonDown(0))
            {
                // Debug.Log("Mouse is down");

                RaycastHit hitInfo = new RaycastHit();
                bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
                if (hit)
                {
                    
                    Debug.Log("Hit " + hitInfo.transform.gameObject.name);
                    if (hitInfo.transform.gameObject.tag == "Cell")
                    {
                        tmpCell = hitInfo.transform.GetComponent<Cell>();
                        tmpCell.highlight();
                        
                    }
                    else {
                       
                    }
                }
                else {
                    Debug.Log("No hit");
                }
                
            }
        }

        
    }
}
