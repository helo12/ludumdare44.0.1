using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameStatsTracker
{
	public static class PlayerStats
	{
		private static int HP=4, money=0, points=0, level=1;
		private static bool dead = false;

		public static int HealthPoints
		{
			get
			{
				return HP;
			}
			set
			{
				HP = value;
			}
		}

		public static bool Dead
		{
			get
			{
				return dead;
			}
			set
			{
				dead = value;
			}
		}

		public static int Money
		{
			get
			{
				return money;
			}
			set
			{
				money = value;
			}
		}

		public static int Points
		{
			get
			{
				return points;
			}
			set
			{
				points = value;
			}
		}
		public static int Level
		{
			get
			{
				return level;
			}
			set
			{
				level = value;
			}
		}
	}
}
