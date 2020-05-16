using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatFloatObject : MonoBehaviour
{
    public Sprite[] crankSprites;

    private SpriteRenderer crankRenderer;
    private Sprite crank;

    public GameObject floatTiles;

    // Start is called before the first frame update
    void Start()
    {
        crankRenderer = GetComponent<SpriteRenderer>();
        Debug.Log("crank object");
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 position = this.transform.position;
    }

    /*void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision flag");
        if (collision.transform.tag == "Player")
        {
            Debug.Log("collision crank");
            crankRenderer.sprite = crankSprites[1];
            floatTiles.SetActive(true);
        }
    }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            Debug.Log("collision crank");
            crankRenderer.sprite = crankSprites[1];
            floatTiles.SetActive(true);
            Debug.Log("falling !");
            //FallingBlock fb = gameObject.AddComponent<FallingBlock>();
            //if (fb != null)
            //    fb.FallingBlock2();
            GameObject block = GameObject.FindGameObjectWithTag("falling");
            Rigidbody2D rbody = block.GetComponent<Rigidbody2D>();
            rbody.gravityScale = 1f;
        }
    }
}
