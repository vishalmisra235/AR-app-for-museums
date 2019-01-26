using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomScript : MonoBehaviour {

    public  Canvas canvas;
	
	void Update () {
        if (Input.touchCount == 1)
        {
            GetComponent<RectTransform>().localScale = new Vector3(2f, 2f, 2f);
        }
    }
}
