using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpAmmo : MonoBehaviour, IPowerUps
{
    public void PickUpPowerUp(GameObject other)
    {
        Debug.Log("Recoger municion");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
