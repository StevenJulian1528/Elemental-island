using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoss : MonoBehaviour
{
    public int maxhealth = 200;
    public int currentHealth;
    public healthBar healthbar;
    Color originalColor;
    public SpriteRenderer sprite;
    Animator anim;
    public GameObject victory;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxhealth;
        healthbar.SetMaxHealth(maxhealth);
        originalColor = sprite.color;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void takeDamage(int damage)
    {
        StartCoroutine(flashRed());
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        victory.SetActive(true);
        anim.SetBool("isDie", true);
        Destroy(gameObject, 2f);
    }

    public IEnumerator flashRed()
    {
        sprite.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        sprite.color = originalColor;
    }

}
