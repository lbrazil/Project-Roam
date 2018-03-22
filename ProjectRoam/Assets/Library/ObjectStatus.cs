using System.Collections.Generic;
using UnityEngine;

public class ObjectStatus : MonoBehaviour {

    [SerializeField] List<GameObject> toActive = new List<GameObject>();
    [SerializeField] List<GameObject> toDeActive = new List<GameObject>();

    private void OnMouseDown()
    {
        foreach (GameObject objects in toActive)
        {
            objects.SetActive(true);
        }

        foreach (GameObject objects in toDeActive)
        {
            objects.SetActive(false);
        }
    }
}
