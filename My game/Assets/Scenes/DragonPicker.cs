using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonPicker : MonoBehaviour
{
    public GameObject energyShieldPrefab;
    public int numEnergyShield = 3;
    public float energyShieldBottomY = -6f;
    public float energyShieldRadius = 1.5f;
    void Start()
    {
        for (int i = 1; i <= numEnergyShield; i++){
            GameObject tShiedGo = Instantiate<GameObject>(energyShieldPrefab);
            tShiedGo.transform.position = new Vector3(0, energyShieldBottomY, 0);
            tShiedGo.transform.localScale = new Vector3(1*i, 1*i, 1*i);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
