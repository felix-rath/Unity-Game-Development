using UnityEngine;
using DG.Tweening;

public class DashAbility : Ability
{
    [Header("Properties")]
    public float dashDuration = 0.2f;
    public float dashDistance = 5f;
    public float dashPower = 10f;

    Rigidbody _rb;

    void Start()
    {
        //Vector3 forward = _context.caster.GetComponent<Rigidbody>().linearVelocity;
        _rb = _context.caster.GetComponent<Rigidbody>();
        Vector3 direction = _context.caster.GetComponent<Entity>().GetMovementDirection();
        direction.y = 0;

        int ignoreMask = _context.caster.gameObject.layer;
        int mask = ~ignoreMask;

        float distance = dashDistance;
        Vector3 origin = _context.caster.transform.position;
        origin.y += 0.2f;
        if (Physics.Raycast(_context.caster.transform.position, direction, out RaycastHit hit, dashDistance, mask))
        {
            distance = hit.distance;
        }

        Dash(direction, distance);
    }

    void Dash(Vector3 direction, float distance)
    {
        _rb.DOMove(
        _context.caster.transform.position + direction * distance,
        dashDuration
        );//.SetEase(Ease.OutQuad);
        //_rb.AddForce(direction * dashPower, ForceMode.Impulse);
    }
}
