using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnShot : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
