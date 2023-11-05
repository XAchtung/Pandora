using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int health = 100;

    private int MAX_HEALTH = 100;


    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyUp(KeyCode.Mouse0))
        //{
        //    Damage(10);
        //}
    }

    public void Damage(int amount)
    {
        if(amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative damagae");
        }
        
        this.health -= amount;
        
        if(health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("KURWA");
        Destroy(gameObject);
    }
}
