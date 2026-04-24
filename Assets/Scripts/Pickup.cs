using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] WeaponSO weaponSO;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }



    //    void onTriggerEnter(Collider other)
    //    {
    //        if(other.CompareTag("Player"))
    //        {
    //            Debug.Log("Pickup");
    //            ActiveWeapon activeWeapon = other.GetComponentInChildren<ActiveWeapon>();
    //            activeWeapon.WeaponChange(weaponSO);
    //             Destroy(this.gameObject);
    //        }
    //    }
    //}


    // Change this from onTriggerEnter to OnTriggerEnter
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Pickup");
            ActiveWeapon activeWeapon = other.GetComponentInChildren<ActiveWeapon>();
            activeWeapon.WeaponChange(weaponSO);
            Destroy(this.gameObject);
        }
    }

}