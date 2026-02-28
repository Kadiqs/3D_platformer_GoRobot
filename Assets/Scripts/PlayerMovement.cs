using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // --- Public Variables ---

    [Header("Player movement")]
    public float moveSpeed = 2;
    public float jumpSpeed;
    public float rotationSpeed;
    public float JumpButtongracePeriod;
    public float? lastGroundedTime; // can be null
    public float? JumpButtonPressedTime;

    // --- Private Variables ---
    private CharacterController characterController;

    private float originalStepOffset;

    //------------
    private Vector3 moveDirection;
    //---------------
    private float ySpeed;         // Vertical velocity (for gravity)

    //--- Animation ---
    public Animator animator;

    // Called once when the game starts
    void Start()
    {
        // Get CharacterController component from the player
        characterController = GetComponent<CharacterController>();
        originalStepOffset = characterController.stepOffset;

    }

    // Called once per frame
    void Update()
    {
        ///1. Player Input (-1 to 1)
        float Hmove = Input.GetAxis("Horizontal");
        float Vmove = Input.GetAxis("Vertical");

        //2. Direction Setup 
        // Create movement direction (X = left/right, Z = forward/backward) 
        moveDirection = new Vector3(Hmove, 0, Vmove);

        // Get direction magnitude and normalize to prevent faster diagonal movement
        float magnitude = moveDirection.magnitude;
        magnitude = Mathf.Clamp(magnitude, 0, 1);
        moveDirection.Normalize();

        // Tell the Animator what our speed is (Mathf.Abs makes it a positive number)
        animator.SetFloat("Speed", Mathf.Abs(moveDirection.magnitude));
        //3. Gravity 
        ySpeed += Physics.gravity.y * Time.deltaTime;

        //4. Jump & Ground Check 
        if (characterController.isGrounded)
        {
            characterController.stepOffset = originalStepOffset;
            lastGroundedTime = Time.time;

            ySpeed = -0.5f;
            animator.SetBool("IsJumping", false);
        }

        if (Input.GetButtonDown("Jump"))
        {
            JumpButtonPressedTime = Time.time;
        }
        bool canJump =
    lastGroundedTime.HasValue &&
    Time.time - lastGroundedTime <= JumpButtongracePeriod &&
    JumpButtonPressedTime.HasValue &&
    Time.time - JumpButtonPressedTime <= JumpButtongracePeriod;


        if (canJump)
        {
            ySpeed = jumpSpeed;
            animator.SetBool("IsJumping", true);

            lastGroundedTime = null;
            JumpButtonPressedTime = null;
        }

        // 3. Check for Crouch Input
        if (Input.GetButtonDown("Crouch"))
        {
            animator.SetBool("IsCrouching", true);
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            animator.SetBool("IsCrouching", false);
        }


        //5. Apply Movement
        Vector3 velocity = moveDirection * magnitude * moveSpeed;
        velocity.y = ySpeed;
        characterController.Move(velocity * Time.deltaTime);


        //6. rotation
        if (moveDirection != Vector3.zero)
        {
            // Smooth rotation towards movement direction
            Quaternion toRotation = Quaternion.LookRotation(moveDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }

}
