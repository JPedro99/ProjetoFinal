using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardaDoRei : MonoBehaviour
{
    public GameObject player;

    private Rigidbody2D selfrigidbody;

    private float TimeSinceLastAction = 0.0f;

    public float Speed = 0.0f;
    public float IdleTime = 0.0f;
    public float WalkTime = 0.0f;
    public bool Walk = false;

    // Start is called before the first frame update
    void Start()
    {
        selfrigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        TimeSinceLastAction += Time.deltaTime;

        if (TimeSinceLastAction >= IdleTime)
        {
            Walk = true;
        }
        Debug.Log(Vector2.Distance(player.transform.position, transform.position));
    }
}