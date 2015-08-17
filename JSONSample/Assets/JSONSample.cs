using UnityEngine;
using System.Collections;
using System.IO; //System.IO.FileInfo, System.IO.StreamReader, System.IO.StreamWriter
using System; //Exception
using System.Text; //Encoding
using SimpleJSON;

public class JSONSample : MonoBehaviour {

	public string jsonFileName;
	private JSONNode json;

	// Update is called once per frame
	void Update () {
		// スペースキーを押したらファイル読み込みをする
		if (Input.GetKeyDown (KeyCode.Space)) {
			ReadFile ();
		}   
	}
	// 読み込んだ情報をGUIとして表示
	void OnGUI()
	{
		if (json != null) {
			// キーワードがnameの値を取り出す
			GUI.TextArea (new Rect (0, 0, Screen.width, Screen.height), "name:" + json["name"]);
		}
	}

	// 読み込み関数
	void ReadFile(){
		string fileText = "";

		// FileReadTest.txtファイルを読み込む
		FileInfo fi = new FileInfo(Application.dataPath + "/" + jsonFileName);
		try {
			// 一行毎読み込み
			using (StreamReader sr = new StreamReader(fi.OpenRead(), Encoding.UTF8)){
				fileText = sr.ReadToEnd();
				// JSONをパースして値を取り出す
				json = JSONNode.Parse(fileText);
			}
		} catch (Exception e){
			// 改行コード
			fileText += "\n";
		}
	}
}
