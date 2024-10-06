using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Update()
    {
        // Get input from horizontal and vertical axis (WASD or arrow keys)
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        // Create a movement vector for the x and z directions (no movement in the y axis)
        Vector3 moveDirection = new Vector3(xDirection, 0f, zDirection);

        // Move the object in the specified direction
        transform.position += moveDirection * Time.deltaTime; // Time.deltaTime ensures consistent movement speed
    }
}
