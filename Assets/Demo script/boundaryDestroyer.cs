using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundaryDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
   public void OnTriggerExit2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }
}
