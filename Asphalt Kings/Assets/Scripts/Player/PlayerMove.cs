using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    [Header("Player Speed")]
    [SerializeField] float playerMoveSpeed;
    [SerializeField] float playerRotateSpeed;


    public SceneController sceneController;

    private void Update()
    {
        Move();
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * playerMoveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(-Vector3.up, playerRotateSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, playerRotateSpeed * Time.deltaTime);
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            sceneController.DeadScene();
        }

        if (collision.gameObject.CompareTag("Finish"))
        {
            sceneController.FinishScene();
        }
    }
}
