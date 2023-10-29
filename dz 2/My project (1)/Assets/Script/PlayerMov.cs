using JetBrains.Annotations;
using System;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMov : MonoBehaviour
{
    [SerializeField] private float _firstLetter, _secondLetter;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _jumpForce;
    [SerializeField] private int _jumpCount;
    [SerializeField] private float _speed;
    [SerializeField] private Mass _mass;
    [SerializeField] private float _startingSizePlayer;
  
    private void Start()
    {
        StartTrannsform();          
    }


    public void Update()
    {
        Movement();
    }
    
    private void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _rigidbody.velocity = new Vector3(0, 0, _speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            _rigidbody.velocity = new Vector3(0, 0, -_speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _rigidbody.velocity = new Vector3(-_speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rigidbody.velocity = new Vector3(_speed, 0, 0);
        }
    }

    private void StartTrannsform()
    {
        _startingSizePlayer = GetComponent<Mass>().Amount;
        transform.localScale = new Vector3(_startingSizePlayer, _startingSizePlayer, _startingSizePlayer);
    }

    private void OnCollisionEnter(Collision collision)
    {         
        if (collision.gameObject.GetComponent<Mass>())
        {
            if (_mass.Amount > collision.gameObject.GetComponent<Mass>().Amount)
            {                                              
                _mass.Amount += collision.gameObject.GetComponent<Mass>().Amount;
                transform.localScale = new Vector3(_mass.Amount, _mass.Amount, _mass.Amount);
            }
            else
            {            
                Destroy(gameObject);
            }
            Debug.Log("Kакой массы стал" + _mass.Amount);
            Debug.Log("Сколько съел" + collision.gameObject.GetComponent<Mass>().Amount);
        }              
    }  
}


