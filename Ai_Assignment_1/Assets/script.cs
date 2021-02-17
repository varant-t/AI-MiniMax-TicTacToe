using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine.UI;

public class MNode 
{ 
	public int x;
	public int y;
	public int player;

}

public class MovesAndScores 
{
	public int score;
	public MNode point;

	public MovesAndScores(int score, MNode point) 
	{
		this.score = score;
		this.point = point;
	}
}

public class script : MonoBehaviour 
{
	public GameObject xprefab;
	public GameObject oprefab;
	MNode[,] gameBoard = new MNode[3,3];
	public List<MovesAndScores> bestPositions;
	public GameObject ui;

	void Start ()
	{

	}

	// Update is called once per frame
	void Update () {
		if (!isGameOver()) {
			if (Input.GetKeyDown ("1") && isValidMove (0,0))
			{
				Instantiate (xprefab, new Vector3 (0, 1, 0), Quaternion.identity);
				MNode node = new MNode ();
				node.x = 0;
				node.y = 0;
				node.player = 1; 
				gameBoard[node.x, node.y] = node; 
				callMinimax (0, 1);
				
				MNode best = returnBestMove ();
				if(isValidMove(best.x, best.y))
				{
					Instantiate (oprefab, new Vector3 (best.x, 1, best.y), Quaternion.identity);
					best.player = 2;
					gameBoard[best.x,best.y] = best;
				}

			}
			if (Input.GetKeyDown ("2") && isValidMove (0,1))
			{
				Instantiate (xprefab, new Vector3 (0, 1, 1), Quaternion.identity);
				MNode node = new MNode ();
				node.x = 0;
				node.y = 1;
				node.player = 1;
				gameBoard[node.x, node.y] = node;
				callMinimax (0, 1);
			
				MNode best = returnBestMove ();
				if(isValidMove(best.x, best.y))
				{
					Instantiate (oprefab, new Vector3 (best.x, 1, best.y), Quaternion.identity);
					best.player = 2;
					gameBoard[best.x,best.y] = best;
				}
			}
			if (Input.GetKeyDown ("3") && isValidMove (0,2)) 
			{
				Instantiate (xprefab, new Vector3 (0, 1, 2), Quaternion.identity);
				MNode node = new MNode ();
				node.x = 0;
				node.y = 2;
				node.player = 1;
				gameBoard[node.x, node.y] = node;
				callMinimax (0, 1);
			
				MNode best = returnBestMove ();
				if(isValidMove(best.x, best.y))
				{
					Instantiate (oprefab, new Vector3 (best.x, 1, best.y), Quaternion.identity);
					best.player = 2;
					gameBoard[best.x,best.y] = best;
				}
			}
			if (Input.GetKeyDown ("4") && isValidMove (1,0))
			{
				Instantiate (xprefab, new Vector3 (1, 1, 0), Quaternion.identity);
				MNode node = new MNode ();
				node.x = 1;
				node.y = 0;			
				node.player = 1;
				gameBoard[node.x, node.y] = node;
				callMinimax (0, 1);

				MNode best = returnBestMove ();
				if(isValidMove(best.x, best.y))
				{
					Instantiate (oprefab, new Vector3 (best.x, 1, best.y), Quaternion.identity);
					best.player = 2;
					gameBoard[best.x,best.y] = best;
				}
			}
			if (Input.GetKeyDown ("5") && isValidMove (1,1)) 
			{
				Instantiate (xprefab, new Vector3 (1, 1, 1), Quaternion.identity);
				MNode node = new MNode ();
				node.x = 1;
				node.y = 1;
				node.player = 1;
				gameBoard[node.x, node.y] = node;
				callMinimax (0, 1);

				MNode best = returnBestMove ();
				if(isValidMove(best.x, best.y))
				{
					Instantiate (oprefab, new Vector3 (best.x, 1, best.y), Quaternion.identity);
					best.player = 2;
					gameBoard[best.x,best.y] = best;
				}
			}
			if (Input.GetKeyDown ("6") && isValidMove (1,2))
			{
				Instantiate (xprefab, new Vector3 (1, 1, 2), Quaternion.identity);
				MNode node = new MNode ();
				node.x = 1;
				node.y = 2;
				node.player = 1;
				gameBoard[node.x, node.y] = node;
				callMinimax (0, 1);

				MNode best = returnBestMove ();
				if(isValidMove(best.x, best.y))
				{
					Instantiate (oprefab, new Vector3 (best.x, 1, best.y), Quaternion.identity);
					best.player = 2;
					gameBoard[best.x,best.y] = best;
				}
			}
			if (Input.GetKeyDown ("7") && isValidMove (2,0))
			{
				Instantiate (xprefab, new Vector3 (2, 1, 0), Quaternion.identity);
				MNode node = new MNode ();
				node.x = 2;
				node.y = 0;
				node.player = 1;
				gameBoard[node.x, node.y] = node;
				callMinimax (0, 1);

				MNode best = returnBestMove ();
				if(isValidMove(best.x, best.y))
				{
					Instantiate (oprefab, new Vector3 (best.x, 1, best.y), Quaternion.identity);
					best.player = 2;
					gameBoard[best.x,best.y] = best;
				}
			}
			if (Input.GetKeyDown ("8") && isValidMove (2,1)) 
			{
				Instantiate (xprefab, new Vector3 (2, 1, 1), Quaternion.identity);
				MNode node = new MNode ();
				node.x = 2;
				node.y = 1;
				node.player = 1;
				gameBoard[node.x, node.y] = node;
				callMinimax (0, 1);

				MNode best = returnBestMove ();
				if(isValidMove(best.x, best.y))
				{
					Instantiate (oprefab, new Vector3 (best.x, 1, best.y), Quaternion.identity);
					best.player = 2;
					gameBoard[best.x,best.y] = best;
				}
			}
			if (Input.GetKeyDown ("9") && isValidMove (2,2)) 
			{
				Instantiate (xprefab, new Vector3 (2, 1, 2), Quaternion.identity);
				MNode node = new MNode ();
				node.x = 2;
				node.y = 2;
				node.player = 1;
				gameBoard[node.x, node.y] = node;
				callMinimax (0, 1);

				MNode best = returnBestMove ();
				if(isValidMove(best.x, best.y))
				{
					Instantiate (oprefab, new Vector3 (best.x, 1, best.y), Quaternion.identity);
					best.player = 2;
					gameBoard[best.x,best.y] = best;
				}

			
			}
		}

	}

