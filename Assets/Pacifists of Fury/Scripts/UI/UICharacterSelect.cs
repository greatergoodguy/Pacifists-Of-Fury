using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UICharacterSelect : MonoBehaviour
{
    string[] attributesGood = { "Good Budgeter", "Decisive", "Forceful", "Negotiator", "Calm Under Fire", "Dead Inside", "Emo", "Cheery", "Mellow", "Friendly", "Athletic", "Observant", "Mechanical", "Creative", "Empathic", "Kind", "Good Leader", "Smart", "Brave", "Flexible", "Fast", "Strong", "Good Cook", "Artistic", "Compu - savvy", "Literary", "Good Medic", "Good Driver", "Good Aim", "Home Improver", "Reasonable", "Industrious", "Charming", "Nature Child", "Language Master", "Broadway Star" };
    string[] attributesBad = { "Spendthrift", "Indecisive", "Meek", "Bad Negotiator", "Panicky", "Chatty", "Cutesy", "Gloomy", "Moody", "Hostile", "Clumsy", "Oblivious", "Breaker of Things", "Uncreative", "Callous", "Mean", "Bad Leader", "Dumb As Rock", "Inflexible", "Slow", "Weak", "Bad Cook", "Art Doofus", "Compu-moron", "Illiterate", "Bad Medic", "Bad Driver", "Bad Aim", "Home Destroyer", "Unreasonable", "Lazy", "Tactless", "Bad Camper", "Bad Communicator", "Stage Monster" };

    public static UICharacterSelect I;

    GameObject goContainer;

    TMP_Dropdown dropdownAttribute1;
    TMP_Dropdown dropdownAttribute2;
    TMP_Dropdown dropdownAttribute3;

    void Awake() {
        I = this;
        goContainer = transform.Find("Container").gameObject;

        dropdownAttribute1 = goContainer.transform.Find("Attribute 1 Panel/Dropdown").GetComponent<TMP_Dropdown>();
        foreach(string attribute in attributesGood) {
            dropdownAttribute1.options.Add(new TMP_Dropdown.OptionData(attribute));
        }

        dropdownAttribute2 = goContainer.transform.Find("Attribute 2 Panel/Dropdown").GetComponent<TMP_Dropdown>();
        foreach (string attribute in attributesGood) {
            dropdownAttribute2.options.Add(new TMP_Dropdown.OptionData(attribute));
        }

        dropdownAttribute3 = goContainer.transform.Find("Attribute 3 Panel/Dropdown").GetComponent<TMP_Dropdown>();
        foreach (string attribute in attributesBad) {
            dropdownAttribute3.options.Add(new TMP_Dropdown.OptionData(attribute));
        }
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
