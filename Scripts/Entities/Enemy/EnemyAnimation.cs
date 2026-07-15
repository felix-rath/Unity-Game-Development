using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Animator))]
public class EnemyAnimation : MonoBehaviour
{
    [Header("Animation Setup")]
    public EnemyAnimationSet animSet;

    [Header("Smoothing")]
    public float speedSmooth = 10f;

    private NavMeshAgent agent;
    private Animator animator;

    private float currentSpeed;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

        // NavMesh dreht automatisch → perfekt ohne Turn Anim
        agent.updateRotation = true;
    }

    void Start()
    {
        ApplyAnimationSet(animSet);
    }

    void Update()
    {
        HandleMovement();
    }

    // ---------------- APPLY ANIM SET ----------------
    void ApplyAnimationSet(EnemyAnimationSet set)
    {
        if (set == null) return;

        var overrideController =
            new AnimatorOverrideController(animator.runtimeAnimatorController);

        overrideController["Idle"] = set.idle;
        overrideController["Walk"] = set.walk;

        overrideController["MeleeAttack"] = set.meleeAttack;
        overrideController["RangedAttack"] = set.rangedAttack;
        overrideController["CastSpell"] = set.castSpell;

        overrideController["Dash"] = set.dash;
        overrideController["Jump"] = set.jump;
        overrideController["Escape"] = set.escape;

        animator.runtimeAnimatorController = overrideController;
    }

    // ---------------- MOVEMENT ----------------
    void HandleMovement()
    {
        float targetSpeed = agent.velocity.magnitude;

        currentSpeed = Mathf.Lerp(
            currentSpeed,
            targetSpeed,
            Time.deltaTime * speedSmooth
        );

        animator.SetFloat("Speed", currentSpeed);
    }

    // ---------------- ACTIONS ----------------

    public void Attack() => animator.SetTrigger("MeleeAttack");
    public void RangedAttack() => animator.SetTrigger("RangedAttack");
    public void Dash() => animator.SetTrigger("Dash");
    public void Jump() => animator.SetTrigger("Jump");
    public void Escape() => animator.SetTrigger("Escape");
    public void CastSpell() => animator.SetTrigger("CastSpell");
}