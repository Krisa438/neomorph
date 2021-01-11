using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienOgon : MonoBehaviour
{
    public GameObject ogonognemet;
    public GameObject ogonalien;
    void Start()
    {
        ogonalien.SetActive(false);
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == ogonognemet)
        {
            ogonalien.SetActive(true);
        }
    }
    
}
