using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHeart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * 3f);
    }

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<CharacterManager>().hp += 0.1f;
        Destroy(gameObject);
    }
}
