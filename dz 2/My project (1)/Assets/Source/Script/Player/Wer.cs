using UnityEngine;

public class Wer : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.rotation = Quaternion.Euler(new Vector3(0, horizontal, vertical));
    }


}
