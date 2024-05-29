using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.1f; 
    [SerializeField] float steerSpeed = 0.1f;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float normalSpeed = 15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        float changeSteer = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float changeMove = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0, changeMove, 0);
        transform.Rotate(0, 0, -changeSteer);
    }

    private void OnCollisionEnter2D(Collision2D other) {
            moveSpeed = normalSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Boost") {
            moveSpeed = boostSpeed;
            Destroy(other.gameObject, 0.5f); 
        }
    }
}
