using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruticble : MonoBehaviour
{
    public GameObject destroyedVersion;

    void OnMouseDown()
    {
        Instantiate(destroyedVersion, transform.position, destroyedVersion.transform.rotation);
        Destroy(gameObject);
    }
}
