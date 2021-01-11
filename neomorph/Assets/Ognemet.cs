using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ognemet : MonoBehaviour
{
    public GameObject Ogon;
    // Start is called before the first frame update
    void Start()
    {
        Ogon.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ogon.SetActive(true);
        }
        if (Input.GetMouseButtonUp(0))
        {
            Ogon.SetActive(false);
        }
    }
}
