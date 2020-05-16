using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBlock : MonoBehaviour
{
    private bool triggerFlag = false;
    public Rigidbody2D rbody;
    public GameObject block;

    public Vector2 firstPosition = new Vector2();
    // Start is called before the first frame update
    void Start()
    {
        this.block = GameObject.FindGameObjectWithTag("falling");
        Debug.Log("block => " + block.name);
        rbody = block.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FallingBlock2()
    {
        Debug.Log("falling block");
        triggerFlag = true;
        Debug.Log("collision Falling Block");
        rbody.gravityScale = 1f;
    }

}
