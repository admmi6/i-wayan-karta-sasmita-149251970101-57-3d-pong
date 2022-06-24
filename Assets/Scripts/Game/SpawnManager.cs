using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<GameObject> ballList;
    public List<GameObject> ballTemplateList;

    private GameObject ballClone;

    public Transform spawnArea;
    public int maxSpawn;
    public float forceSpeed;
    public float spawnInterval;
    private float spawnTimer;

    public List<GameObject> spawnPoint;
    public GameObject selectedSpawnPoint;

    public List<GameObject> loseCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer > spawnInterval)
        {
            GenerateSpawnBall();
            spawnTimer -= spawnInterval;
        }
    }

    public void GenerateSpawnBall()
    {
        if(loseCount.Count >= 3)
        {
            return;
        }

        if(ballList.Count >= maxSpawn)
        {
            return;
        }

        int randomIndex = Random.Range(0, ballTemplateList.Count);
        int randomPoint = Random.Range(0, spawnPoint.Count);
        selectedSpawnPoint = spawnPoint[randomPoint];
        ballClone = Instantiate(ballTemplateList[randomIndex], selectedSpawnPoint.transform.position, Quaternion.identity, spawnArea);

        ballClone.SetActive(true);

        ballClone.GetComponent<Rigidbody>().AddForce(selectedSpawnPoint.transform.forward * forceSpeed, ForceMode.Impulse);

        ballList.Add(ballClone);
    }

    public void RemoveOutSpawnBall(GameObject ballClone)
    {
        ballList.Remove(ballClone);
        Destroy(ballClone);
    }

    public void RemoveAllSpawnBall()
    {
        while(ballList.Count > 0)
        {
            RemoveOutSpawnBall(ballList[0]);
        }
    }

    
}
