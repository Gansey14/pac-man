using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class move : MonoBehaviour
{
    public bool collision = false;

    void moveRight()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            while (collision == false)
            {
                Vector3 position = transform.position;
                position.x += 0.1f;
                transform.position = position;
            }
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    void onCollisionEnter2D(Collision2D other)
    {
        collision = true;
    }

    // Update is called once per frame
    void Update()
    {
        moveRight();
    }


}


