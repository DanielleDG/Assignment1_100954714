using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player{

		private int _points = 0;
		private int _health = 100;

		public HUDController hud;

		private static Player _instance = null;
		public static Player Instance{

			get{ 
				if (_instance == null) {

					_instance = new Player ();
				}
				return _instance;
			}
		}

		private Player(){
		}

		public int Points{
			get{ 
				return _points;
			}

			set{ 
				_points = value;

				//trigger UI update
				hud.UpdatePoints();
			}
		}

		public int Health{
			get{ 
				return _health;
			}

			set{ 
				_health = value;

				//trigger UI update
				hud.UpdateHealth();
				if (_health <= 0){
				SceneManager.LoadScene ("GameOverScreen");
			}
		}
		}


}
