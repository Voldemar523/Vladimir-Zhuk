using System.Collections;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private Ball _ball;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private float _shootDeley;
    [SerializeField] private float _delay;
    [SerializeField] private bool _canShoot;
    [SerializeField] private int _ballShop;
    [SerializeField] private float _delayBallReload;

    void Start()
    {
        BallTest();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _canShoot == true)
        {
            StartCoroutine(ShootTik());
            _ballShop = _ballShop - 1;
        }

        BallReload();
    }

    private void CreateBall()
    {    
            Ball ballCreated = Instantiate(_ball, _spawnPoint.position, Quaternion.identity).GetComponent<Ball>();
            ballCreated.Fly(_spawnPoint.transform.forward, 50);
            StartCoroutine(Delay());
    }

    private IEnumerator ShootTik()
    {
        _canShoot = false;
        yield return new WaitForSeconds(_shootDeley);
        CreateBall();
    }

    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(_delay);
        _canShoot = true;
    }

    private IEnumerator DelayBallReload()
    {
        yield return new WaitForSeconds(_delayBallReload);
        _canShoot = true;
    }

    private void BallTest()
    {
        if (_ballShop > 0)
        {
            _canShoot = true;
        }
        else
        {
            _canShoot = false;
        }
    }

    private void BallReload()
    {
        if (_ballShop < 1)
        {
            _canShoot = false;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            _ballShop = 10;          
            StartCoroutine(DelayBallReload());           
        }
        
    }

}

