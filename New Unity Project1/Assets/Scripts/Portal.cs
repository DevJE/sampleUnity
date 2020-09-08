using UnityEngine;
using UnityEngine.SceneManagement;
public class Portal : MonoBehaviour
{
    private bool canMove;

    public Vector2 position = new Vector2();
    public GameObject door;
    public GameObject player;

    public Portal()
    {
        
    }

    void Start()
    {
        Debug.Log("portal script is loaded");
        this.door = GameObject.FindGameObjectWithTag("mainDoor");
    }

    void Update()
    {
        canMove = false;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            
            if(canMove)
            {
                Debug.Log("canMove " + canMove);
                SceneManager.LoadScene("enterHome");
            }
        }

        //if (Input.GetKey(KeyCode.UpArrow))
        //{


        //}
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.transform.tag == "player")
        {
            Debug.Log("on trigger");
            //door.transform.position = new Vector2(position.x, position.y);
            canMove = true;
        }


     }

    public void SetInitPosition()
    {
        this.transform.position = position;
    }
}
