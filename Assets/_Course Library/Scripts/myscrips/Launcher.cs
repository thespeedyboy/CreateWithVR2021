using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public TVCanvascontrol tvControl;
    public GameObject projectilePrefab;
    public GameObject spawnPoint;
    public void Shoot()
    {
        Instantiate(projectilePrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);
        tvControl.AddToScore();
    }
   
}
