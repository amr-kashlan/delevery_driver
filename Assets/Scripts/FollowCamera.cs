using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject racTheCar;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = racTheCar.transform.position + new Vector3(0, 0, -10);
        transform.rotation = racTheCar.transform.rotation;
    }
}
