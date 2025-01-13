using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    [Header("bullet")]
    public GameObject projectilePrefab;
    [Header("spawnpoint")]
    public GameObject spawnPoint;
    public void Shoot()
    {
        Instantiate(projectilePrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);
    }
   
}
