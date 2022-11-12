using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICharacterSelect : MonoBehaviour
{
    public static UICharacterSelect I;

    GameObject goContainer;

    void Awake() {
        I = this;
        goContainer = transform.Find("Container").gameObject;
    }

    void Start() {
        Hide();
    }

    public void Show() {
        goContainer.SetActive(true);
    }

    public void Hide() {
        goContainer.SetActive(false);
    }
}
