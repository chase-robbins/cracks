using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class highScoreTable : MonoBehaviour {

	public int[] numbers = new int[10];

	private Text text;

	// Use this for initialization
	void Start () {
	
		text = GetComponent<Text> ();
		Refresh ();
	}
	void Refresh(){
		string AllTheHighScores = PlayerPrefs.GetString ("highscores");
		print ("all the current high scores: " + AllTheHighScores);
		if (AllTheHighScores != null) {
			string s = AllTheHighScores;//"1\n2\n3\n4\n10\n";
			string[] tokens = s.Split('\n');
			for(int i = 0; i < tokens.Length; i++)
			{
				Debug.Log (i+" = "+tokens[i]);
			}
			numbers = new int[tokens.Length]; //read ALL of the scores in
			for(int i = 0; i < numbers.Length && i < tokens.Length; i++){
				try{
					numbers[i] = int.Parse(tokens[i]);
				}catch(System.Exception e){
					Debug.LogWarning("An error ahhhhhhhhh" + e);
				}
			}
		System.Array.Sort(numbers);
		System.Array.Reverse(numbers);
		System.Array.Resize(ref numbers, 10);	
		}
		text.text = "";
		for(int i = 0; i < numbers.Length; i++){	

			if(i>0){
				text.text += "\n";
			}
			text.text += numbers[i];
		}
		AllTheHighScores = "";
		for(int i = 0; i < numbers.Length; i++){

			AllTheHighScores += numbers[i] + "\n";

		}
		PlayerPrefs.SetString ("highscores", AllTheHighScores);
	}
	public static void Add(int score){
		string allTheScores = PlayerPrefs.GetString("highscores", "");
		allTheScores += "\n" + score;
		PlayerPrefs.SetString("highscores", allTheScores);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}