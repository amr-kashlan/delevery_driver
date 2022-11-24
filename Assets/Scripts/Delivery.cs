using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    public int packages = 0;
    public Color32 package = new Color32(1, 1, 1, 1);
    public Color32 noPackage = new Color32(1, 1, 1, 1);
    public SpriteRenderer color;
    // Start is called before the first frame update
    void Start()
    {
        color.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame





    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && packages == 0)
        {
            packages = 1;
            color.color = noPackage;
            Destroy(other.gameObject, 0.5f);
        }
        if (other.tag == "customer" && packages == 1)
        {
            packages = 0;
            color.color = package;
        }
    }
}