	public bool hasOWon(){
		if (gameBoard[0, 0] != null && gameBoard[1, 1] != null && gameBoard[2, 2] != null) 
		{
			if (gameBoard[0, 0].player == gameBoard[1, 1].player && gameBoard[0, 0].player == gameBoard[2, 2].player && gameBoard[0, 0].player == 1)
				return true;
		}
		if (gameBoard[0, 2] != null && gameBoard[1, 1] != null && gameBoard[2, 0] != null) 
		{
			if(gameBoard[0, 2].player == gameBoard[1, 1].player && gameBoard[0, 2].player == gameBoard[2, 0].player && gameBoard[0, 2].player == 1)
				return true;
		}
		for (int i = 0; i < 3; ++i) {
			if(gameBoard[i,0] != null && gameBoard[i,1] != null && gameBoard[i,2] != null) 
			{
				if(gameBoard[i,0].player == gameBoard[i,1].player && gameBoard[i,0].player == gameBoard[i,2].player && gameBoard[i,0].player == 1)
					return true;
			}
			if(gameBoard[0,i] != null && gameBoard[1,i] != null && gameBoard[2,i] != null)
			{
				if(gameBoard[0,i].player == gameBoard[1,i].player && gameBoard[0,i].player == gameBoard[2,i].player && gameBoard[0,i].player == 1)
					return true;
			}
		}
		return false;
	}

