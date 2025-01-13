using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsProjectile : MonoBehaviour
{
    private Rigidbody rb;
    public float shootforce;
    public float duration;
  
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //Adding Force
        rb.AddRelativeForce(Vector3.forward * shootforce, ForceMode.Impulse);
        //Destroying the projectile after a set time.
        Destroy(gameObject, duration);
    }
}
