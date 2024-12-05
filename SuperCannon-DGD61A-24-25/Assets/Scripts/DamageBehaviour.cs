using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBehaviour : MonoBehaviour, ITakeDamage
{
    public void ApplyDamage(int hitpoints)
    {
        
        Enemy _enemy = GetComponent<Enemy>();
        _enemy.strength--;
        Debug.Log("Enemy strength: " + _enemy.strength.ToString());
        
        if (_enemy.strength <= 0 )
        {
            GameManager.Instance.OnEnemyDie(hitpoints);
            Destroy(this.gameObject);
        }
        StartCoroutine(ApplyDamageEffect());
    }

    IEnumerator ApplyDamageEffect()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        Color enemyColor = spriteRenderer.color;
        spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(0.2f);
        spriteRenderer.color = enemyColor;
    }

}
