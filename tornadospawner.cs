using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tornadospawner : MonoBehaviour
{

    public GameObject Enemy;
    public Transform[] EnemySpawnerPosition;
    private int _randomSpawnPoints;
    public float RepeatRate = 3f;
    public int DestroySpawner = 20;



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            InvokeRepeating("EnemySpawner", 1f, RepeatRate);
            Destroy(gameObject, DestroySpawner);
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        
        }
    
    }

    private void EcnySpawner()
    {
        _randomSpawnPoints = Random.Range(0, EnemySpawnerPosition.Length);
        Instantiate(Enemy, EnemySpawnerPosition[_randomSpawnPoints].position,Quaternion.identity);
    
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
