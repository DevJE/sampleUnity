using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update

    public Sprite[] idleSprites;
    public Sprite[] moveSprites;

    public SpriteRenderer playerImage;

    public int index1 = 0;
    public int index2 = 0;
    public int count = 0;
    public int frame = 0;

    public Vector2 firstPosition = new Vector2();
    
    // public float jjump;
    public bool isGroundFloor;
    void Start()
    {
        playerImage = GetComponent<SpriteRenderer>();
        firstPosition.x = this.transform.position.x;
        firstPosition.y = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = this.transform.position;

        ++count;
        if(frame <= count)
        {
            count = 0;

            if(Input.GetKey(KeyCode.A))
            {
                position.x += .07f;
            }

            if(Input.GetKey(KeyCode.D))
            {
                position.x -= .07f;
            }

            this.transform.position = position;

            /*if (Input.GetKeyDown(KeyCode.Space))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jjump);
            }*/

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                ++index2;
                if (moveSprites.Length <= index2)
                {
                    index2 = 0;
                }

                playerImage.sprite = moveSprites[index2];
                playerImage.flipX = Input.GetKey(KeyCode.D);
            }
            else
            {
                ++index1;
                if (idleSprites.Length <= index1)
                {
                    index1 = 0;
                }

                playerImage.sprite = idleSprites[index1];
            }

            
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.transform.tag == "groundFloor")
        {
            this.isGroundFloor = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.transform.tag == "groundFloor")
        {
            this.isGroundFloor = false;
        }
    }

    

}
