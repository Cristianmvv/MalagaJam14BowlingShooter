using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponController : MonoBehaviour
{

    public List<WeaponController> startingWeapons = new List<WeaponController>();

    public Transform weaponParentSocket;
    public Transform defaultWeaponPosition;
    public Transform aimingPosition;

    public int activeWeaponIndex { get; private set; }

    private WeaponController[] weaponSlots = new WeaponController[5];

    // Start is called before the first frame update
    void Start()
    {
        activeWeaponIndex = -1;

        foreach (WeaponController startingWeapon in startingWeapons)
        {
            AddWeapon(startingWeapon);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SwitchWeapons(0);
        }
    }

    void SwitchWeapons(int p_weaponIndex)
    {
        if (p_weaponIndex != activeWeaponIndex && p_weaponIndex >= 0)
        {
            weaponSlots[p_weaponIndex].gameObject.SetActive(true);
            activeWeaponIndex = p_weaponIndex;
        }
    }

    private void AddWeapon(WeaponController p_weaponPrefab)
    {
        weaponParentSocket.position = defaultWeaponPosition.position;

        for (int i = 0; i < weaponSlots.Length; i++)
        {
            if (weaponSlots[i] == null)
            {
                WeaponController weaponClone = Instantiate(p_weaponPrefab, weaponParentSocket);
                weaponClone.gameObject.SetActive(false);

                weaponSlots[i] = weaponClone;

                return;
            }
        }
    }
}
