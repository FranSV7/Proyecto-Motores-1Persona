using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapon : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform spawnBullet;
    [SerializeField] private float force;
    public int maxAmmo = 30;
    public Text maxAmmoTXT;
    

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && maxAmmo > 0)
        {
            Shoot();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            maxAmmo = 30;
        }
        maxAmmoTXT.text = maxAmmo.ToString();
    }
    private void Shoot()
    {
        GameObject bulletClone = Instantiate(bulletPrefab, spawnBullet.position, spawnBullet.rotation);

        Rigidbody bulletRB = bulletClone.GetComponent<Rigidbody>();

        bulletRB.AddRelativeForce(transform.up * force, ForceMode.Impulse);

        Destroy(bulletClone, 2);

        maxAmmo -= 1;
    }
    
    

    
}
