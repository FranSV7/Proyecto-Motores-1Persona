using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    [SerializeField] Scene deathMenu;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float movementVer = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float movementHor = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        transform.Translate(movementHor, 0, movementVer);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            deathMenu.ActiveScreenDeath();
        }
    }
}
