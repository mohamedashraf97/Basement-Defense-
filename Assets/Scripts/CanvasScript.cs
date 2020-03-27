using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{
    public GameObject canvas; 
    public ObjectSpawner ob;
    // Start is called before the first frame update
    void Start()
    {
       // canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(ob.spawned == true)
        {
            canvas.SetActive(true);
        }
    }
}
