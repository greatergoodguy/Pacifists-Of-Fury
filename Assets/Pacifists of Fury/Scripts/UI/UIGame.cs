using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGame : MonoBehaviour {
    public static UIGame I;

    GameObject goContainer;

    GameObject go3;
    GameObject go7a;
    GameObject go7b1;
    GameObject go7b2;
    GameObject go7b3;
    GameObject go7c;

    void Awake() {
        I = this;
        goContainer = transform.Find("Container").gameObject;

        go3 = goContainer.transform.Find("3").gameObject;
        go7a = goContainer.transform.Find("7a").gameObject;
        go7b1 = goContainer.transform.Find("7b - 1").gameObject;
        go7b2 = goContainer.transform.Find("7b - 2").gameObject;
        go7b3 = goContainer.transform.Find("7b - 3").gameObject;
        go7c = goContainer.transform.Find("7c").gameObject;

        Hide();
    }

    void Start() {
    }

    public void Show() {
        goContainer.SetActive(true);
        go3.SetActive(true);

        go7a.SetActive(false);
        go7b1.SetActive(false);
        go7b2.SetActive(false);
        go7b3.SetActive(false);
        go7c.SetActive(false);
    }

    public void Hide() {
        goContainer.SetActive(false);
    }

    // ====================
    // UI Callbacks
    // ====================
    public void onButtonShow7a() {
        go3.SetActive(false);
        go7a.SetActive(true);
    }

    public void onButtonShow7b1() {
        go7a.SetActive(false);
        go7b1.SetActive(true);
    }

    public void onButtonShow7b2() {
        go7a.SetActive(false);
        go7b2.SetActive(true);
    }

    public void onButtonShow7b3() {
        go7a.SetActive(false);
        go7b3.SetActive(true);
    }

    public void onButtonShow7c() {
        go7b1.SetActive(false);
        go7b2.SetActive(false);
        go7b3.SetActive(false);
        go7c.SetActive(true);
    }
}
