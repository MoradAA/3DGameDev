
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockMovement : MonoBehaviour
{
    public GameObject Player;

    public float speed = 5f;
    public float minX = -41f;
    public float maxX = -28f;
    int Direction = -1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            Player.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Player)
        {
            Player.transform.parent = null;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (Direction)
        {
            case -1:
                // Moving Left
                if (gameObject.transform.position.x > minX)
                {
                    gameObject.transform.Translate(-1f * speed * Time.deltaTime, 0, 0);
                }
                else
                {
                    // Hit left boundary, change direction
                    Direction = 1;
                }
                break;

            case 1:
                // Moving Right
                if (gameObject.transform.position.x < maxX)
                {
                    gameObject.transform.Translate(1f * speed * Time.deltaTime, 0, 0);
                }
                else
                {
                    // Hit right boundary, change direction
                    Direction = -1;
                }
                break;
        }
    }
}
