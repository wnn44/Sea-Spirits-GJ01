using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private GameObject _effectPrefab;
    [SerializeField] private bool DoorKey;

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(0,_rotationSpeed * Time.deltaTime,0); 
    }

    private void OnTriggerEnter(Collider other)
    {

        if (DoorKey)
        {
            Destroy(gameObject);
            FindObjectOfType<KeyManager>().AddOne();
        }
        // Instantiate(_effectPrefab, transform.position, transform.rotation);
    }
}
