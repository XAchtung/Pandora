using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackSword : MonoBehaviour
{
   
    private bool attacking = false;
    private float timeToAttack = 0.5f;
    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attack();
            //Debug.Log("lewy");
        }

        if (attacking)
        {
            timer += Time.deltaTime;

            if(timer >= timeToAttack)
            {
                timer = 0;
                attacking = false;
                
                
            }
        }
    }

    private void Attack()
    {
        attacking = true;
    
Vector3 bar = transform.position;
bar = bar + transform.forward*1;
       Collider[] hitColliders = Physics.OverlapSphere(bar, 1);
        foreach (var hitCollider in hitColliders)
        {
            string team = hitCollider.name;
            if(team=="Enemy"){
            if (hitCollider.GetComponent<Health>() != null)
        {
            
            Health health = hitCollider.GetComponent<Health>();
            health.Damage(5);}

        }
        }
    }
    
}