	public bool hasXWon() {
		if (gameBoard[0, 0] != null && gameBoard[1, 1] != null && gameBoard[2, 2] != null) 
		{
			if (gameBoard[0, 0].player == gameBoard[1, 1].player && gameBoard[0, 0].player == gameBoard[2, 2].player && gameBoard[0, 0].player == 2)
				return true;
		}
		if (gameBoard[0, 2] != null && gameBoard[1, 1] != null && gameBoard[2, 0] != null) 
		{
			if(gameBoard[0, 2].player == gameBoard[1, 1].player && gameBoard[0, 2].player == gameBoard[2, 0].player && gameBoard[0, 2].player == 2)
				return true;
		}
		
		for (int i = 0; i < 3; ++i) {
			if(gameBoard[i,0] != null && gameBoard[i,1] != null && gameBoard[i,2] != null) 
			{
				if(gameBoard[i,0].player == gameBoard[i,1].player && gameBoard[i,0].player == gameBoard[i,2].player && gameBoard[i,0].player == 2)
					return true;
			}
			if(gameBoard[0,i] != null && gameBoard[1,i] != null && gameBoard[2,i] != null) 
			{
				if(gameBoard[0,i].player == gameBoard[1,i].player && gameBoard[0,i].player == gameBoard[2,i].player && gameBoard[0,i].player == 2)
					return true;
			}
		}
		return false; 
	}

	public bool isGameOver() 
	{
		Text text = ui.GetComponent<Text>();
		
		if (getMoves().Capacity == 0)
		{
			text.text = "It's a draw!";
			return true;
		}

		if (hasOWon()) 
		{
			text.text = "You Won!";
			return true;
		}

		if (hasXWon())
		{
			text.text = "You lost!";
			return true;
		}
		return false;

	}

	List<MNode> getMoves()
	{
		List<MNode> result = new List<MNode>();
		for(int row = 0; row < 3; row++) 
		{
			for(int col = 0; col < 3; col++)
			{
				if(gameBoard[row,col] == null)
				{
					MNode newNode = new MNode();
					newNode.x = row;
					newNode.y = col;
					result.Add(newNode); 
				}
			}
		}
		return result;
	}

	public MNode returnBestMove()
	{
		int MAX = -100000;
		int best = -1;

		for (int i = 0; i < bestPositions.Count; i++)
		{ 
			if (MAX < bestPositions[i].score && isValidMove(bestPositions[i].point.x, bestPositions[i].point.y)) 
			{
				MAX = bestPositions[i].score;
				best = i;
			}
		}
		if(best > -1)
			return bestPositions[best].point;
		MNode blank = new MNode();
		blank.x = 0;
		blank.y = 0;
		return blank;
	}

	public bool isValidMove(int x, int y) 
	{
		if (gameBoard[x, y] == null)
			return true;
		return false;
	}

	
	public int returnMin(List<int> list) 
	{
		int min = 100000;
		int index = -1;
		for (int i = 0; i < list.Count; ++i)
		{
			if (list[i] < min)
			{
				min = list[i];
				index = i;
			}
		}
		return list[index];
	}

	
	public int returnMax(List<int> list)
	{
		int max = -100000;
		int index = -1;
		for (int i = 0; i < list.Count; ++i) 
		{
			if (list[i] > max) {
				max = list[i];
				index = i;
			}
		}
		return list[index];
	}


	public void callMinimax(int depth, int turn)
	{
		bestPositions = new List<MovesAndScores>();
		minimax(depth, turn);
	}

	public int minimax(int depth, int turn) 
	{
		
		if (hasXWon()) return +1; 
		if (hasOWon()) return -1; 
		
		List<MNode> pointsAvailable = getMoves();
		if (pointsAvailable.Capacity == 0) return 0; 
		
		List<int> scores = new List<int>(); 
		
		for (int i = 0; i < pointsAvailable.Count; i++)
		{
			MNode point = pointsAvailable[i];

		
			if (turn == 1) 
			{ 
				MNode x = new MNode();
				x.x = point.x;
				x.y = point.y;
				x.player = 2;
				gameBoard[point.x,point.y] = x;

				int currentScore = minimax(depth + 1, 2);
				scores.Add(currentScore);
				
				if (depth == 0) 
				{
					MovesAndScores m = new MovesAndScores(currentScore, point);
					m.point = point;
					m.score = currentScore;
					bestPositions.Add(m);
				}
				
			}

			else if (turn == 2)
			{
				MNode o = new MNode();
				o.x = point.x;
				o.y = point.y;
				o.player = 1;
				gameBoard[point.x,point.y] = o;
				int currentScore = minimax(depth+1,1);
				scores.Add(currentScore);
			}
			gameBoard[point.x, point.y] = null;
		}
		return turn == 1 ? returnMax(scores) : returnMin(scores);
	}
}
