using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowThing : MonoBehaviour
{

    [SerializeField] GameObject followThing;
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = followThing.transform.position + new Vector3(0, 0, -10);
    }
}
