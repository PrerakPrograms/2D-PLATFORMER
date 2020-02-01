using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject barrels;
    public float spawntime;
    void Start()
    {
        StartCoroutine(BarrelWave());
    }

    private void Spawn() {
        GameObject barrell = Instantiate(barrels) as GameObject;


    }
    IEnumerator BarrelWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawntime);
            Spawn();
        }
    }
}
