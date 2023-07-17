using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public float Speed = 4.5f;
    public Vector3 LaunchOffset;
    public bool Thrown;
    private void Start()
    {
        if (Thrown)
        {
            var direction = transform.right + Vector3.up;
            GetComponent<Rigidbody2D>().AddForce(direction * Speed, ForceMode2D.Impulse);

        }
        transform.Translate(LaunchOffset);

        Destroy(gameObject, 5);


    }
    void Update()
    {
        if (!Thrown)
        {
            transform.position += transform.right * Time.deltaTime * Speed;
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        Destroy(gameObject);
    }
}


