using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D selfrigidbody;
    private bool moveleft;
    private bool moveright;
    public float speed;

    void Start()
    {
        selfrigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        moveleft =Input.GetKey(KeyCode.A);
        moveright = Input.GetKey(KeyCode.D);

    }

    void FixedUpdate()
    {
        selfrigidbody.velocity = new Vector2();
        float currspeed = 0;
        if (moveleft) currspeed -= speed;
        if (moveright) currspeed += speed;
        selfrigidbody.velocity = new Vector2(currspeed, selfrigidbody.velocity.y);
    }
}
