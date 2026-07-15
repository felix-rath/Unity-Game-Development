using UnityEngine;

public class PlayerAnimationManager : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private Rigidbody rb;

    [Header("Movement Speeds")]
    public float walkSpeed = 4;
    public float sprintSpeed = 7;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        MovementAnimUpdate();
    }

    // ---------- CORE ----------
    
    // Using values to decide when to play walk or run anim
    private void MovementAnimUpdate()
    {
        // only XZ speed
        Vector3 flatVel = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);
        float speed = flatVel.magnitude;

        float animValue;

        if (speed < 0.2f)
        {
            animValue = 0f; // Idle
        }
        else if (speed < walkSpeed)
        {
            animValue = 1f; // Walk
        }
        else if (speed < sprintSpeed)
        {
            animValue = 1f + (speed - walkSpeed) / (sprintSpeed - walkSpeed); 
            // optional smooth Übergang Walk → Run
        }
        else
        {
            animValue = 2f; // Run cap
        }

        animator.SetFloat("Speed", animValue, 0.1f, Time.deltaTime);
    }

    // -------- ANIM TRIGGERS --------
    public void StartAttack()
    {
        animator.SetTrigger("Attack");
    }

    public void StartCast()
    {
        animator.SetTrigger("StartCast");
    }

    public void StopCast()
    {
        animator.SetTrigger("StopCast");
    }
}