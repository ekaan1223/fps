using JetBrains.Annotations;
using StarterAssets;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] ParticleSystem flash;

    public void Shoot(WeaponSO weaponSO)
    {

        flash.Play();
        RaycastHit hit;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, Mathf.Infinity))
        {
            //Debug.Log(hit.collider.name);
            Instantiate(weaponSO.HitVFX,hit.point,Quaternion.identity);

            EnemyHealth enemyHealth = hit.collider.GetComponent<EnemyHealth>();

            enemyHealth?.TakeDamage(weaponSO.Damage);

        }
    }
}
