using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlaerMoney : MonoBehaviour
{
    [SerializeField] private string _money;
    [SerializeField] private int _work;
                     private string _value;
    [SerializeField] private int _bonus;
    [SerializeField] private int _business;
        void Start()
    {
        _value = "$";
        _bonus = 10;
        _business = 20;
        _work = 30;
        _money = _bonus + _business + _work + _value.ToString();
    }
          public void TakeMoneyback(int moneyback)
      {
        _money += moneyback;
        Debug.Log(_money);
      }
   
    
       



    
}
