using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Keyboard{

	public KeyCode TapOne = KeyCode.A;
	public KeyCode TapTwo = KeyCode.S;
	public KeyCode TapThree = KeyCode.D;
	public KeyCode TapFour = KeyCode.J;
	public KeyCode TapFive = KeyCode.K;
	public KeyCode TapSix = KeyCode.L;
	public KeyCode TapSpecial = KeyCode.Space;
	public KeyCode TapConfirm = KeyCode.KeypadEnter;

	public Keyboard GetDefaultConfigrtaion(){
		return new Keyboard(){
			TapOne= KeyCode.A,
			TapTwo= KeyCode.S,
			TapThree= KeyCode.D,
			TapFour=KeyCode.J,
			TapFive=KeyCode.K,
			TapSix=KeyCode.L,
			TapConfirm=KeyCode.Space,
			TapSpecial=KeyCode.KeypadEnter
		};
	}
}