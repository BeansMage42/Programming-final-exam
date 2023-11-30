using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Transform playerPos;
    private Vector3 offset;

    private void Awake()
    {
        offset = gameObject.transform.position;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerPos.position.y > 0)
        {
            gameObject.transform.position = playerPos.position + offset;
        }
        
    }
}
