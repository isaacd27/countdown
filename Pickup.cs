using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;




public class Pickup : MonoBehaviour
{
    public GunFace GFace;

    public string weaponSet;
    public int ammoGiven;

    public bool DoesSetWeapon;

    // Start is called before the first frame update
    void Start()
    {
        GFace = GameObject.Find("Player").GetComponent<GunFace>();

        if (weaponSet == ""|| weaponSet == null)
        {
            weaponSet = GFace.GetWeapon();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<GunFace>() != null)
        {
            Debug.Log("Hit");
            switch (weaponSet)
            {
                case "Stake":
                    if (DoesSetWeapon)
                    {
                        GFace.SetWeapon(weaponSet);

                    }
                    
                break;

                case "Pistol":
                    if (DoesSetWeapon)
                    {
                        GFace.SetWeapon(weaponSet);

                    }                    
                    GFace.setPammo(ammoGiven);
                break;

                case "Shotgun":
                    if (DoesSetWeapon)
                    {
                        GFace.SetWeapon(weaponSet);

                    }
                    GFace.setSammo(ammoGiven);
                break;

                case "Rifle":
                    if (DoesSetWeapon)
                    {
                        GFace.SetWeapon(weaponSet);

                    }
                    GFace.setRammo(ammoGiven);
                break;

                case "Ammo":
                case "ammo":
                case "All":
                case "all":
                
                    GFace.setALLammo(ammoGiven);

                break;
            }
        //playsfx
            Destroy(this.gameObject);       
            }
    }
}
