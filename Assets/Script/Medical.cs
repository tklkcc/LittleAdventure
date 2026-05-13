using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medical : MonoBehaviour
{

    public float med = 50f; //»ØÑª50 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(Player.Instance.hp < Player.Instance.maxHp && Player.Instance.coin > 0)
            {
                Player.Instance.AddHealth(med);
                Player.Instance.ReduceCoin(50);
                PlayerVFXManager.Instance.HealthVFX();
            }
           
        }
    }
}
