using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour
{

    public float speed = 10f;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, -5f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 5f, 0f);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime * speed;
        }

    }
}