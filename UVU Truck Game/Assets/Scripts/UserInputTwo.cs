using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UserInputTwo : MonoBehaviour
{

    public float speed = 3f;
    public float jumpForce = 20f;
    public Rigidbody2D rigidbodyObj;

    private Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        direction.x = speed * Input.GetAxis("Horizontal");
        rigidbodyObj.AddForce(direction, ForceMode2D.Force);
        if (Input.GetButtonDown("Jump"))
        {
            direction.y = jumpForce;
            rigidbodyObj.AddForce(direction, ForceMode2D.Impulse);
        }
    }
}
