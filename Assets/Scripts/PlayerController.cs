using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] float moveSpeed;
    [SerializeField] GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMove(InputValue inputVal)
    {
        rb.velocity = (inputVal.Get<Vector2>() * moveSpeed);
    }

    private void OnFire()
    {
        Debug.Log("Firing...");
        Instantiate(bullet, transform.position, Quaternion.identity);
        
    }

    private void OnSwapWeapon()
    {
        Debug.Log("Swapping Weapon...");
    }
}
