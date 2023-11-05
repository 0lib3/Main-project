using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSprite : MonoBehaviour
{
    [SerializeField] private GameObject m_Sprite;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(m_Sprite, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
