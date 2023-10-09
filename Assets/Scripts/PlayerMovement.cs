using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Creates a function in our script that allows the adjustment of Rigidbody from Unity
    // through  our code.
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysSpeed = 500f;
    
    // void FixedUpdate instead of void Update because it makes unity collisions smoother
    // and recommended when working with velocity and/or physics.
    void FixedUpdate()
    {
        // The 0, 0, forwardForce are the x,y,z axis speed (velocity) and Time.deltaTime is for the fps being
        // consistent over all platforms no matter the computer.

        // The reason why it is and float forwardForce is so it can be adjusted in Unity, but the starting force is 2000.
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager1>().EndGame();
        }
    }
}
