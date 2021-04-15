using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMangerScript : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 SpawnPos = new Vector3(25, 0, 0);
    int SpawnStart = 2;
    int SpawnInterval = 2;
    private PlayerController PlayerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        PlayerControllerScript = GameObject.Find("player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", SpawnStart, SpawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObstacle()
    {
        if (PlayerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, SpawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
