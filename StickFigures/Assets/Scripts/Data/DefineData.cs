using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefineData : SingletonMonoBehaviour<DefineData>
{
	//シーン名
	public const string SCENE_MANAGER = "00_Manager";
	public const string SCENE_TITLE = "01_Title";
	public const string SCENE_FACTURING = "02_Manufacturing";
	public const string SCENE_GAME = "03_Game";

	//方向
	public const int LEFT = 0;
	public const int UP = 1;
	public const int RIGHT = 2;
	public const int DOWN = 3;

	public const string STICKMAN_TAG = "Stickman";
}
