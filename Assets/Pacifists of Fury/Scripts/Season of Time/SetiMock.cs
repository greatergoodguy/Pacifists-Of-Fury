using UnityEngine;
using System.Collections;

public class SetiMock : Seti_Base {

	public static SetiMock I;

	void Awake() {
		I = this;
	}

}