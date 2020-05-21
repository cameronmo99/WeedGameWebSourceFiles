using UnityEngine;
using System.Collections;

public class DestroyLane : MonoBehaviour
{
    void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.CompareTag("Lane") || obj.gameObject.CompareTag("Coin") || obj.gameObject.CompareTag("Environment") || obj.gameObject.CompareTag("Obstacle") || obj.gameObject.CompareTag("Enemy High") || obj.gameObject.CompareTag("Teleporter") || obj.gameObject.CompareTag("Stopper") || obj.gameObject.CompareTag("Teleporter Low") || obj.gameObject.CompareTag("Stopper Low") || obj.gameObject.CompareTag("Ramp") || obj.gameObject.CompareTag("Enemy Medium") || obj.gameObject.CompareTag("Enemy Low"))
        {
            Destroy(obj.gameObject);
            //Destroy game objects when passed over
            //test
        }
    }
}
