using System;

public class Player : ISaveable
{
	int _hp;

	public Player()
	{
		_hp = 0;
	}

	void Hit(int damage)
	{
		_hp -= damage;
	}
}
