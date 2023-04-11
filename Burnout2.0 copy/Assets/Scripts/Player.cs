using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 0;
    public GameObject player;
    public Transform spawnPoint;

    private Rigidbody rb;
    private float movementX;
    private float movementY;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            player.transform.position = spawnPoint.position;
    }

    //** void OnMove(InputValue movementValue)
    //{
    //        Vector2 movementVector = movementValue.Get<Vector2>();

    //        movementX = movementVector.x;
    //        movementY = movementVector.y;
    //}
    //void FixedUpdate()
    //{
    //    Vector3 movement = new Vector3(movementX, 0.0f, movementY);

    //    rb.AddForce(movement * speed);
    //}
}
