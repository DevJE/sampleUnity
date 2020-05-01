using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstScript : MonoBehaviour
{
    private Rigidbody rb;

    private int score = 0;


    void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0);
        //rb.AddForce(movement);


        Vector3 position = this.transform.position;

        position.x += moveHorizontal;
        //position.y += moveVertical;
        position.z += moveVertical;

        if(Input.GetKey(KeyCode.Space)){
        }
            position.y += 1;

        this.transform.position = position;

    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Coin"))
        {

            coin myCoin = collision.gameObject.GetComponent<coin>();
            if(null != myCoin)
            {
                collision.gameObject.SetActive(false);

                score += myCoin.point;

                print("get Coin!");
                print("my score is " + score + "!");

            }
        }

        //
    }
}
