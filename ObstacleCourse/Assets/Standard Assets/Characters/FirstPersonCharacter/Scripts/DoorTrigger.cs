using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public GameObject door;
    bool isOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isOpen == false)
        {
            isOpen = true;
            door.transform.position += new Vector3(0, 4, 0);
            Debug.Log("opening");
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(isOpen == true)
        {
            isOpen = false;
            door.transform.position += new Vector3(0, -4, 0);
            Debug.Log("closing");
        }
    }
}
