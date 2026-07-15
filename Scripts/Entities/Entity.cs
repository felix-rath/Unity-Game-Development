using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    [Header("Stats")]
    public float currentHealth;
    public BaseStats baseStats;

    Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        currentHealth = baseStats.maxHealth;
    }

    // -------------- CORE --------------

    public void Heal(float value)
    {
        currentHealth += value;
    }

    // Substract damage data class from currenthealth and destroy object
    public void TakeDamage(Damage dmg)
    {
        float finalDmg = dmg.magic + dmg.physical;
        Debug.Log("DAMAGE: " + finalDmg);
        currentHealth -= finalDmg;
        if (currentHealth <= 1)
        {
            Destroy(this.gameObject);
        }
    }

    // Substract value from currenthealth and destroy object
    public void TakeDamage(float value)
    {
        Debug.Log("DAMAGE: " + value);
        currentHealth -= value;
        if (currentHealth <= 1)
        {
            Destroy(this.gameObject);
        }
    }

    public virtual Vector3 GetForward()
    {
            return transform.forward;
    }

    public Vector3 GetMovementDirection()
    {
        Vector3 velocity = _rb.linearVelocity;
        velocity.y = 0;
        return velocity;
    }
}
