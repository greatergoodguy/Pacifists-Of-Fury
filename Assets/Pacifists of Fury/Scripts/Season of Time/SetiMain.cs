using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetiMain : Seti_Base {

	public static SetiMain I { get; private set; }

	UIMain uiMain;

	bool isFinished;

	void Awake() {
		I = this;
	}

	public override void Enter() {
		uiMain = UIMain.I;
		uiMain.Show();

		isFinished = false;
	}

	public override void Exit() {
		uiMain.Hide();
	}

	public override bool IsFinished() {
		return isFinished;
	}

	public override Seti_Base GetNextSeason() {
		return SetiIntro.I;
	}

	// ====================
	// UI Callbacks
	// ====================
	public void OnButtonPlay() {
		isFinished = true;
	}
}
