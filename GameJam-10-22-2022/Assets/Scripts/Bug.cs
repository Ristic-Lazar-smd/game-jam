using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : MonoBehaviour
{
    public GameObject bug;
    private GameObject newBug;
    private float randomXposition, randomYposition;
    private Vector3 spawnPosition;
    private float spawnTime;
    private bool bugSpawn = true;

    // Start is called before the first frame update
    void Start()
    {
        //while(bugSpawn == true)
        //{
        //    spawnTime = Random.Range(1, 2);
        //    StartCoroutine(ExampleCoroutine());
        //}
    }

    // Update is called once per frame
    void Update()
    {

        

    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(spawnTime);
        randomXposition = Random.Range(-8f, 8f);
        randomYposition = Random.Range(-4f, 4f);
        spawnPosition = new Vector3(randomXposition, randomYposition, 0f);
        newBug = Instantiate(bug, spawnPosition, Quaternion.identity);
        Debug.Log("AAAAAAAA");
    }
}
