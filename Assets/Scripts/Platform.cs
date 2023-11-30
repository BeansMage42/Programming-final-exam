using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Transform player;
    private Rigidbody rb;
    private bool usingGravity = false;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.position.y < 0 && !usingGravity )
        {
            usingGravity = true;
            StartCoroutine("FallDelay");
            StartCoroutine("DestroyPlatform");
        }
    }

    public IEnumerator FallDelay()
    {
        yield return new WaitForSeconds(0.5f);
        rb.useGravity = true;
    }
    public IEnumerator DestroyPlatform()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
