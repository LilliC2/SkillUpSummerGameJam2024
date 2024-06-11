using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class Health : MonoBehaviour
{
    public float health, maxHealth;
    [SerializeField] Image fill;
    public void Hit(float damage){
        health -= damage;
        fill.fillAmount = health/maxHealth;
        if (health <= 0 && gameObject.CompareTag("Enemy")) Die(); 
        else if (health < 0 && !gameObject.CompareTag("Enemy")) FindAnyObjectByType<GameManager>().EndGame();
    }
    void Die(){
        GetComponent<Animator>().SetTrigger("Die");
        FindAnyObjectByType<MouseController>().UpdateMoneyAndDamage(Random.Range(1, 5), 0);}
}