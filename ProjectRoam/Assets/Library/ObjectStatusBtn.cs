using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ObjectStatusBtn : MonoBehaviour {

    [SerializeField] List<GameObject> toActive = new List<GameObject>();
    [SerializeField] List<GameObject> toDeActive = new List<GameObject>();

    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(ShowAndHide);
    }

    public void ShowAndHide()
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
