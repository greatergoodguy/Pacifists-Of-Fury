using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetiCharacterSelect : Seti_Base
{
	public static SetiCharacterSelect I { get; private set; }

	UICharacterSelect uiCharacterSelect;

	bool isFinished;

	void Awake() {
		I = this;
	}

	public override void Enter() {
		uiCharacterSelect = UICharacterSelect.I;
		uiCharacterSelect.Show();

		isFinished = false;
	}

	public override void Exit() {
		uiCharacterSelect.Hide();
	}

	public override bool IsFinished() {
		return isFinished;
	}

	public override Seti_Base GetNextSeason() {
		return SetiGame.I;
	}

	// ====================
	// UI Callbacks
	// ====================
	public void OnButtonStart() {
		isFinished = true;
	}
}
