using UnityEngine;
using UnityEngine.SceneManagement;
public class Portal : MonoBehaviour
{
    public  bool canMove;

    public Vector2 position = new Vector2();
    public GameObject door;
    public GameObject player;

    public Portal()
    {
        
    }

    void Start()
    {
        Debug.Log("portal script is loaded");
        //this.door = GameObject.FindGameObjectWithTag("mainDoor");

        canMove = false;

        //if (Input.GetKey(KeyCode.UpArrow))
        //{

        //    if (canMove)
        //    {
        //        Debug.Log("canMove " + canMove);
        //        SceneManager.LoadScene("enterHome");
        //    }
        //}
    }

    

    public void OnLoad()
    {
        SceneManager.LoadScene("enterHome");
    }

}
