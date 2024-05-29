using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collision : MonoBehaviour
{

    bool hasPackage = false;
    [SerializeField] float DestroyDelay = 0.5f;
    [SerializeField] Color32 PackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);
    SpriteRenderer spriteRenderer;
    private void OnCollisionEnter2D(Collision2D other){
        Debug.Log("Touching");
    }
    
    private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if( other.tag == "Package" && !hasPackage){
            Debug.Log("Ohh Package");
            hasPackage = true;
            spriteRenderer.color = PackageColor;
            Destroy(other.gameObject, DestroyDelay);
        }
        if(other.tag == "Location" && hasPackage) {
            Debug.Log("I receive Package");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
