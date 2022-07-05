using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public GameObject player;
	public float x;
	public float y;
	public float z;
	
	public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

	// Update is called once per frame
	private void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 20f;
        }
        else
        {
            speed = 12f;
        }
    }

	public void LoadLocationData()
	{
		x = PlayerPrefs.GetFloat("x");
		y = PlayerPrefs.GetFloat("y");
		z = PlayerPrefs.GetFloat("z");
		Vector3 posVec = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
		player.transform.position = posVec;
	}

	public void SaveLocationData()
	{
		PlayerPrefs.SetFloat("x", player.transform.position.x);
		PlayerPrefs.SetFloat("y", player.transform.position.y);
		PlayerPrefs.SetFloat("z", player.transform.position.z);
	}
}
