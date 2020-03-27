﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;


public class PlacementIndicator : MonoBehaviour
{
    private ARRaycastManager rayManager;
    public GameObject visual;
    public ObjectSpawner ob;


    void Start()
    {
        rayManager = FindObjectOfType<ARRaycastManager>();
        visual = transform.GetChild(0).gameObject;
        visual.SetActive(false);
    }


    void Update()
    {
        if (ob.spawned == false)
        {
            // shoot a raycast from the center 
            List<ARRaycastHit> hits = new List<ARRaycastHit>();
            rayManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, TrackableType.Planes);

            //if we hit ar plane , update position and rotation 
            if (hits.Count > 0)
            {
                transform.position = hits[0].pose.position;
                transform.rotation = hits[0].pose.rotation;

                if (visual.activeInHierarchy)
                {
                    visual.SetActive(true);
                }

            }
        }
        else
        {
            visual.SetActive(false);
        }

    }

}