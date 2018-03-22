using UnityEngine;
using UnityEngine.UI;

public class AdsLink : MonoBehaviour {

    [SerializeField] string link;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(OpenLink);
    }

    public void OpenLink()
    {
        Application.OpenURL(link);
    }
}
