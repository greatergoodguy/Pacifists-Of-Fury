using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetiGame : Seti_Base {

    public static SetiGame I { get; private set; }

	UIGame uiGame;

	bool isFinished;

	void Awake() {
		I = this;
	}

	public override void Enter() {
		uiGame = UIGame.I;
		uiGame.Show();

		isFinished = false;
	}

	public override void Exit() {
		uiGame.Hide();
	}

	public override bool IsFinished() {
		return isFinished;
	}

	public override Seti_Base GetNextSeason() {
		return SetiCharacterSelect.I;
	}

}
