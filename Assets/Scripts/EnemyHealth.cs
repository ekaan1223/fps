using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int startingHealth = 3;
    private int currentHealth;
    void Awake()
    {
        currentHealth = startingHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void takeDamage(int amount)
    {
        currentHealth -= amount;

        if (currentHealth < 2)
        {
            GetComponent<Renderer>().material.color = Color.red;
        }

        if (currentHealth < 0)
        {
            Destroy(gameObject);    
        } 
    }
}
