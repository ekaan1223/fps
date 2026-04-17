using StarterAssets;
using UnityEngine;
using UnityEngine.EventSystems;

public class Weapon : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    StarterAssetsInputs starterAssetsInputs;
    [SerializeField] int damageAmount = 1;
    [SerializeField] Animator animator;

    void Start()
    {
        starterAssetsInputs = GetComponentInParent<StarterAssetsInputs>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (!starterAssetsInputs.shoot) return;
        animator.Play("shoot", 0, 0F);
        RaycastHit hit;

       if (Physics.Raycast(Camera.main.transform.position , Camera.main.transform.forward , out hit , Mathf.Infinity))
        {
            //Debug.Log(hit.collider.name);

            EnemyHealth enemyHealth = hit.collider.GetComponent<EnemyHealth>();

            if (enemyHealth)
            {
                enemyHealth.takeDamage(damageAmount);

            }

            starterAssetsInputs.ShootInput(false);
        }
    }
}
