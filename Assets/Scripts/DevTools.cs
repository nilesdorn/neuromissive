using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevTools : MonoBehaviour
{
    [SerializeField]
    GameObject cam1;
    [SerializeField]
    GameObject cam2;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchCamera()
    {
        if (cam1.activeSelf == true)
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
        else
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
        }
    }
}
