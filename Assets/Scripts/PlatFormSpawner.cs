using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatFormSpawner : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject platformPrefab;
    [SerializeField]private GameObject gemPrefab;
    private int prefabNum = 0;
    private Vector3 nextPos;
    private Vector3 lastPos;
    void Start()
    {
        lastPos = transform.position;
        //startGame();
    }

    public void startGame()
    {
        Spawn();
    }

    public IEnumerator SpawnDelay()
    {
        yield return new WaitForSeconds(0.2f);
        Spawn();
    }

    private void Spawn()
    {
        int random = Random.Range(0, 2);
        if(random == 0)
        {
            var xOffset = new Vector3(2, 0, 0);
            nextPos = lastPos + xOffset;
        }
        else
        {
            var zOffset = new Vector3(0,0,2);
            nextPos = lastPos + zOffset;
        }

        Instantiate(platformPrefab, nextPos, Quaternion.identity);

        int spawnGem = Random.Range(0, 2);

        if(spawnGem == 0)
        {
            var gemPos = nextPos + Vector3.up;
            Instantiate(gemPrefab, gemPos, new Quaternion(-89,0,0,0));
        }
        lastPos = nextPos;
        prefabNum++;
        
        if (prefabNum >= 20) return;

        StartCoroutine("SpawnDelay");
        
    }

    
}
