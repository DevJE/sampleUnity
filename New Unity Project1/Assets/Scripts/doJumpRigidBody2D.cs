using UnityEngine;

public class doJumpRigidBody2D : MonoBehaviour
{
    public player player;
    public float vetory = 1;
    //Gravity
    public float gravityScale = 1;

    public float objectSpeed;
    public float objectJump;

    private int index1 = 0;
    private int index2 = 0;
   
    private Sprite[] idleSprites;
    private Sprite[] moveSprites;
    private SpriteRenderer playerImage;
    // Start is called before the first frame update
    void Awake()
    {
        
    }

    void Start()
    {
        Debug.Log("doJump is started");
        player = GameObject.Find("player").GetComponent<player>();

        idleSprites = player.idleSprites;
        moveSprites = player.moveSprites;
        playerImage = player.playerImage;
        
    }

    // Update is called once per frame
    void Update()
    {
        float foxMove = objectSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.RightArrow)) rightKeycode(foxMove);
        else if (Input.GetKey(KeyCode.LeftArrow)) leftKeycode(foxMove);
        else if (Input.GetKey(KeyCode.UpArrow)) upKeycode(foxMove);
        else if (Input.GetKey(KeyCode.DownArrow)) downKeycode(foxMove);
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

    private void downKeycode(float move)
    {
        transform.position += Vector3.down * move;
    }

    private void leftKeycode(float move)
    {
        //  this.gameObject.GetComponent<SpriteRenderer>().flipX = false;
        //  transform.position += Vector3.right * move;
        
        ++ index2;
        Debug.Log("index2 => " + index2);
        if (moveSprites.Length <= index2)
        {
            index2 = 0;
        }

        playerImage.sprite = moveSprites[index2];
        playerImage.flipX = false;
        transform.position += Vector3.right * move;
    }

    private void rightKeycode(float move)
    {
        ++index2;
        if (moveSprites.Length <= index2)
        {
            index2 = 0;
        }

        playerImage.sprite = moveSprites[index2];
        playerImage.flipX = true;
        transform.position += Vector3.left * move;
    }

    private void upKeycode(float move)
    {
        Rigidbody2D rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
        rigidbody2D.AddForce(Vector3.up * objectJump);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(GameObject.FindGameObjectWithTag("crank"))
        {
            GetComponent<PolygonCollider2D>().isTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        GetComponent<PolygonCollider2D>().isTrigger = false;
    }
}
