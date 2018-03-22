using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DummyButton : MonoBehaviour {
    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(dummy);
    }
    public void dummy()
    {
        Debug.Log(gameObject.name);
    }
}
