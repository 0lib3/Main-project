using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyClone : MonoBehaviour
{
    public GameObject fuckhead;
    // Start is called before the first frame update
    void Start()
    {
        if (fuckhead != null)
        {
            // Instantiate the clone and immediately destroy it.
            GameObject clone = Instantiate(fuckhead, transform.position, Quaternion.identity);
            Destroy(clone);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
