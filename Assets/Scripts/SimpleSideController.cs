using UnityEngine;

public class SimpleSideController : MonoBehaviour
{

    public float moveSpeed = 10.0f;

    public float bulletForce = 5000.0f;
	
	public Transform PlayerTransform;

    Rigidbody2D blahblah;

    Animator animator;

    SpriteRenderer spriteRenderer;

    public GameObject spawnPoint;
    public GameObject energyBall;
    public bool fireForward = true;
	public Joystick joystick;

    // Start is called before the first frame update
    void Start()
    {
        blahblah = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // What Moves Us
        float horizontalInput = joystick.Horizontal;
		float verticalInput = joystick.Vertical;
        //Get the value of the Horizontal input axis.

        transform.Translate(new Vector3(horizontalInput, 0, 0) * moveSpeed * Time.deltaTime);
		transform.Translate(new Vector3(0, verticalInput, 0) * moveSpeed * Time.deltaTime);
		
        if (horizontalInput > 0) 
        {
            animator.SetBool("isRunning", true);
            spriteRenderer.flipX = false;
            fireForward = true;
        } 
        else if (horizontalInput < 0) 
        {
            animator.SetBool("isRunning", true);
            spriteRenderer.flipX = true;
            fireForward = false;
        }
		else if (verticalInput > 0)
		{
            animator.SetBool("isRunning", true);
            spriteRenderer.flipX = true;
            fireForward = false;
        }
		else if (verticalInput < 0)
		{
            animator.SetBool("isRunning", true);
            spriteRenderer.flipX = true;
            fireForward = false;
        }
        else 
        {
            animator.SetBool("isRunning", false);
        }
    }
}
