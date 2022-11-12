using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGame : MonoBehaviour {
    public static UIGame I;

    GameObject goContainer;

    GameObject go3;
    GameObject go7;
    GameObject go7a;
    GameObject go7b1;
    GameObject go7b2;
    GameObject go7b3;
    GameObject go7c;
    GameObject go7c1;
    GameObject go7c2;
    GameObject go7c3;
    GameObject go7c4;
    GameObject go7c5;
    GameObject go7c6;
    GameObject go7c7;

    void Awake() {
        I = this;
        goContainer = transform.Find("Container").gameObject;

        go3 = goContainer.transform.Find("3").gameObject;
        go7 = goContainer.transform.Find("7").gameObject;
        go7a = goContainer.transform.Find("7a").gameObject;
        go7b1 = goContainer.transform.Find("7b - 1").gameObject;
        go7b2 = goContainer.transform.Find("7b - 2").gameObject;
        go7b3 = goContainer.transform.Find("7b - 3").gameObject;
        go7c = goContainer.transform.Find("7c").gameObject;
        go7c1 = goContainer.transform.Find("7c1").gameObject;
        go7c2 = goContainer.transform.Find("7c2").gameObject;
        go7c3 = goContainer.transform.Find("7c3").gameObject;
        go7c4 = goContainer.transform.Find("7c4").gameObject;
        go7c5 = goContainer.transform.Find("7c5").gameObject;
        go7c6 = goContainer.transform.Find("7c6").gameObject;
        go7c7 = goContainer.transform.Find("7c7").gameObject;

        Hide();
    }

    void Start() {
    }

    public void Show() {
        goContainer.SetActive(true);
        go3.SetActive(true);

        go7.SetActive(false);
        go7a.SetActive(false);
        go7b1.SetActive(false);
        go7b2.SetActive(false);
        go7b3.SetActive(false);
        go7c.SetActive(false);
        go7c1.SetActive(false);
        go7c2.SetActive(false);
        go7c3.SetActive(false);
        go7c4.SetActive(false);
        go7c5.SetActive(false);
        go7c6.SetActive(false);
        go7c7.SetActive(false);
    }

    public void Hide() {
        goContainer.SetActive(false);
    }

    // ====================
    // UI Callbacks
    // ====================
    public void onButtonShow7() {
        go3.SetActive(false);
        go7.SetActive(true);
    }

    public void onButtonShow7a() {
        go7.SetActive(false);
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

    public void onButtonShow7c1() {
        go7c.SetActive(false);
        go7c1.SetActive(true);
    }

    public void onButtonShow7c2() {
        go7c1.SetActive(false);
        go7c2.SetActive(true);
    }

    public void onButtonShow7c3() {
        go7c2.SetActive(false);
        go7c3.SetActive(true);
    }

    public void onButtonShow7c4() {
        go7c3.SetActive(false);
        go7c4.SetActive(true);
    }

    public void onButtonShow7c5() {
        go7c4.SetActive(false);
        go7c5.SetActive(true);
    }

    public void onButtonShow7c6() {
        go7c5.SetActive(false);
        go7c6.SetActive(true);
    }

    public void onButtonShow7c7() {
        go7c6.SetActive(false);
        go7c7.SetActive(true);
    }
}
