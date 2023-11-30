using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody rb;
    [SerializeField] private float speed;
    private Vector3 moveDir;
    private bool switchDir;
    private bool started = false;

    private bool isGrounded;
    private float depth;
    [SerializeField] private LayerMask groundLayer;

    private Transform player;

    private void Awake()
    {
        InputController.Init(this);
        InputController.GameEnable();
        rb = GetComponent<Rigidbody>();
        depth = GetComponent<Collider>().bounds.size.y;

        player = GetComponent<Transform>();
        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, depth, groundLayer);
        Debug.Log(isGrounded);
        if(player.position.y < 0)
        {
            Debug.Log("die");
        }
    }

    private void FixedUpdate()
    {
        if (!started) return;
        if (!isGrounded)
        {
            rb.useGravity = true;
            return;
        }
        rb.AddForce( moveDir * speed, ForceMode.Force);
        
       
    }

    public void SetMoveDir()
    {
        Debug.Log("Called");
        if (!started)
        {
            started = true;
           
        }
        if (!isGrounded) return;
        rb.velocity = (Vector3.zero);
        if(!switchDir)
        {
            Debug.Log("Z axis");
            switchDir = !switchDir;
            moveDir = new Vector3(0, 0, 1);
            return;
        }
        else
        {
            Debug.Log("X axis");
            switchDir = !switchDir;
            moveDir = new Vector3 (1, 0, 0);
        }
    }
}
