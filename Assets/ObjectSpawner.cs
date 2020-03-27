using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    private PlacementIndicator placementIndicator ;

    void Start()
    {
        placementIndicator = FindObjectOfType<PlacementIndicator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Instantiate(objectToSpawn, placementIndicator.transform.position, placementIndicator.transform.rotation);
        }
    }
}
