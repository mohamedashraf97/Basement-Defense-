using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class Attack : MonoBehaviour
{
    public Button fireButton;
    public GameObject bullet;
    public GameObject arCamera;

    // Start is called before the first frame update
    void Start()
    {
        fireButton = GetComponent<Button>();
        fireButton.onClick.AddListener(OnButtonDown);
    }

    public void OnButtonDown()
    {
        Instantiate(bullet, arCamera.transform.position, arCamera.transform.rotation);
    
    }
}
