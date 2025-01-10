using System.Runtime.CompilerServices;
using UnityEngine;

/// <summary>
/// Apply forward force to instantiated prefab
/// </summary>
public class LaunchProjectile : MonoBehaviour
{
    [Tooltip("The projectile that's created")]
    public GameObject projectilePrefab = null;
    [Tooltip("The point that the project is created")]
    public Transform startPoint = null;

    [Tooltip("The speed at which the projectile is launched")]
    public float launchSpeed = 6.0f;
    public bool canShoot = false;
    private AudioSource audiosource;
    public AudioClip dryfire;
    public AudioClip fire;
    public void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }
    public void Fire()
    {
        if (canShoot == true)
        {
            GameObject newObject = Instantiate(projectilePrefab, startPoint.position, startPoint.rotation);

            if (newObject.TryGetComponent(out Rigidbody rigidBody))
                ApplyForce(rigidBody);
            audiosource.PlayOneShot(fire);
        }
        if (canShoot == false)
        {
            audiosource.PlayOneShot(dryfire);
        }
    }

    private void ApplyForce(Rigidbody rigidBody)
    {
        Vector3 force = startPoint.forward * launchSpeed;
        rigidBody.AddForce(force);
    }
    public void EnableShooting()
    {
        canShoot = true;
    }
    public void DisableShooting()
    {
        canShoot = false;
    }
}
