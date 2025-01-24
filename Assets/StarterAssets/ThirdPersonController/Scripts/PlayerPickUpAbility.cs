using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUpAbility : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<IPowerUps>(out IPowerUps pickUpPowerUp))
        {
            pickUpPowerUp.PickUpPowerUp(this.gameObject);
            Destroy(other.gameObject);
        }
    }
}
