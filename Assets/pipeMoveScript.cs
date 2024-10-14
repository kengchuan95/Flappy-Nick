using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5; //how fast the pipes move
    public float deadZone = -45; //when to despawn the pipes

    // Start is called before the first frame update
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
