using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class second : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0);
        //rb.AddForce(movement);


        Vector3 position = this.transform.position;

        position.x -= moveHorizontal;
        position.y -= moveVertical;
        position.z -= moveHorizontal;

        this.transform.position = position;

    }
}
