using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public Rigidbody rb;

    public float moveSpeed = 500f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape) || Input.GetKey("q"))
        {
            SceneManager.LoadScene(0);
        }
    }

    // Use for physics-related stuff
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, 2 * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -2 * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(moveSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-moveSpeed * Time.deltaTime, 0, 0);
        }
    }
}
