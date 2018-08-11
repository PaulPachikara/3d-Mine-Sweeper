using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swap : MonoBehaviour {

    public GameObject reveal;

    private void OnMouseDown()
    {
        Instantiate(reveal, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
