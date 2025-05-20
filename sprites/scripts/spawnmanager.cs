using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanager : MonoBehaviour
{
    public GameObject rock,burger;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRocks());
        StartCoroutine(Spawnburger());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator SpawnRocks()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(3f, 8f));
            Vector3 pos = new Vector3(Random.Range(12f, 14.5f),-3.8f, 0f);
            Instantiate(rock, pos, Quaternion.identity);
        }
    }
    IEnumerator Spawnburger()
    {
        while (true) 
        {
            yield return new WaitForSeconds(Random.Range(6f, 10f));
            Vector3 pos = new Vector3(Random.Range(12f, 14.5f), Random.Range(0f, -2.0f) , 0f);
            Instantiate(burger, pos, Quaternion.identity);
        }
    }
}
