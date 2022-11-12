using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIIntro : MonoBehaviour
{
    public static UIIntro I;

    GameObject goContainer;

    void Awake() {
        I = this;
        goContainer = transform.Find("Container").gameObject;
        Hide();
    }

    void Start() {
    }

    public void Show() {
        goContainer.SetActive(true);
    }

    public void Hide() {
        goContainer.SetActive(false);
    }
}
