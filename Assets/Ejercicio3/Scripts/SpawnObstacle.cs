using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    public GameObject fence;
    public GameObject hole;
    public GameObject rupia;

    public float randomRange = 7f;

    void Start()
    {
        InvokeRepeating("Fence", 2, 5);
        InvokeRepeating("Hole", 4, 7);
        InvokeRepeating("Rupia", 0, 4);
    }

    public void Fence()
    {
        Vector3 spawnPositionFence = new Vector3();

        spawnPositionFence.x = Random.Range(randomRange, -randomRange);
        spawnPositionFence.y = transform.position.y;
        spawnPositionFence.z = transform.position.z;

        Instantiate(fence, spawnPositionFence, Quaternion.identity);
    }

    public void Hole()
    {
        Vector3 spawnPositionHole = new Vector3();

        spawnPositionHole.x = Random.Range(randomRange, -randomRange);
        spawnPositionHole.y = transform.position.y;
        spawnPositionHole.z = transform.position.z;

        Instantiate(hole, spawnPositionHole, Quaternion.identity);
    }

    public void Rupia()
    {
        Vector3 spawnPositionRupia = new Vector3();

        spawnPositionRupia.x = Random.Range(randomRange, -randomRange);
        spawnPositionRupia.y = transform.position.y;
        spawnPositionRupia.z = transform.position.z;

        Instantiate(rupia, spawnPositionRupia, Quaternion.identity);
    }

}
