using StarterAssets;
using UnityEngine;

public class ActiveWeapon : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    StarterAssetsInputs starterAssetsInputs;

    //[SerializeField] int damageAmount = 1
    Animator animator;

    //[SerializeField] GameObject hitVFX;
    [SerializeField] WeaponSO weaponSO;

    Weapon currentWeapon;

    float fireRateTime;

    const string SHOOT_STRING = "Shoot";

    void Awake()
    {
        starterAssetsInputs = GetComponentInParent<StarterAssetsInputs>();
        animator = GetComponent<Animator>();
    }
    void Start()
    {
        currentWeapon = GetComponentInChildren<Weapon>();
        fireRateTime = weaponSO.FireRate;
    }

    // Update is called once per frame
    void Update()
    {
        fireRateTime += Time.deltaTime;
        //Debug.Log(fireRateTime);
        HandleShoot();
    }

    public void WeaponChange(WeaponSO newWeaponSO)
    {
        Debug.Log("Weapon Change");

        if (currentWeapon)
        {
            Destroy(currentWeapon.gameObject);
        }

        //Weapon newWapon = Instantiate(weaponSO.weaponPrefab, transform).GetComponent<Weapon>();
        //currentWeapon = newWapon;
        //this.weaponSO = WeaponSO;
        Weapon newWeapon = Instantiate(newWeaponSO.WeaponPrefab, transform).GetComponent<Weapon>();
        currentWeapon = newWeapon;
        this.weaponSO = newWeaponSO;
    }

    void HandleShoot()
    {
        if (!starterAssetsInputs.shoot) return;

        if(fireRateTime >= weaponSO.FireRate)
        {
            currentWeapon.Shoot(weaponSO);
            animator.Play(SHOOT_STRING,0,0f);
            //starterAssetsInputs.ShootInput(false);
            fireRateTime = 0f;
        }

        if(!weaponSO.IsFiring)
        {
            starterAssetsInputs.ShootInput(false);
        }


        
    }
}
