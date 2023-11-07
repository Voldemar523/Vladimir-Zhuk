using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Fly(Vector3 directions, float force)
    {
        _rigidbody.AddForce(directions * force, ForceMode.Impulse);
    }
}
