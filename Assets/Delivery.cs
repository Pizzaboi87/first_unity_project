using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 noPackageColor = new Color32(45, 121, 245, 255);
    [SerializeField] Color32 hasPackageColor = new Color32(52, 200, 75, 255);

    bool hasPackage = false;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = noPackageColor;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up.");
            hasPackage = true;
            Destroy(other.gameObject);
            spriteRenderer.color = hasPackageColor;
        }
        else if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package delivered.");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }

        else if (other.tag == "Customer" && !hasPackage)
        {
            Debug.Log("Hey, where is my package?!");
        }
    }
}
