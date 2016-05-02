using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CardController : MonoBehaviour {
    public Canvas Hand = null;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (Hand.isActiveAndEnabled)
            {
                Hand.gameObject.SetActive(false);
            }
            else
            {
                Hand.gameObject.SetActive(true);
            }
        }
	}


}
