using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public float speed = 0;
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    private int points;
    public Transform spawnPoint;
    public GameObject player;
    public Text TextBox;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        points = 100;

    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            player.transform.position = spawnPoint.position;
    }

    void OnMove(InputValue movementValue)
    {
            Vector2 movementVector = movementValue.Get<Vector2>();

            movementX = movementVector.x;
            movementY = movementVector.y;
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    }
<<<<<<< Updated upstream
    
}
=======

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Task"))
        {
            points = points - 20;
            Debug.Log("Lost 20% of energy");
            TextBox.text = points.ToString() + "%";
            other.tag = "Done";
        }
        if(other.gameObject.CompareTag("Fun"))
        {
            points = points + 20;
            Debug.Log("Gained 20% of energy");
            TextBox.text = points.ToString() + "%";
            Debug.Log(points);
            other.tag = "Done";
        }

        if(points < 0)
        {
            SceneManager.LoadScene("end");
        }
    }

}
>>>>>>> Stashed changes
