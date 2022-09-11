using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRandPlatform : MonoBehaviour
{

    public GameObject platformPrefab;
    public Transform map;

    public float minDisBetweenPillars;
    public float spawnRange;
    public float spawnRangeY;
    public int totPillars;

    private void Start()
    {
        SpawnPillars();
    }

    private bool CanSpawn(float min, Vector3 a, Vector3 b)
    {
        bool res = Vector3.Distance(a, b) >= min;
        return res == true;
    }

    private void SpawnPillars()
    {
        for (int i = 0; i < totPillars; i++)
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRange, spawnRange), -30, Random.Range(-spawnRange, spawnRange));
            GameObject[] pillars = GameObject.FindGameObjectsWithTag("platform");

            bool canSpawn = false;
            foreach (GameObject pillar in pillars)
            {
                Vector3 pillarPos = pillar.transform.position;

                if (CanSpawn(minDisBetweenPillars, spawnPos, pillarPos) == true)
                {
                    canSpawn = true;
                    break;
                }
            }

            if (canSpawn == true)
            {
                spawnPos.y = -30 + Random.Range(-spawnRangeY, spawnRangeY);
                Instantiate(platformPrefab, spawnPos, Quaternion.identity, map);
            }
            else
            {
                i--;
            }
        }
    }

}
