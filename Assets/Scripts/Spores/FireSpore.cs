using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpore : Spore
{
    [SerializeField] private int damage = 5;

    private void OnTriggerEnter(Collider other)
    {
        if(other.isTrigger){return;}
        if(other.CompareTag("Player")){return;}
        EnemyHealth enemy = other.gameObject.GetComponent<EnemyHealth>();
        if(enemy != null)
        {
            enemy.TakeFireDamage(damage);

            // Handling knockback
            Vector2 knockbackDirection = enemy.transform.position - this.transform.position;

            EnemyMovement enemyMovement = other.gameObject.GetComponent<EnemyMovement>();
            enemyMovement?.TakeKnockback(knockbackDirection);
        }

        BossHealth boss = other.gameObject.GetComponent<BossHealth>();
        if(boss != null)
        {
            boss.TakeFireDamage(damage);
        }


        if(other.gameObject.tag == "Vines"){
            Destroy(other.gameObject);
        }
        Destroy(gameObject);
    }
}
