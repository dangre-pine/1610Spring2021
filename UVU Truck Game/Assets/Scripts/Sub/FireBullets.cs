using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullets : MonoBehaviour
{
    public Transform firePosition;
    public GameObject projectile;
    public float fireForce;

    // Start is called before the first frame update
    void Start()
    {
        fireForce = 20f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("space"))
        {
            GameObject bullet1 = Instantiate(projectile, firePosition.position, firePosition.rotation);
            bullet1.GetComponent(Rigidbody2D > ().AddForce(firePosition.up * fireForce, ForceMode2D.Impulse);
        }
    }
}
