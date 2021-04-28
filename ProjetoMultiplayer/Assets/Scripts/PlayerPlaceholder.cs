using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlaceholder : MonoBehaviour
{
    public float speed;
    Vector3 movement;
    Rigidbody RbPlayer;
    // Start is called before the first frame update
    void Start()
    {
        RbPlayer = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        movement = new Vector3(moveHorizontal, 0f, moveVertical);

        movement = movement * speed * Time.deltaTime;

        transform.position += movement;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            RbPlayer.AddForce(0f, 10000f, 0f);
        }
    }
}
