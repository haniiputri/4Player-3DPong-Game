using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControl : MonoBehaviour
{
    public string spawnPointTag;

    public int maxPowerUpAmount;

    public int spawnInterval;

    private float timer;

    public List<GameObject> prefabsToSpawn;

    private void Start()
    {
        timer = 0;
    }

    void Update()
    {
        GameObject[] spawnPoints = GameObject.FindGameObjectsWithTag(spawnPointTag);

        timer += Time.deltaTime;

        if (timer > spawnInterval)
        {
            foreach (GameObject spawnPoint in spawnPoints)
            {
                int randomPrefab = Random.Range(0, prefabsToSpawn.Count);

                int spawnOrNot = Random.Range(0, 2);
                if (spawnOrNot == 0)
                {
                    GameObject pts = Instantiate(prefabsToSpawn[randomPrefab]);
                    pts.transform.position = spawnPoint.transform.position;
                }
                timer -= spawnInterval;
            }
        }
    }

}
