using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody rigidbodyComp;
    private bool leftKeyPressed;
    private bool rightKeyPressed;
    void Start()
    {
        rigidbodyComp = GetComponent<Rigidbody>();
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        rigidbodyComp.AddForce(0, 0, 200 * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbodyComp.AddForce(-500f * Time.deltaTime, 0, 0);
            // Debug.Log("Left arrow pressed");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbodyComp.AddForce(500f * Time.deltaTime, 0, 0);
            // Debug.Log("Right arrow pressed");
        }
    }

    private void OnCollisionEnter(Collision collider)
    {
        if (collider.collider.name == "Cube")
        {
            // Destroy(gameObject);
            this.enabled = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
