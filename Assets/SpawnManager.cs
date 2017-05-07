using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnManager : MonoBehaviour
{
    public GameObject morty;
    public List<GameObject> spawnpoints;
    public int spawnFreq;
    bool spawning;
    float timer;

	void Update ()
    {
        timer = Time.deltaTime;

        if((int)timer % spawnFreq == 0 && !spawning)
        {
            spawning = true;
            int randomSpawn = Random.Range(0, spawnpoints.Count);
            Instantiate(morty, spawnpoints[randomSpawn].transform.position, spawnpoints[randomSpawn].transform.rotation);
            StartCoroutine(WaitForTimer());
        }
	}

    IEnumerator WaitForTimer()
    {
        yield return new WaitForSeconds(1);
        spawning = false;
    }
}
