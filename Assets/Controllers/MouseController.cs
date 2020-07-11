﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseController : MonoBehaviour
{
    public Vector3 worldPosition;
    public Plane plane;
    public GameObject TileIndicator;

    private TargettedTileController tileIndicatorScript;
    void Update() {

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit)) {
            worldPosition = hit.point;

            Debug.Log(worldPosition);
        }

        if (Input.GetMouseButtonDown(0)) {
            moveTileAim();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        tileIndicatorScript = TileIndicator.GetComponent<TargettedTileController>();
    }

    private void moveTileAim() {

        Vector3 targetPos = new Vector3(Mathf.RoundToInt(worldPosition.x), 0f, Mathf.RoundToInt(worldPosition.z));
        //Debug.Log("Target:" + targetPos);
        tileIndicatorScript.changeRandomPos();
        //tileIndicatorScript.changePos(targetPos);

    }
 
}
