using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doJumpRigidBody2D : MonoBehaviour
{
    public player player;
    public float vetory = 1;
    //Gravity
    public float gravityScale = 1;

    private Rigidbody2D playerRigidbody2D;
    // Start is called before the first frame update
    void Awake()
    {
        playerRigidbody2D = this.player.GetComponent<Rigidbody2D>();
        this.playerRigidbody2D.gravityScale = this.gravityScale;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DoJump()
    {
        if(player.isGroundFloor)
        {
            Debug.Log("jump");
            this.playerRigidbody2D.AddForce(Vector2.up * vetory, ForceMode2D.Impulse);
        }
    }

    private void OnGUI()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.DoJump();
        }
    }
}
