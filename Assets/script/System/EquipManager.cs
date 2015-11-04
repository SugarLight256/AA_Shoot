using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public struct weaponS
{
    public int knd;
    public int atk;
    public float reload;
    public Vector2 localPos;
}

public class EquipManager : MonoBehaviour {

    public int weapon_amount;

    public int mainWeapon_knd;

    public List<weaponS> wepData;

	// Use this for initialization
    void Start()
    {

    }
	
	// Update is called once per frame
    void Update()
    {

    }

    public void ResetWepData()
    {
        if (wepData.Count > weapon_amount)
        {
            for (int i = wepData.Count - 1; wepData.Count > weapon_amount; i--)
            {
                wepData.RemoveAt(i);
            }
        }
        else if (wepData.Count < weapon_amount)
        {
            for (; wepData.Count < weapon_amount; )
            {
                wepData.Add(new weaponS());
            }
        }
    }

}
