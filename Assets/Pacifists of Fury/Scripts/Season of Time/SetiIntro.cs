using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetiIntro : Seti_Base
{
	public static SetiIntro I { get; private set; }

	UIIntro uiIntro;

	bool isFinished;

	void Awake() {
		I = this;
	}

	public override void Enter() {
		uiIntro = UIIntro.I;
		uiIntro.Show();

		isFinished = false;
	}

	public override void Exit() {
		uiIntro.Hide();
	}

	public override bool IsFinished() {
		return isFinished;
	}

	public override Seti_Base GetNextSeason() {
		return SetiCharacterSelect.I;
	}

	// ====================
	// UI Callbacks
	// ====================
	public void OnButtonSkip() {
		isFinished = true;

	}
}
