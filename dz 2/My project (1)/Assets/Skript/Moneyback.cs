using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneyback : MonoBehaviour
{
    [SerializeField] private PlaerMoney test;

    private void Start()
    {
        test.TakeMoneyback(50); 
    }


}
