using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePlayer : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 1.5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.N))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    void FixedUpdate()
    {
        float moveAD = Input.GetAxis("Horizontal");
        float moveWS = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(moveAD, 0.0f, moveWS);

        rb.AddForce(moveDirection * speed);
    }

    /*public int speed = 3;

    CharacterController MyBody;
    Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        MyBody = this.GetComponent<CharacterController>();
    }

    void Update()
    {
        if (MyBody != null)
        {
            float moveAD = Input.GetAxis("Horizontal");
            float moveWS = Input.GetAxis("Vertical");

            moveDirection = new Vector3(moveAD, 0, moveWS);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            MyBody.Move(moveDirection * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.N))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
    */
    /*private void OnTriggerEnter(Collider collider)
    {
        if (this.CompareTag("Player") && collider.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
*/

    }
