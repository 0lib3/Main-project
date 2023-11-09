using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgloop : MonoBehaviour
{
    public Transform character;
    public float loopSpeed = 1.0f;
    private float backgroundWidth;
    // Start is called before the first frame update
    void Start()
    {
        backgroundWidth = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        float newPosition = character.position.x * loopSpeed;
        transform.position = new Vector3(newPosition, transform.position.y, transform.position.z);

        if (character.position.x > (transform.position.x + backgroundWidth))
        {
            transform.position = new Vector3(transform.position.x + 2 * backgroundWidth, transform.position.y, transform.position.z);
        }
    }
}
