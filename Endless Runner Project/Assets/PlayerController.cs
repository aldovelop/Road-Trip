using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator anim;

    public AudioClip jump;
    public AudioClip doublejump;
    public AudioClip dash;
    AudioSource playerSFX;

    public GameObject groundChecker;
    public LayerMask whatIsGround;
    Rigidbody2D playerObject;
    public float movementValueX = -6f;
    public float jumpForce = 800.0f;
    public float dashForce = -6000f;
    bool isOnGround = false;
    bool canDash = false;
    bool canDoubleJump = false;
    bool dashed = false;

    // Start is called before the first frame update
    void Start()
    {
        // Find the Rigidbody2D component that is attached to the same object as this script
        playerObject = GetComponent<Rigidbody2D>();

        playerSFX = GetComponent<AudioSource>();

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movementValueX -= 0.0001f;

        // Change the X velocity of the Rigidbody2D to be equal to the movement value
        playerObject.velocity = new Vector2(movementValueX, playerObject.velocity.y);

        // Check to see if the ground check object is touching the ground
        isOnGround = Physics2D.OverlapCircle(groundChecker.transform.position, 0.2f, whatIsGround);

        if (isOnGround)
        {
            canDash = true;
            canDoubleJump = true;
            dashed = false;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true)
        {
            playerObject.AddForce(new Vector2(0.0f, jumpForce));
            playerSFX.PlayOneShot(jump);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == false && canDoubleJump == true)
        {
            // Reset player y velocity
            playerObject.velocity = new Vector2(playerObject.velocity.x, 0f);

            playerObject.AddForce(new Vector2(0.0f, jumpForce));
            playerSFX.PlayOneShot(doublejump);

            canDoubleJump = false;
        }
        

        if (Input.GetKeyDown(KeyCode.LeftShift) && isOnGround == false && canDash == true)
        {
            playerObject.AddForce(new Vector2(-6000f, 0.0f));
            playerSFX.PlayOneShot(dash);

            canDash = false;
            dashed = true;
        }

        anim.SetFloat("VertVelocity", playerObject.velocity.y);
        anim.SetBool("IsOnGround", isOnGround);
        anim.SetBool("dashed", dashed);
        anim.SetBool("canDash", canDash);
    }
}